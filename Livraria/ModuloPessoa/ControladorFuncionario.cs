using Livraria.Classes.ModuloPessoa;
using Livraria.Compartilhado;
using Trabalho_Forms;

namespace Livraria.ModuloPessoa
{
    public class ControladorFuncionario(List<Funcionario> funcionarios) : ControladorBase
    {
        TabelaFuncionario tabela;

        public override string TipoCadastro => "Cadastro de funcionario";

        public override string ToolTipAdicionar => "Adicionar funcionario";

        public override string ToolTipEditar => "Editar funcionario";

        public override string ToolTipExcluir => "Excluir funcionario";

        public override void Adicionar()
        {
            TelaPessoa tela = new();
            DialogResult resultado = tela.ShowDialog();

            if (tela.DialogResult != DialogResult.OK) return;

            if (tela.FormFuncionario != null)
            {
                Funcionario funcionario = tela.FormFuncionario;
                funcionarios.Add(funcionario);
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
            tabela ??= new TabelaFuncionario();

            CarregarRegistros();

            return tabela;
        }

        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(funcionarios);
    }
}
