namespace Livraria.Apresentacao.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string TipoCadastro { get; }

        #region ToolTips
        public abstract string ToolTipAdicionar { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }
        #endregion

        #region CRUD
        public abstract void Adicionar();
        public abstract void Editar();
        public abstract void Excluir();
        #endregion

        #region Auxiliares
        public abstract UserControl ObterListagem();
        public abstract void CarregarRegistros();

        protected bool SemSeleção(object entidadeSelecionada)
        {
            if (entidadeSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }
            return false;
        }
        protected bool SemDependenciasCadastradas(int contagemDependencias, string texto)
        {
            if (contagemDependencias == 0)
            {
                MessageBox.Show(
                    $"Não é possível realizar esta ação sem {texto} cadastradas",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }
            return false;
        }
        protected bool DesejaRealmenteExcluir(object entidadeSelecionada)
        {
            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{entidadeSelecionada}\"?",
                $"Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return false;
            return true;
        }
        #endregion
    }
}
