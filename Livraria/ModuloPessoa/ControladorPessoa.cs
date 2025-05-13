using Livraria.Compartilhado;
using Trabalho_Forms;

namespace Livraria.ModuloPessoa
{
    public class ControladorPessoa : ControladorBase
    {
        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            TelaPessoa tela = new();
            DialogResult resultado = tela.ShowDialog();
        }

        public override void CarregarRegistros()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
