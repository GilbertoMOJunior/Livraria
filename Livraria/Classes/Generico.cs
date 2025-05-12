using Livraria.Classes.Enum;

namespace Livraria.Classes;

public class Generico : Exemplar
{
    public string Autor { get; set; }
    public string Idioma { get; set; }

    public Generico(string titulo, Generos genero, decimal preco, string autor, string idioma)
        : base(titulo, genero, preco)
    {
        Autor = autor;
        Idioma = idioma;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void AtualizarRegistro(Generico novoRegistro)
    {
        base.AtualizarRegistro(novoRegistro);

        Autor = novoRegistro.Autor;
        Idioma = novoRegistro.Idioma;
    }
}
