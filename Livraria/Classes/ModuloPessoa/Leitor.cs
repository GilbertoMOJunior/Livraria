using Livraria.Classes.ModuloExemplar;

namespace Livraria.Classes.ModuloPessoa;

public class Leitor : Pessoa
{
    public Leitor(string tipo, string nome, DateTime nascimento, string cpf, string telefone, string email) : base(nome, nascimento, cpf, telefone, email)
    {
        Exemplares = new();
        Emprestimos = new();
        Tipo = tipo;
    }

    public List<Exemplar> Exemplares { get; set; }
    public List<Emprestimo> Emprestimos { get; set; }
    public string Tipo { get; set; }

    public bool EmprestaItem(Exemplar exemplar, Leitor destino) => throw new NotImplementedException();
    public bool DevolucaoItem(Exemplar exemplar, Leitor destino) => throw new NotImplementedException();
    public bool DoaExemplar(Exemplar exemplar, Leitor destino) => throw new NotImplementedException();
    public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem) => throw new NotImplementedException();

    public override string ToString() => base.ToString();

    public override void ListaLeitor(Leitor leitor) => throw new NotImplementedException();
    public override void EditaLeitor(Leitor leitor) => throw new NotImplementedException();
    public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor) => throw new NotImplementedException();
    public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor) => throw new NotImplementedException();
    public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor) => throw new NotImplementedException();
    public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor) => throw new NotImplementedException();

    public override string MostrarDados()
    {
        string dadosBase = base.MostrarDados();
        string exemplares = string.Join(", ", Exemplares.Select(e => e.Titulo));
        string emprestimos = string.Join(", ", Emprestimos.Select(e => e.Item.Titulo));

        return $"{dadosBase}\nTipo: {Tipo}\nExemplares: {exemplares}\nEmpréstimos: {emprestimos}";
    }
}
