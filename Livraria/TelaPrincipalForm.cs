using ClassLib.Classes.Enum;
using Livraria.Classes.ModuloExemplar;
using Livraria.Classes.ModuloPessoa;
using Livraria.Compartilhado;
using Livraria.ModuloExemplar;
using Livraria.ModuloPessoa;

namespace Livraria.Apresentacao
{
    public partial class TelaPrincipalForm : Form
    {
        public List<Funcionario> funcionarios;
        public List<Leitor> leitores;
        public List<Exemplar> exemplares;

        public static TelaPrincipalForm Instancia { get; private set; }
        ControladorBase controlador;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();
            leitores = new List<Leitor>();
            exemplares = new List<Exemplar>();

            Instancia = this;
            CargaInicial(); 
        }

        private void exemplaresToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorExemplar(exemplares));

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorFuncionario(funcionarios));

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorLeitor(leitores));

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
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemEntidades = controladorSelecionado.ObterListagem();

            listagemEntidades.Dock = DockStyle.Fill;
            painelRegistros.Controls.Clear();
            painelRegistros.Controls.Add(listagemEntidades);
        }
        #endregion

        private void CargaInicial()
        {
            // Funcionários
            for (int i = 1; i <= 5; i++)
            {
                funcionarios.Add(new Funcionario(
                    cargo: (CargoFuncionario)i,
                    salario: 3000 + i * 100,
                    cargaHoraria: 40,
                    funcao: $"Função {i}",
                    nome: $"Funcionario {i}",
                    cpf: $"000.000.000-0{i}",
                    email: $"funcionario{i}@livraria.com",
                    nascimento: new DateTime(1990, 1, i),
                    telefone: $"(00) 0000-000{i}"
                ));
                // Leitores
                leitores.Add(new Leitor(

                    tipo: $"Tipo {i}",
                    nome: $"Leitor {i}",
                    nascimento: new DateTime(2000, 5, i),
                    cpf: $"111.111.111-0{i}",
                    telefone: $"(11) 1111-111{i}",
                    email: $"leitor{i}@exemplo.com"
                ));
                // Livros
                exemplares.Add(new Livro(
                    paginas: 100 + i,
                    tipoCapa: (TipoCapa)i,
                    isbn: $"978-3-16-14841{i}",
                    titulo: $"Livro {i}",
                    subTitulo: $"Subtítulo {i}",
                    escritor: $"Escritor {i}",
                    editora: $"Editora {i}",
                    anoPublicado: 2010 + i,
                    genero: (Genero)i,
                    status: (StatusExemplar)i
                ));
                // Revistas
                exemplares.Add(new Revista(
                    edicao: i,
                    paginas: 30 + i * 5,
                    titulo: $"Revista {i}",
                    subTitulo: $"Edição Especial {i}",
                    escritor: $"Redator {i}",
                    editora: $"Editora R{i}",
                    anoPublicado: 2020 + i,
                    genero: (Genero)i,
                    status: (StatusExemplar)i
                ));
               // HQs
                exemplares.Add(new HQ(
                    edicao: i,
                    ilustrador: $"Ilustrador {i}",
                    titulo: $"HQ {i}",
                    subTitulo: $"Volume {i}",
                    escritor: $"Autor HQ {i}",
                    editora: $"Editora HQ {i}",
                    anoPublicado: 2005 + i,
                    genero: (Genero)i,
                    status: (StatusExemplar)i
                ));
                // Ebooks
                exemplares.Add(new Ebook(
                    formato: (FormatoEbook)i,
                    tamanho: 1.5 + i,
                    url: $"http://ebooks.com/livro{i}",
                    paginas: 80 + i * 10,
                    tipoCapa: (TipoCapa)i,
                    isbn: $"978-3-16-14841{i + 5}",
                    titulo: $"Ebook {i}",
                    subTitulo: $"Digital Edition {i}",
                    escritor: $"Autor Digital {i}",
                    editora: $"Editora E{i}",
                    anoPublicado: 2015 + i,
                    genero: (Genero)i,
                    status: (StatusExemplar)i
                ));
                // Genéricos
                exemplares.Add(new Generico(
                    tipo: (TipoGenerico)i,
                    titulo: $"Genérico {i}",
                    subTitulo: $"Sub {i}",
                    escritor: $"Autor Genérico {i}",
                    editora: $"Editora G{i}",
                    anoPublicado: 2000 + i,
                    genero: (Genero)i,
                    status: (StatusExemplar)i
                ));
            }
        }
    }
}
