using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloFuncionario
{
    public partial class FuncionarioForm : Form
    {
        public Funcionario Funcionario
        {
            get => funcionario;
            set
            {
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
                txtEmail.Text = value.Email;
                txtCargo.Text = value.Cargo;
                txtMatricula.Text = value.Matricula.ToString();
            }
        }
        public Funcionario funcionario;

        public FuncionarioForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario(txtNome.Text, txtTelefone.Text, txtEmail.Text, txtCargo.Text, int.Parse(txtMatricula.Text));
        }
    }
}
