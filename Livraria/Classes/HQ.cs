using Livraria.Classes.Enum;

namespace Livraria.Classes;

public class HQ : Exemplar
{
    public string Autor { get; set; }
    public int Edicao { get; set; }

    public HQ(string titulo, Generos genero, decimal preco, string autor, int edicao)
        : base(titulo, genero, preco)
    {
        Autor = autor;
        Edicao = edicao;
    }


    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(HQ novo)
    {
        base.AtualizarRegistro(novo);
        Autor = novo.Autor;
        Edicao = novo.Edicao;
    }
}
