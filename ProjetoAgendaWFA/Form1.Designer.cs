namespace ProjetoAgendaWFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            dtpNascimento = new DateTimePicker();
            txtTipo = new TextBox();
            txtNumero = new TextBox();
            chkPrincipal = new CheckBox();
            txtPesquisa = new TextBox();
            dgvContatos = new DataGridView();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            btnAlterar = new Button();
            btnListar = new Button();
            btnLimpar = new Button();
            btnRemover = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(111, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(111, 125);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 2;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(111, 154);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(111, 192);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.Location = new Point(111, 233);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new Size(72, 19);
            chkPrincipal.TabIndex = 5;
            chkPrincipal.Text = "Principal";
            chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(111, 258);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(100, 23);
            txtPesquisa.TabIndex = 6;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(291, 288);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.Size = new Size(240, 150);
            dgvContatos.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(627, 50);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(627, 89);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(627, 127);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(627, 245);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 13;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(627, 207);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(627, 168);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 11;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 58);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 127);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 16;
            label3.Text = "Nasc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 157);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 17;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 195);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 18;
            label5.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 261);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 19;
            label6.Text = "Pesquisa";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListar);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnAlterar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvContatos);
            Controls.Add(txtPesquisa);
            Controls.Add(chkPrincipal);
            Controls.Add(txtNumero);
            Controls.Add(txtTipo);
            Controls.Add(dtpNascimento);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private DateTimePicker dtpNascimento;
        private TextBox txtTipo;
        private TextBox txtNumero;
        private CheckBox chkPrincipal;
        private TextBox txtPesquisa;
        private DataGridView dgvContatos;
        private Button btnAdicionar;
        private Button btnPesquisar;
        private Button btnAlterar;
        private Button btnListar;
        private Button btnLimpar;
        private Button btnRemover;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
