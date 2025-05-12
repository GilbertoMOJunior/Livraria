using Livraria.Classes.Enum;

namespace Livraria.Classes;

public class Revista : Exemplar
{
    public string Editora { get; set; }
    public int Edicao { get; set; }

    public Revista(string titulo, Generos genero, decimal preco, string editora, int edicao)
        : base(titulo, genero, preco)
    {
        Editora = editora;
        Edicao = edicao;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(Revista novoRegistro)
    {
        base.AtualizarRegistro(novoRegistro);

        Editora = novoRegistro.Editora;
        Edicao = novoRegistro.Edicao;
    }
}
