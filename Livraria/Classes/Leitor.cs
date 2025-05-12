using Livraria.Classes.Enum;

namespace Livraria.Classes;

public class Leitor : Pessoa
{
    public int Matricula { get; set; }
    public Generos GeneroPreferido { get; set; }

    public Leitor(string nome, string telefone, string email, int matricula, Generos generoPreferido)
        : base(nome, telefone, email)
    {
        Matricula = matricula;
        GeneroPreferido = generoPreferido;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(Leitor novoRegistro)
    {
        base.AtualizarRegistro(novoRegistro);

        Matricula = novoRegistro.Matricula;
        GeneroPreferido = novoRegistro.GeneroPreferido;
    }
}
