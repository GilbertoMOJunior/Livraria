using Livraria.Classes;

namespace Livraria.Repositorios.Exemplar
{
    public class RepositorioLivro
    {
        protected List<Livro> registros = [];

        protected int contadorId = 1;

        public void Cadastrar(Livro novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, Livro novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (Livro entidade in registros)
            {
                if (entidade == null)
                    continue;

                else if (entidade.Id == id)
                {
                    entidade.AtualizarRegistro(novaEntidade);

                    return true;
                }
            }

            return false;
        }

        public bool Excluir(int id)
        {
            foreach (Livro entidade in registros)
            {
                if (entidade == null)
                    continue;

                else if (entidade.Id == id)
                {
                    registros.Remove(entidade);

                    return true;
                }
            }

            return false;
        }
        public Livro SelecionarPorId(int id)
        {
            foreach (Livro e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public List<Livro> SelecionarTodos()
        {
            return registros;
        }
    }
}
