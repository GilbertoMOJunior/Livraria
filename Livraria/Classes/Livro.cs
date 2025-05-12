using Livraria.Classes.Enum;

namespace Livraria.Classes;

public class Livro : Exemplar
{
    public string Autor { get; set; }
    public int Paginas { get; set; }

    public Livro(string titulo, Generos genero, decimal preco, string autor, int paginas)
        : base(titulo, genero, preco)
    {
        Autor = autor;
        Paginas = paginas;

    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(Livro novoRegistro)
    {
        base.AtualizarRegistro(novoRegistro);

        Autor = novoRegistro.Autor;
        Paginas = novoRegistro.Paginas;
    }
}
