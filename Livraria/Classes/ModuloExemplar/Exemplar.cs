using Livraria.Extensions;
using Livraria.Interface;

namespace Livraria.Classes.ModuloExemplar;

public abstract class Exemplar : Dados
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string SubTitulo { get; set; }
    public string Escritor { get; set; }
    public string Editora { get; set; }
    public int AnoPublicado { get; set; }
    public Genero Genero { get; set; }
    public StatusExemplar Status { get; set; }

    public Exemplar(string titulo, string subTitulo, string escritor, string editora, int anoPublicado, Genero genero, StatusExemplar status)
    {
        Titulo = titulo;
        SubTitulo = subTitulo;
        Escritor = escritor;
        Editora = editora;
        AnoPublicado = anoPublicado;
        Genero = genero;
        Status = status;
    }
    public override string ToString() => base.ToString();

    public virtual string MostrarDados()
    {
        return $"Título: {Titulo}\n" +
               $"Subtítulo: {SubTitulo}\n" +
               $"Escritor: {Escritor}\n" +
               $"Editora: {Editora}\n" +
               $"Ano de Publicação: {AnoPublicado}\n" +
               $"Gênero: {Genero.GetDescription()}\n" +
               $"Status: {Status.GetDescription()}";
    }
}
//Gilberto Mota de Oliveira Junior