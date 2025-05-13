using ClassLib.Classes.Enum;
using Livraria.Classes.ModuloExemplar;
using Livraria.Extensions;

namespace Livraria.Classes.ModuloPessoa;

public class Funcionario : Pessoa
{
    public Funcionario(CargoFuncionario cargo, decimal salario, int cargaHoraria, string funcao, string nome, DateTime nascimento, string cpf, string telefone, string email) : base(nome, nascimento, cpf, telefone, email)
    {
        Cargo = cargo;
        Salario = salario;
        CargaHoraria = cargaHoraria;
        Funcao = funcao;
    }

    public CargoFuncionario Cargo { get; set; }
    public decimal Salario { get; set; }
    public int CargaHoraria { get; set; }
    public string Funcao { get; set; }

    public void NovoLeitor(Leitor leitor) => throw new NotImplementedException();
    public void ExcluiLeitor(Leitor leitor) => throw new NotImplementedException();
    public void NovoFuncionario(Funcionario funcionario) => throw new NotImplementedException();
    public void EditaFuncionario(Funcionario funcionario) => throw new NotImplementedException();
    public void ExcluiFuncionario(Funcionario funcionario) => throw new NotImplementedException();
    public void ListaFuncionario(Funcionario funcionario) => throw new NotImplementedException();
    public void NovoExemplar(Exemplar exemplar) => throw new NotImplementedException();
    public void EditaExemplar(Exemplar exemplar) => throw new NotImplementedException();
    public void ExcluiExemplar(Exemplar exemplar) => throw new NotImplementedException();
    public void ListaExemplar(Exemplar exemplar) => throw new NotImplementedException();

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
        return $"{dadosBase}\nCargo: {Cargo.GetDescription()}\nSalário: R$ {Salario:F2}\nCarga Horária: {CargaHoraria}h\nFunção: {Funcao}";
    }
}
//Gilberto Mota de Oliveira Junior
