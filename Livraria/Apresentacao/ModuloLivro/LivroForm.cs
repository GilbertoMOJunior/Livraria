using Livraria.Classes;
using Livraria.Classes.Enum;

namespace Livraria.Apresentacao.ModuloLivro
{
    public partial class LivroForm : Form
    {
        public Livro Livro
        {
            get => livro;
            set
            {
                txtTitulo.Text = value.Titulo;
                txtGenero.Text = value.Genero.ToString();
                txtPreco.Text = value.Preco.ToString();
                txtAutor.Text = value.Autor;
                txtPaginas.Text = value.Paginas.ToString();
            }
        }
        public Livro livro;
        public LivroForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            livro = new Livro(txtTitulo.Text, (Generos)int.Parse(txtGenero.Text), decimal.Parse(txtPreco.Text), txtAutor.Text, int.Parse(txtPaginas.Text));
        }
    }
}
