using Livraria.Classes.ModuloPessoa;
using Livraria.Compartilhado.Extensions;

namespace Livraria.ModuloPessoa
{
    public partial class TabelaFuncionario : UserControl
    {
        public TabelaFuncionario()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Funcionario> lista)
        {
            grid.Rows.Clear();
            foreach (Funcionario p in lista)
                grid.Rows.Add(p.Nome, p.Nascimento.ToShortDateString(), p.Cpf, p.Telefone, p.Email, p.Cargo.ToString(), p.Salario.ToString("C2"), p.CargaHoraria, p.Funcao);
        }

        //public int ObterRegistroSelecionado() => grid.SelecionarId();

        public DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nascimento", HeaderText = "Nascimento" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "CPF" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Salario", HeaderText = "Salário" },
            new DataGridViewTextBoxColumn { DataPropertyName = "CargaHoraria", HeaderText = "Carga Horaria" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Funcao", HeaderText = "Função" }
        ];
    }
}
