using Livraria.Classes;
using Livraria.Classes.Enum;

namespace Livraria.Apresentacao.ModuloRevista
{
    public partial class RevistaForm : Form
    {
        public Revista Revista
        {
            get => revista;
            set
            {
                txtTitulo.Text = value.Titulo;
                txtGenero.Text = value.Genero.ToString();
                txtPreco.Text = value.Preco.ToString();
                txtEditora.Text = value.Editora;
                txtEdicao.Text = value.Edicao.ToString();
            }
        }
        public Revista revista;

        public RevistaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtGenero.Text) || string.IsNullOrWhiteSpace(txtPreco.Text) || string.IsNullOrWhiteSpace(txtEditora.Text) || string.IsNullOrWhiteSpace(txtEdicao.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }
            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }
            if (!int.TryParse(txtEdicao.Text, out int edicao))
            {
                MessageBox.Show("Edição inválida.");
                return;
            }
            revista = new Revista(txtTitulo.Text, (Generos)int.Parse(txtGenero.Text), preco, txtEditora.Text, edicao);
        }
    }
}
