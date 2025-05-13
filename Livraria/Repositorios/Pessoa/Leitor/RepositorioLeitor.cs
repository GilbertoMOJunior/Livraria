using Livraria.Classes.ModuloPessoa;

namespace Livraria.Repositorios.Pessoa
{
    public class RepositorioLeitor
    {
        protected List<Leitor> registros = [];

        #region CRUD
        protected int contadorId = 1;

        public void Cadastrar(Leitor novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, Leitor novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (Leitor entidade in registros)
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
            foreach (Leitor entidade in registros)
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
        public Leitor SelecionarPorId(int id)
        {
            foreach (Leitor e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public List<Leitor> SelecionarTodos()
        {
            return registros;
        }
        #endregion
    }
}
