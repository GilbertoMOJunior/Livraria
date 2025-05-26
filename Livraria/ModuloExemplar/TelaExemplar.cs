using ClassLib.Classes.Enum;
using Livraria.Classes.ModuloExemplar;

namespace Trabalho_Forms
{
    public partial class TelaExemplar : Form
    {
        
        public Livro LivroForm { get => livro; set { } }
        public Ebook EbookForm { get => ebook; set { } }
        public Revista RevistaForm { get => revista; set { } }
        public HQ HqForm { get => hq; set { } }
        public Generico GenericoForm { get => generico; set { } }

        private Livro livro;
        private Ebook ebook;
        private Revista revista;
        private HQ hq;
        private Generico generico;
        public TelaExemplar()
        {
            InitializeComponent();
            // carrega os valores do Enum para o combobox/Listbox
            statusExemplar.DataSource = Enum.GetValues(typeof(StatusExemplar));
            statusExemplar.SelectedIndex = 0;

            generoExemplar.DataSource = Enum.GetValues(typeof(Genero));
            generoExemplar.SelectedIndex = 0;
            
            livroTipoCapa.DataSource = Enum.GetValues(typeof(TipoCapa));
            livroTipoCapa.SelectedIndex = 0;
            
            ebookFormato.DataSource = Enum.GetValues(typeof(FormatoEbook));
            ebookFormato.SelectedIndex = 0;

            genericoTipo.DataSource = Enum.GetValues(typeof(TipoGenerico));
            genericoTipo.SelectedIndex = 0;
        }

        private void TelaExemplar_Load(object sender, EventArgs e)
        {
            painalEbook.Enabled = checkEBook.Checked;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (this.controlador.SelectedTab)
            {
                case var tab when tab == Livro:
                    if (painalEbook.Enabled)
                    {
                        ebook = new Ebook((FormatoEbook)ebookFormato.SelectedIndex, (double)ebookTamanho.Value, ebookUrl.Text,
                            (int)livroPaginas.Value, (TipoCapa)livroTipoCapa.SelectedIndex, livroISBN.Text,
                            txtTitulo.Text, txtSubTitulo.Text, txtEscritor.Text, txtEditora.Text, (int)anoPublicacao.Value, (Genero)generoExemplar.SelectedIndex, (StatusExemplar)statusExemplar.SelectedIndex);
                        break;
                    }
                    livro = new Livro((int)livroPaginas.Value, (TipoCapa)livroTipoCapa.SelectedIndex, livroISBN.Text, 
                        txtTitulo.Text, txtSubTitulo.Text, txtEscritor.Text, txtEditora.Text, (int)anoPublicacao.Value, (Genero)generoExemplar.SelectedIndex, (StatusExemplar)statusExemplar.SelectedIndex);
                    break;

                case var tab when tab == Revista:
                    revista = new Revista((int)revistaEdicao.Value, (int)revistaPaginas.Value,
                        txtTitulo.Text, txtSubTitulo.Text, txtEscritor.Text, txtEditora.Text, (int)anoPublicacao.Value, (Genero)generoExemplar.SelectedIndex, (StatusExemplar)statusExemplar.SelectedIndex);
                    break;

                case var tab when tab == HQ:
                    hq = new HQ((int)hqEdicao.Value, hqIlustrador.Text,
                        txtTitulo.Text, txtSubTitulo.Text, txtEscritor.Text, txtEditora.Text, (int)anoPublicacao.Value, (Genero)generoExemplar.SelectedIndex, (StatusExemplar)statusExemplar.SelectedIndex);
                    break;

                case var tab when tab == Generico:
                    generico = new Generico((TipoGenerico)genericoTipo.SelectedIndex,
                        txtTitulo.Text, txtSubTitulo.Text, txtEscritor.Text, txtEditora.Text, (int)anoPublicacao.Value, (Genero)generoExemplar.SelectedIndex, (StatusExemplar)statusExemplar.SelectedIndex);
                    break;

            }
        }
    }
}
//Gilberto Mota de Oliveira Junior