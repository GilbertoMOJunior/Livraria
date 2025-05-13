using Livraria.Compartilhado;
using Livraria.ModuloExemplar;
using Livraria.ModuloPessoa;

namespace Livraria.Apresentacao
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }
        ControladorBase controlador;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;
        }
        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorPessoa());

        private void exemplaresToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorExemplar());

        private void btnAdicionar_Click(object sender, EventArgs e)
            => controlador.Adicionar();
        private void btnEditar_Click(object sender, EventArgs e)
            => controlador.Editar();
        private void btnExcluir_Click(object sender, EventArgs e)
            => controlador.Excluir();

        #region Auxiliares
        private void SelecionaModulo(ref ControladorBase controlador, Action controladorSelecionado)
        {
            controladorSelecionado();
            //lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolBox(controlador);
            ConfigurarListagem(controlador);
        }
        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            ConfigurarToolTips(controladorSelecionado);
        }
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            //btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            //btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            //btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            controladorSelecionado.Adicionar();
            //UserControl listagemEntidades = controladorSelecionado.ObterListagem();

            //listagemEntidades.Dock = DockStyle.Fill;
            //painelRegistros.Controls.Clear();
            //painelRegistros.Controls.Add(listagemEntidades);
        }
        #endregion

       

    }
}
