using Livraria.Classes.ModuloExemplar;
using Livraria.Compartilhado.Extensions;

namespace Livraria.ModuloExemplar
{
    public partial class TabelaExemplar : UserControl
    {
        public TabelaExemplar()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Exemplar> lista)
        {
            grid.Rows.Clear();

            foreach (Exemplar p in lista)
                grid.Rows.Add(p.Titulo, p.SubTitulo, p.Genero, p.Escritor, p.Editora, p.AnoPublicado, p.Status);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "SubTitulo", HeaderText = "SubTitulo" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Genero" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Escritor", HeaderText = "Escritor" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Editora", HeaderText = "Editora" },
            new DataGridViewTextBoxColumn { DataPropertyName = "AnoPublicado", HeaderText = "Ano Publicado" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status" }
        ];
    }
}
