using Livraria.Apresentacao.Compartilhado;
using Livraria.Classes;
using Livraria.Repositorios.Exemplar;

namespace Livraria.Apresentacao.ModuloGenerico
{
    public class ControladorGenerico(RepositorioGenerico repositorio) : ControladorBase
    {
        TabelaGenericoControl tabelaGenerico;
        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            GenericoForm tela = new();
            DialogResult result = tela.ShowDialog();

            if (result != DialogResult.OK) return;

            var novoRegistro = tela.Generico;

            repositorio.Cadastrar(novoRegistro);

            CarregarRegistros();
        }

        public override void Editar()
        {
            int idSelecionado = tabelaGenerico.ObterRegistroSelecionado();

            Generico registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            GenericoForm telaGenerico = new()
            {
                Generico = registroSelecionado
            };
            DialogResult result = telaGenerico.ShowDialog();

            if (result != DialogResult.OK) return;

            Generico registroEditado = telaGenerico.Generico;

            repositorio.Editar(idSelecionado, registroEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaGenerico.ObterRegistroSelecionado();

            Generico registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            repositorio.Excluir(idSelecionado);

            CarregarRegistros();
        }

        public override UserControl ObterListagem()
        {
            tabelaGenerico ??= new TabelaGenericoControl();

            CarregarRegistros();

            return tabelaGenerico;
        }

        public override void CarregarRegistros()
            => tabelaGenerico.AtualizarRegistros(repositorio.SelecionarTodos());
    }
}
