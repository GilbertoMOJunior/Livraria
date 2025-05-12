using Livraria.Apresentacao.Compartilhado;
using Livraria.Classes;
using Livraria.Repositorios.Exemplar;

namespace Livraria.Apresentacao.ModuloRevista
{
    public class ControladorRevista(RepositorioRevista repositorio) : ControladorBase
    {
        TabelaRevistaControl tabela;

        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            RevistaForm telaAdicionar = new();
            DialogResult resultado = telaAdicionar.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novoRegistro = telaAdicionar.Revista;

            repositorio.Cadastrar(novoRegistro);

            CarregarRegistros();
        }


        public override void Editar()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Revista registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            RevistaForm tela = new()
            {
                Revista = registroSelecionado
            };

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Revista registroEditado = tela.Revista;

            repositorio.Editar(registroSelecionado.Id, registroEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Revista registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            repositorio.Excluir(idSelecionado);

            CarregarRegistros();
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new TabelaRevistaControl();

            CarregarRegistros();

            return tabela;
        }

        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(repositorio.SelecionarTodos());
    }
}
