using ClassLib.Classes.Enum;
using Livraria.Classes.ModuloPessoa;

namespace Trabalho_Forms;

public partial class TelaPessoa : Form
{
    public Leitor FormLeitor
    {
        get => leitor;
        set
        {
            txtNome.Text = value.Nome;
            txtEmail.Text = value.Email;
            txtCPF.Text = value.Cpf;
            txtTelefone.Text = value.Telefone;
            dateNascimento.Value = value.Nascimento;
        }
    }

    private Leitor leitor;

    public Funcionario FormFuncionario
    {
        get => funcionario;
        set
        {
            txtNome.Text = value.Nome;
            txtEmail.Text = value.Email;
            txtCPF.Text = value.Cpf;
            txtTelefone.Text = value.Telefone;
            dateNascimento.Value = value.Nascimento;
            salario.Value = value.Salario;
            cargaHoraria.Value = value.CargaHoraria;
            txtFuncao.Text = value.Funcao;
            cargoFuncionario.SelectedIndex = (int)value.Cargo;
        }
    }
    private Funcionario funcionario;

    public TelaPessoa()
    {
        InitializeComponent();

        // carrega os valores do Enum para o combobox/Listbox
        cargoFuncionario.DataSource = Enum.GetValues(typeof(CargoFuncionario));
        cargoFuncionario.SelectedIndex = 0;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (this.controlador.SelectedTab == Leitor)
            leitor = new Leitor(tipoLeitor.Text, txtNome.Text, dateNascimento.Value, txtCPF.Text, txtTelefone.Text, txtEmail.Text);

        if (this.controlador.SelectedTab == Funcionario)
        {
            funcionario = new Funcionario((CargoFuncionario)cargoFuncionario.SelectedIndex, salario.Value, (int)cargaHoraria.Value, txtFuncao.Text,
            txtNome.Text, dateNascimento.Value, txtCPF.Text, txtTelefone.Text, txtEmail.Text);
        }
    }
}
//Gilberto Mota de Oliveira Junior