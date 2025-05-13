using System.ComponentModel;

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
