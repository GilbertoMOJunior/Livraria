using ControleDeBar.WinApp.Compartilhado.Extensions;
using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloRevista
{
    public partial class TabelaRevistaControl : UserControl
    {
        public TabelaRevistaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Revista> lista)
        {
            grid.Rows.Clear();

            foreach (Revista p in lista)
                grid.Rows.Add(p.Id, p.Titulo, p.Genero, p.Editora, p.Edicao, p.Preco);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();

        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Genero" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Editora", HeaderText = "Editora" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Edicao", HeaderText = "Edicao" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
        ];
    }
}
