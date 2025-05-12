using Livraria.Apresentacao.Compartilhado;
using Livraria.Classes;
using Livraria.Repositorios.Exemplar;

namespace Livraria.Apresentacao.ModuloHQ
{
    public class ControladorHQ(RepositorioHQ repositorio) : ControladorBase
    {
        TabelaHQControl tabela;
        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            HQForm tela = new();
            DialogResult result = tela.ShowDialog();

            if (result != DialogResult.OK) return;

            var novoRegistro = tela.HQ;

            repositorio.Cadastrar(novoRegistro);

            CarregarRegistros();
        }


        public override void Editar()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            HQ registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            HQForm tela = new()
            {
                HQ = registroSelecionado
            };

            DialogResult result = tela.ShowDialog();

            if (result != DialogResult.OK) return;

            HQ registroEditado = tela.HQ;

            repositorio.Editar(idSelecionado, registroEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            HQ registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            repositorio.Excluir(idSelecionado);
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new TabelaHQControl();

            CarregarRegistros();

            return tabela;
        }

        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(repositorio.SelecionarTodos());
    }
}
