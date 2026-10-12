using ProjetoAgenda_contatos_;

namespace ProjetoAgendaWFA
{
    public partial class Form1 : Form
    {
        private Contatos agenda = new Contatos();
        private string emailSelecionado = null;
        public Form1()
        {
            InitializeComponent();

            dtpNascimento.MaxDate = DateTime.Today;
            dgvContatos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.MultiSelect = false;
            dgvContatos.ReadOnly = true;
            dgvContatos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvContatos.AllowUserToAddRows = false;

            dgvContatos.CellClick += dgvContatos_CellClick;

            AtualizarGrid();

        }

        private Contato CriarContatoDosCampos()
        {
            DateTime data = dtpNascimento.Value;

            Contato contato = new Contato(
                txtEmail.Text.Trim(),
                txtNome.Text.Trim(),
                new Data(data.Day, data.Month, data.Year)
            );

            if (!string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                Telefone telefone = new Telefone(
                    txtTipo.Text.Trim(),
                    txtNumero.Text.Trim(),
                    chkPrincipal.Checked
                );

                contato.adicionarTelefone(telefone);
            }

            return contato;
        }

        private void AtualizarGrid()
        {
            dgvContatos.DataSource = null;

            dgvContatos.DataSource = agenda.listar()
                .Select(c => new
                {
                    c.Nome,
                    c.Email,
                    Nascimento = c.DtNasc.ToString(),
                    Idade = c.getIdade(),
                    TelefonePrincipal = c.getTelefonePrincipal()
                })
                .ToList();
        }

        private bool CamposValidos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Preencha o nome e o e-mail.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtNumero.Text) &&
                string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("Informe o tipo do telefone.");
                return false;
            }

            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!CamposValidos())
                return;

            Contato contato = CriarContatoDosCampos();

            if (agenda.adicionar(contato))
            {
                MessageBox.Show("Contato adicionado com sucesso!");
                AtualizarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Já existe um contato com esse e-mail.");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string email = txtPesquisa.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
                email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Informe o e-mail para pesquisar.");
                return;
            }

            Contato contato = agenda.pesquisar(new Contato(email));

            if (contato == null)
            {
                MessageBox.Show("Contato não encontrado.");
                return;
            }

            PreencherCampos(contato);
            emailSelecionado = contato.Email;
            SelecionarContatoNaGrid(contato.Email);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (emailSelecionado == null)
            {
                MessageBox.Show("Pesquise ou selecione um contato primeiro.");
                return;
            }

            if (!CamposValidos())
                return;

            Contato atualizado = CriarContatoDosCampos();

            if (agenda.alterar(emailSelecionado, atualizado))
            {
                MessageBox.Show("Contato alterado com sucesso!");
                emailSelecionado = atualizado.Email;
                AtualizarGrid();
                SelecionarContatoNaGrid(atualizado.Email);
            }
            else
            {
                MessageBox.Show(
                    "Não foi possível alterar. Verifique se o novo e-mail já existe.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (emailSelecionado == null)
            {
                MessageBox.Show("Selecione ou pesquise um contato primeiro.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente remover este contato?",
                "Confirmar remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            if (agenda.remover(new Contato(emailSelecionado)))
            {
                MessageBox.Show("Contato removido com sucesso!");
                AtualizarGrid();
                LimparCampos();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvContatos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string email = dgvContatos.Rows[e.RowIndex]
                .Cells["Email"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(email))
                return;

            Contato contato = agenda.pesquisar(new Contato(email));

            if (contato != null)
            {
                PreencherCampos(contato);
                emailSelecionado = contato.Email;
            }
        }

        private void PreencherCampos(Contato contato)
        {
            txtNome.Text = contato.Nome;
            txtEmail.Text = contato.Email;

            dtpNascimento.Value = new DateTime(
                contato.DtNasc.Ano,
                contato.DtNasc.Mes,
                contato.DtNasc.Dia);

            Telefone telefone = contato.Telefones.FirstOrDefault();

            if (telefone != null)
            {
                txtTipo.Text = telefone.Tipo;
                txtNumero.Text = telefone.Numero;
                chkPrincipal.Checked = telefone.Principal;
            }
            else
            {
                txtTipo.Clear();
                txtNumero.Clear();
                chkPrincipal.Checked = false;
            }
        }

        private void SelecionarContatoNaGrid(string email)
        {
            foreach (DataGridViewRow linha in dgvContatos.Rows)
            {
                if (string.Equals(
                    linha.Cells["Email"].Value?.ToString(),
                    email,
                    StringComparison.OrdinalIgnoreCase))
                {
                    linha.Selected = true;
                    dgvContatos.CurrentCell = linha.Cells["Nome"];
                    break;
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTipo.Clear();
            txtNumero.Clear();
            txtPesquisa.Clear();
            chkPrincipal.Checked = false;
            dtpNascimento.Value = DateTime.Today;

            emailSelecionado = null;
            dgvContatos.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
