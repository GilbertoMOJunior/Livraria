using Livraria.Classes.ModuloExemplar;

namespace Livraria.Repositorios.Exemplar
{
    public class RepositorioHQ
    {
        protected List<HQ> registros = [];

        protected int contadorId = 1;

        public void Cadastrar(HQ novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, HQ novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (HQ entidade in registros)
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
            foreach (HQ entidade in registros)
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
        public HQ SelecionarPorId(int id)
        {
            foreach (HQ e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public List<HQ> SelecionarTodos()
        {
            return registros;
        }
    }
}
