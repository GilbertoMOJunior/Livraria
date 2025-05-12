using Livraria.Apresentacao.Compartilhado;
using Livraria.Apresentacao.ModuloFuncionario;
using Livraria.Apresentacao.ModuloGenerico;
using Livraria.Apresentacao.ModuloHQ;
using Livraria.Apresentacao.ModuloLeitor;
using Livraria.Apresentacao.ModuloLivro;
using Livraria.Apresentacao.ModuloRevista;
using Livraria.Repositorios.Exemplar;
using Livraria.Repositorios.Pessoa;

namespace Livraria.Apresentacao
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }
        ControladorBase controlador;

        private readonly RepositorioFuncionario repositorioFuncionario;
        private readonly RepositorioLeitor repositorioLeitor;
        private readonly RepositorioHQ repositorioHQ;
        private readonly RepositorioLivro repositorioLivro;
        private readonly RepositorioRevista repositorioRevista;
        private readonly RepositorioGenerico repositorioGenerico;


        public TelaPrincipalForm()
        {
            InitializeComponent();

            repositorioFuncionario = new RepositorioFuncionario();
            repositorioLeitor = new RepositorioLeitor();
            repositorioHQ = new RepositorioHQ();
            repositorioLivro = new RepositorioLivro();
            repositorioRevista = new RepositorioRevista();
            repositorioGenerico = new RepositorioGenerico();

            Instancia = this;
        }

        private void funcioanriosToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorFuncionario(repositorioFuncionario));
        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorLeitor(repositorioLeitor));

        private void hQToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorHQ(repositorioHQ));
        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorLivro(repositorioLivro));
        private void revistaToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorRevista(repositorioRevista));
        private void genericoToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorGenerico(repositorioGenerico));

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
            //btnAdicionar.Enabled = true;
            //btnEditar.Enabled = true;
            //btnExcluir.Enabled = true;

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
            UserControl listagemEntidades = controladorSelecionado.ObterListagem();

            listagemEntidades.Dock = DockStyle.Fill;
            painelRegistros.Controls.Clear();
            painelRegistros.Controls.Add(listagemEntidades);
        }
        #endregion
    }
}
