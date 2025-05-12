namespace Livraria.Classes;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(Pessoa novoRegistro)
    {
        Nome = novoRegistro.Nome;
        Telefone = novoRegistro.Telefone;
        Email = novoRegistro.Email;
    }
}
