using Livraria.Extensions;

namespace Livraria.Classes.ModuloExemplar;

public class Livro : Exemplar
{
    public int Paginas { get; set; }
    public TipoCapa TipoCapa { get; set; }
    public string Isbn { get; set; }


    public Livro(int paginas, TipoCapa tipoCapa, string isbn, string titulo, string subTitulo, string escritor, string editora, int anoPublicado, string genero, int status) : base(titulo, subTitulo, escritor, editora, anoPublicado, genero, status)
    {
        Paginas = paginas;
        TipoCapa = tipoCapa;
        Isbn = isbn;
    }
    public override string ToString() => base.ToString();

    public override string MostrarDados()
    {
        return base.MostrarDados() +
               $"\nPáginas: {Paginas}" +
               $"\nTipo de Capa: {TipoCapa.GetDescription()}" +
               $"\nISBN: {Isbn}";
    }

}
