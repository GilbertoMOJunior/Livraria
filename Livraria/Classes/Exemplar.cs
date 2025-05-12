using Livraria.Classes.Enum;

namespace Livraria.Classes;

public class Exemplar
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public Generos Genero { get; set; }
    public decimal Preco { get; set; }

    public Exemplar(string titulo, Generos genero, decimal preco)
    {
        Titulo = titulo;
        Genero = genero;
        Preco = preco;
    }


    public override string ToString()
    {
        return base.ToString();
    }


    public void AtualizarRegistro(Exemplar novoRegistro)
    {
        Titulo = novoRegistro.Titulo;
        Genero = novoRegistro.Genero;
        Preco = novoRegistro.Preco;
    }
}
