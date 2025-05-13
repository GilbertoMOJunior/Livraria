using System.ComponentModel;

namespace ClassLib.Classes.Enum;

public enum StatusExemplar
{
    [Description("Pendente")]
    Pendente = 1,

    [Description("Lido")]
    Lido = 2,

    [Description("Emprestado")]
    Emprestado = 3,

    [Description("Devolvido")]
    Devolvido = 4,

    [Description("Perdido")]
    Perdido = 5
}
//Gilberto Mota de Oliveira Junior