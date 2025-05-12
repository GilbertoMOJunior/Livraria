using Livraria.Classes;
using Livraria.Classes.Enum;

namespace Livraria.Apresentacao.ModuloHQ
{
    public partial class HQForm : Form
    {
        public HQ HQ
        {
            get => hq;
            set
            {
                txtTitulo.Text = value.Titulo;
                txtGenero.Text = value.Genero.ToString();
                txtPreco.Text = value.Preco.ToString();
                txtAutor.Text = value.Autor;
                txtEdicao.Text = value.Edicao.ToString();
            }
        }
        public HQ hq;

        public HQForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            hq = new HQ(txtTitulo.Text, (Generos)int.Parse(txtGenero.Text), decimal.Parse(txtPreco.Text), txtAutor.Text, int.Parse(txtEdicao.Text));
        }
    }
}
