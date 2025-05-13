using Livraria.Classes.ModuloExemplar;
using Livraria.Classes.ModuloPessoa;
using Livraria.Interface;

namespace Livraria.Classes
{
    public class Emprestimo : Dados
    {
        public Leitor Origem { get; set; }
        public Leitor Destino { get; set; }
        public Exemplar Item { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Emprestimo(Leitor origem, Leitor destino, Exemplar item)
        {
            Origem = origem;
            Destino = destino;
            Item = item;
            DataEmprestimo = DateTime.Now;
        }

        public string MostrarDados()
        {
            return $"Item: {Item.Titulo}\nDe: {Origem.Nome}\nPara: {Destino.Nome}\nData Empréstimo: {DataEmprestimo:dd/MM/yyyy}\nData Devolução: {DataDevolucao:dd/MM/yyyy}";
        }
    }
}
//Gilberto Mota de Oliveira Junior