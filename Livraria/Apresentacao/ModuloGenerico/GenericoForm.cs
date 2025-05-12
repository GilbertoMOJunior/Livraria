using Livraria.Classes;
using Livraria.Classes.Enum;

namespace Livraria.Apresentacao.ModuloGenerico
{
    public partial class GenericoForm : Form
    {

        public Generico Generico
        {
            get => generico;
            set
            {
                txtTitulo.Text = value.Titulo;
                txtGenero.Text = value.Genero.ToString();
                txtPreco.Text = value.Preco.ToString();
                txtAutor.Text = value.Autor;
                txtIdioma.Text = value.Idioma;
            }
        }
        public Generico generico;

        public GenericoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            generico = new Generico(txtTitulo.Text, (Generos)int.Parse(txtGenero.Text), decimal.Parse(txtPreco.Text), txtAutor.Text, txtIdioma.Text);
        }
    }
}
