using ControleDeBar.WinApp.Compartilhado.Extensions;
using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloHQ
{
    public partial class TabelaHQControl : UserControl
    {
        public TabelaHQControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<HQ> lista)
        {
            grid.Rows.Clear();

            foreach (HQ p in lista)
                grid.Rows.Add(p.Id, p.Titulo, p.Genero, p.Autor, p.Edicao, p.Preco);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();

        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Genero" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Autor", HeaderText = "Autor" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Edicao", HeaderText = "Edicao" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
        ];
    }
}
