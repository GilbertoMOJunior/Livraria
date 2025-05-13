using System.ComponentModel;

public enum TipoCapa
{
    [Description("Capa Dura")]
    CapaDura = 1,

    [Description("Capa Flexível ou Brochura")]
    CapaFlexivelOuBrochura = 2,

    [Description("Capa de Papel Cartão")]
    CapaPapelCartao = 3,

    [Description("Capa com Sobrecapa (Jacket)")]
    CapaComSobrecapa = 4,

    [Description("Capa com Relevo")]
    CapaComRelevo = 5,

    [Description("Capa com Verniz UV")]
    CapaComVernizUV = 6,

    [Description("Capa Metalizada")]
    CapaMetalizada = 7,

    [Description("Capa de Tecido")]
    CapaDeTecido = 8,

    [Description("Capa com Janela")]
    CapaComJanela = 9,

    [Description("Capa Transparente")]
    CapaTransparente = 10,

    [Description("Capa Digital")]
    CapaDigital = 11
}
//Gilberto Mota de Oliveira Junior