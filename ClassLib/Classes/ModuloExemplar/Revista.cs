using ClassLib.Classes.Enum;

namespace Livraria.Classes.ModuloExemplar;

public class Revista : Exemplar
{
    public int Edicao { get; set; }
    public int Paginas { get; set; }

    public Revista(int edicao, int paginas, string titulo, string subTitulo, string escritor, string editora, int anoPublicado, Genero genero, StatusExemplar status) : base(titulo, subTitulo, escritor, editora, anoPublicado, genero, status)
    {
        Edicao = edicao;
        Paginas = paginas;
    }

    public override string ToString() => base.ToString();

    public override string MostrarDados()
    {
        return base.MostrarDados() +
               $"\nEdição: {Edicao}" +
               $"\nPáginas: {Paginas}";
    }
}
//Gilberto Mota de Oliveira Junior