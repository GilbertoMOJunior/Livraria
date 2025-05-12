using Livraria.Classes;

namespace Livraria.Repositorios.Exemplar
{
    public class RepositorioRevista
    {
        protected List<Revista> registros = [];

        protected int contadorId = 1;

        public void Cadastrar(Revista novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, Revista novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (Revista entidade in registros)
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
            foreach (Revista entidade in registros)
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
        public Revista SelecionarPorId(int id)
        {
            foreach (Revista e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public List<Revista> SelecionarTodos()
        {
            return registros;
        }
    }
}
