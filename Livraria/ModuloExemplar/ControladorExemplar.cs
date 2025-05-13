using Livraria.Compartilhado;
using Trabalho_Forms;

namespace Livraria.ModuloExemplar
{
    public class ControladorExemplar : ControladorBase
    {
        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            TelaExemplar tela = new();
            DialogResult result = tela.ShowDialog();
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
