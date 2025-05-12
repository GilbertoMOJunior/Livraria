using ControleDeBar.WinApp.Compartilhado.Extensions;
using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloGenerico
{
    public partial class TabelaGenericoControl : UserControl
    {
        public TabelaGenericoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Generico> lista)
        {
            grid.Rows.Clear();

            foreach (Generico p in lista)
                grid.Rows.Add(p.Id, p.Titulo, p.Autor, p.Genero, p.Idioma, p.Preco);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();

        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Autor", HeaderText = "Autor" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Genero" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Idioma", HeaderText = "Idioma" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
        ];
    }
}
