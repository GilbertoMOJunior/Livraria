using Livraria.Apresentacao.Compartilhado;
using Livraria.Classes;
using Livraria.Repositorios.Exemplar;

namespace Livraria.Apresentacao.ModuloLivro
{
    public class ControladorLivro(RepositorioLivro repositorio) : ControladorBase
    {
        TabelaLivroControl tabela;

        public override string TipoCadastro => throw new NotImplementedException();

        public override string ToolTipAdicionar => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Adicionar()
        {
            LivroForm telaAdicionar = new();
            DialogResult resultado = telaAdicionar.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novoRegistro = telaAdicionar.Livro;

            repositorio.Cadastrar(novoRegistro);

            CarregarRegistros();
        }


        public override void Editar()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Livro registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            LivroForm tela = new()
            {
                Livro = registroSelecionado
            };

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Livro registroEditado = tela.Livro;

            repositorio.Editar(idSelecionado, registroEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Livro registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            repositorio.Excluir(idSelecionado);

            CarregarRegistros();
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new TabelaLivroControl();

            CarregarRegistros();

            return tabela;
        }
        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(repositorio.SelecionarTodos());

    }
}
