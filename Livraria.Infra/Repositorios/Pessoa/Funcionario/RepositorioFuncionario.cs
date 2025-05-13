using Livraria.Classes.ModuloPessoa;

namespace Livraria.Repositorios.Pessoa
{
    public class RepositorioFuncionario
    {
        protected List<Funcionario> registros = [];

        protected int contadorId = 1;

        public void Cadastrar(Funcionario novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, Funcionario novaEntidade)
        {
            novaEntidade.Id = id;

            foreach (Funcionario entidade in registros)
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
            foreach (Funcionario entidade in registros)
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
        public Funcionario SelecionarPorId(int id)
        {
            foreach (Funcionario e in registros)
            {
                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public List<Funcionario> SelecionarTodos()
        {
            return registros;
        }
    }
}
