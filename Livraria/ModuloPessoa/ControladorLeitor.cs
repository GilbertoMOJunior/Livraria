using Livraria.Classes.ModuloPessoa;
using Livraria.Compartilhado;
using Trabalho_Forms;

namespace Livraria.ModuloPessoa
{
    public class ControladorLeitor(List<Leitor> leitores) : ControladorBase
    {
        TabelaLeitor tabela;

        public override string TipoCadastro => "Cadastro de leitor";

        public override string ToolTipAdicionar => "Adicionar leitor";

        public override string ToolTipEditar => "Editar leitor";

        public override string ToolTipExcluir => "Excluir leitor";

        public override void Adicionar()
        {
            TelaPessoa tela = new();
            DialogResult resultado = tela.ShowDialog();

            if (tela.DialogResult != DialogResult.OK) return;

            if (tela.FormLeitor != null) {
                Leitor leitor = tela.FormLeitor;
                leitores.Add(leitor);
            }
            
            CarregarRegistros();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new();

            CarregarRegistros();

            return tabela;
        }

        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(leitores);
    }
}
