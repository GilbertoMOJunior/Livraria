using Livraria.Apresentacao.Compartilhado;
using Livraria.Classes;
using Livraria.Repositorios.Pessoa;

namespace Livraria.Apresentacao.ModuloFuncionario
{
    public class ControladorFuncionario(RepositorioFuncionario repositorio) : ControladorBase
    {
        TabelaFuncionariosControl tabela;

        public override string TipoCadastro { get => "Funcionario"; }

        public override string ToolTipAdicionar { get => "Cadastrar um funcionarios"; }

        public override string ToolTipEditar { get => "Editar um funcionarios"; }

        public override string ToolTipExcluir { get => "Excluir um funcionario"; }

        public override void Adicionar()
        {
            FuncionarioForm telaAdicionar = new();
            DialogResult resultado = telaAdicionar.ShowDialog();

            if (resultado != DialogResult.OK) return;

            var novoRegistro = telaAdicionar.Funcionario;

            repositorio.Cadastrar(novoRegistro);

            CarregarRegistros();
        }


        public override void Editar()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Funcionario registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            FuncionarioForm tela = new()
            {
                Funcionario = registroSelecionado
            };

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Funcionario registroEditado = tela.Funcionario;

            repositorio.Editar(registroSelecionado.Id, registroEditado);

            CarregarRegistros();
        }

        public override void Excluir()
        {
            int idSelecionado = tabela.ObterRegistroSelecionado();

            Funcionario registroSelecionado = repositorio.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            repositorio.Excluir(idSelecionado);

            CarregarRegistros();
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new TabelaFuncionariosControl();

            CarregarRegistros();

            return tabela;
        }
        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(repositorio.SelecionarTodos());

    }
}
