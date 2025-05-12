using ControleDeBar.WinApp.Compartilhado.Extensions;
using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloFuncionario
{
    public partial class TabelaFuncionariosControl : UserControl
    {
        public TabelaFuncionariosControl()
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
                grid.Rows.Add(p.Id, p.Nome, p.Telefone, p.Email, p.Cargo, p.Matricula);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Matricula", HeaderText = "Matricula" }
        ];
    }
}
