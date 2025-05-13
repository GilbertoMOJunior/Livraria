using System.ComponentModel;

namespace ClassLib.Classes.Enum;

public enum FormatoEbook
{
    [Description("PDF")]
    PDF = 1,

    [Description("ePUB")]
    EPUB = 2,

    [Description("MOBI")]
    MOBI = 3,

    [Description("KPF")]
    KPF = 4,

    [Description("Outros")]
    Outros = 5
}
//Gilberto Mota de Oliveira Junior