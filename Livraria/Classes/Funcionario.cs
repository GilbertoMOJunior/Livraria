namespace Livraria.Classes;

public class Funcionario : Pessoa
{

    public string Cargo { get; set; }
    public int Matricula { get; set; }
    public Funcionario(string nome, string telefone, string email, string cargo, int matricula)
        : base(nome, telefone, email)
    {
        Cargo = cargo;
        Matricula = matricula;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(Funcionario novoRegistro)
    {
        base.AtualizarRegistro(novoRegistro);
        Cargo = novoRegistro.Cargo;
        Matricula = novoRegistro.Matricula;
    }
}
