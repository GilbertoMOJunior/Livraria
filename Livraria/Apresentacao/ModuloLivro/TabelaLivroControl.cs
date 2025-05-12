using ControleDeBar.WinApp.Compartilhado.Extensions;
using Livraria.Classes;

namespace Livraria.Apresentacao.ModuloLivro
{
    public partial class TabelaLivroControl : UserControl
    {
        public TabelaLivroControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Livro> lista)
        {
            grid.Rows.Clear();

            foreach (Livro p in lista)
                grid.Rows.Add(p.Id, p.Titulo, p.Genero, p.Autor, p.Paginas, p.Preco);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();

        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Genero" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Autor", HeaderText = "Autor" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Paginas", HeaderText = "Numero de Paginas" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
        ];
    }
}
