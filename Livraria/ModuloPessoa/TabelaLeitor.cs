using Livraria.Classes.ModuloPessoa;
using Livraria.Compartilhado.Extensions;

namespace Livraria.ModuloPessoa
{
    public partial class TabelaLeitor : UserControl
    {
        public TabelaLeitor()
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
                grid.Rows.Add(p.Nome, p.Nascimento.ToShortDateString(), p.Cpf, p.Telefone, p.Email, p.Tipo);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();

        public DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nascimento", HeaderText = "Nascimento" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "CPF" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "Tipo" },
        ];
    }
}
