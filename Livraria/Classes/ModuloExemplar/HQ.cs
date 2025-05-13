namespace Livraria.Classes.ModuloExemplar;

public class HQ : Exemplar
{
    public int Edicao { get; set; }
    public string Ilustrador { get; set; }

    public HQ(int edicao, string ilustrador, string titulo, string subTitulo, string escritor, string editora, int anoPublicado, string genero, int status) : base(titulo, subTitulo, escritor, editora, anoPublicado, genero, status)
    {
        Edicao = edicao;
        Ilustrador = ilustrador;
    }
    public override string ToString() => base.ToString();

    public override string MostrarDados()
    {
        return base.MostrarDados() + $"\nEdição: {Edicao}\nIlustrador: {Ilustrador}";
    }

}
