using System.ComponentModel;
using Livraria.Common;
using Livraria.Extensions;

namespace Livraria.Classes.ModuloExemplar
{
    public class Ebook : Livro
    {
        public FormatoEbook Formato { get; set; }
        public double Tamanho { get; set; }
        public string Url { get; set; }

        public Ebook(FormatoEbook formato, double tamanho, string url, int paginas, string tipoCapa, string isbn, string titulo, string subTitulo, string escritor, string editora, int anoPublicado, string genero, int status) : base(paginas, tipoCapa, isbn, titulo, subTitulo, escritor, editora, anoPublicado, genero, status)
        {
            Formato = formato;
            Tamanho = tamanho;
            Url = url;
        }

        public override string ToString() => base.ToString();

        public override string MostrarDados()
        {
            return base.MostrarDados() +
                   $"\nFormato: {Formato.GetDescription()}" +
                   $"\nTamanho (MB): {Tamanho}" +
                   $"\nURL: {Url}";
        }

        
    }
}
