using Livraria.Classes.ModuloExemplar;
using Livraria.Classes.ModuloPessoa;
using Livraria.Compartilhado;
using Trabalho_Forms;

namespace Livraria.ModuloExemplar
{
    public class ControladorExemplar(List<Exemplar> exemplares) : ControladorBase
    {
        TabelaExemplar tabela;

        public override string TipoCadastro => "Cadastro de exemplar";

        public override string ToolTipAdicionar => "Adicionar exemplar";

        public override string ToolTipEditar => "Editar exemplar";

        public override string ToolTipExcluir => "Excluir exemplar";

        public override void Adicionar()
        {
            TelaExemplar tela = new();
            DialogResult result = tela.ShowDialog();

            if (tela.DialogResult != DialogResult.OK) return;

            if (tela.LivroForm != null)
            {
                Livro livro = tela.LivroForm;
                exemplares.Add(livro);
            }
            else if (tela.EbookForm != null)
            {
                Ebook ebook = tela.EbookForm;
                exemplares.Add(ebook);
            }
            else if (tela.RevistaForm != null)
            {
                Revista revista = tela.RevistaForm;
                exemplares.Add(revista);
            }
            else if (tela.HqForm != null)
            {
                HQ hq = tela.HqForm;
                exemplares.Add(hq);
            }
            else if (tela.GenericoForm != null)
            {
                Generico generico = tela.GenericoForm;
                exemplares.Add(generico);
            }

            CarregarRegistros();
        }

        public override void Editar()
        {
            var tituloSelecionado = tabela.ObterRegistroSelecionado();

            var exemplarSelecionado = exemplares.Find(x => x.Titulo == tituloSelecionado);

            if (exemplarSelecionado == null) return;

            exemplares.Remove(exemplarSelecionado);
            
            Adicionar();
        }

        public override void Excluir()
        {
            var tituloSelecionado = tabela.ObterRegistroSelecionado();

            var exemplarSelecionado = exemplares.Find(x => x.Titulo == tituloSelecionado);

            if (exemplarSelecionado == null) return;

            exemplares.Remove(exemplarSelecionado);

            CarregarRegistros();
        }

        public override UserControl ObterListagem()
        {
            tabela ??= new TabelaExemplar();

            CarregarRegistros();

            return tabela;
        }

        public override void CarregarRegistros()
            => tabela.AtualizarRegistros(exemplares);
    }
}