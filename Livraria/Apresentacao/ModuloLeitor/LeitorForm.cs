using Livraria.Classes;
using Livraria.Classes.Enum;

namespace Livraria.Apresentacao.ModuloLeitor
{
    public partial class LeitorForm : Form
    {
        public Leitor Leitor
        {
            get => leitor;
            set
            {
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
                txtEmail.Text = value.Email;
                txtGeneroFav.Text = value.GeneroPreferido.ToString();
                txtMatricula.Text = value.Matricula.ToString();
            }
        }
        public Leitor leitor;
        public LeitorForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            leitor = new Leitor(txtNome.Text, txtTelefone.Text, txtEmail.Text, int.Parse(txtMatricula.Text), (Generos)int.Parse(txtGeneroFav.Text));
        }
    }
}
