using Livraria.Apresentacao.Compartilhado;
using Livraria.Classes;
using Livraria.Repositorios.Pessoa;

namespace Livraria.Apresentacao.ModuloLeitor
{
    public class ControladorLeitor(RepositorioLeitor repositorio) : ControladorBase
    {
        TabelaLeitorControl tabela;

        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            LeitorForm telaAdicionar = new();
            DialogResult resultado = telaAdicionar.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novoRegistro = telaAdicionar.Leitor;

            repositorio.Cadastrar(novoRegistro);

            CarregarRegistros();
        }


        public override void Editar()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Leitor registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            LeitorForm tela = new()
            {
                Leitor = registroSelecionado
            };

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Leitor registroEditado = tela.Leitor;

            repositorio.Editar(registroSelecionado.Id, registroEditado);

            CarregarRegistros();

            repositorio.Editar(idSelecionado, registroEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Leitor registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            repositorio.Excluir(idSelecionado);

            CarregarRegistros();
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new TabelaLeitorControl();

            CarregarRegistros();

            return tabela;
        }
        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(repositorio.SelecionarTodos());

    }
}
