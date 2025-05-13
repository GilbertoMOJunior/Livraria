using Livraria.Classes.ModuloExemplar;

namespace Livraria.Repositorios.Exemplar
{
    public class RepositorioGenerico
    {
        protected List<Generico> registros = [];

        protected int contadorId = 1;

        public void Cadastrar(Generico novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, Generico novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (Generico entidade in registros)
            {
                if (entidade == null)
                    continue;

                else if (entidade.Id == id)
                {
                    //entidade.AtualizarRegistro(novaEntidade);

                    return true;
                }
            }

            return false;
        }

        public bool Excluir(int id)
        {
            foreach (Generico entidade in registros)
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
        public Generico SelecionarPorId(int id)
        {
            foreach (Generico e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public List<Generico> SelecionarTodos()
        {
            return registros;
        }
    }
}
