
using ProjetoAgenda_contatos_;

internal class Contato
{
    private string email;
    private string nome;
    private Data dtNasc;
    private List<Telefone> telefones;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Data DtNasc
    {
        get { return dtNasc; }
        set { dtNasc = value; }
    }

    public List<Telefone> Telefones
    {
        get { return new List<Telefone>(telefones); }
    }

    public Contato()
    {
        telefones = new List<Telefone>();
    }

    public Contato(string email, string nome, Data dtNasc)
    {
        Email = email;
        Nome = nome;
        DtNasc = dtNasc;
        telefones = new List<Telefone>();
    }

    public Contato(string email) : this()
    {
        Email = email;
    }

    public int getIdade()
    {
        DateTime hoje = DateTime.Today;

        int idade = hoje.Year - DtNasc.Ano;

        if (DtNasc.Mes > hoje.Month ||
            (DtNasc.Mes == hoje.Month && DtNasc.Dia > hoje.Day))
        {
            idade--;
        }

        return idade;
    }

    public void adicionarTelefone(Telefone telefone)
    {
        telefones.Add(telefone);
    }

    public string getTelefonePrincipal()
    {
        foreach (Telefone telefone in telefones)
        {
            if (telefone.Principal)
                return telefone.Numero;
        }

        return "";
    }

    public override string ToString()
    {
        return $"Contato: {Nome}\n" +
               $"Email: {Email}\n" +
               $"Data de Nascimento: {DtNasc}\n" +
               $"Idade: {getIdade()}\n" +
               $"Telefone: {getTelefonePrincipal()}";
    }

    public override bool Equals(object obj)
    {
        if (obj is not Contato outro)
            return false;

        return string.Equals(
            Email, outro.Email,
            StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return Email == null
            ? 0
            : StringComparer.OrdinalIgnoreCase.GetHashCode(Email);
    }
}
