using Livraria.Extensions;

namespace Livraria.Classes.ModuloExemplar;

public class Generico : Exemplar
{
    public TipoGenerico Tipo { get; set; }

    public Generico(TipoGenerico tipo, string titulo, string subTitulo, string escritor, string editora, int anoPublicado, Genero genero, StatusExemplar status) : base(titulo, subTitulo, escritor, editora, anoPublicado, genero, status)
    {
        Tipo = tipo;
    }
    public override string ToString() => base.ToString();

    public override string MostrarDados()
    {
        return base.MostrarDados() + $"\nTipo: {Tipo.GetDescription()}";
    }
}
//Gilberto Mota de Oliveira Junior