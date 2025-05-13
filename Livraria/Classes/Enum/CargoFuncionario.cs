using System.ComponentModel;

public enum CargoFuncionario
{
    [Description("Gerente")]
    Gerente = 1,

    [Description("Atendente")]
    Atendente = 2,

    [Description("Caixa")]
    Caixa = 3,

    [Description("Estagiário")]
    Estagiario = 4
}
