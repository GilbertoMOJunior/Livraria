using Livraria.Classes.ModuloExemplar;
using Livraria.Interface;

namespace Livraria.Classes.ModuloPessoa;

public abstract class Pessoa : Dados
{
    public Pessoa(string nome, DateTime nascimento, string cpf, string telefone, string email)
    {
        Nome = nome;
        Nascimento = nascimento;
        Cpf = cpf;
        Telefone = telefone;
        Email = email;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public abstract void ListaLeitor(Leitor leitor);
    public abstract void EditaLeitor(Leitor leitor);
    public abstract void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor);
    public abstract void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor);
    public abstract void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor);
    public abstract void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor);

    public virtual string MostrarDados()
    {
        return $"Nome: {Nome}\nNascimento: {Nascimento:dd/MM/yyyy}\nCPF: {Cpf}\nEmail: {Email}\nTelefone: {Telefone}";
    }
}
//Gilberto Mota de Oliveira Junior