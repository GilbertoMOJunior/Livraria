using ControleDeBar.WinApp.Compartilhado.Extensions;
using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloLeitor
{
    public partial class TabelaLeitorControl : UserControl
    {
        public TabelaLeitorControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Leitor> lista)
        {
            grid.Rows.Clear();

            foreach (Leitor p in lista)
                grid.Rows.Add(p.Id, p.Nome, p.Email, p.Telefone, p.GeneroPreferido, p.Matricula);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();

        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
            new DataGridViewTextBoxColumn { DataPropertyName = "GeneroPreferido", HeaderText = "Genero Preferido" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Matricula", HeaderText = "Matricula" }
        ];
    }
}
