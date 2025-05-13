using Livraria.Classes.ModuloExemplar;
using Livraria.Classes.ModuloPessoa;

namespace Livraria.Apresentacao
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Leitor> leitores = new();
            List<Funcionario> funcionarios = new();
            List<Exemplar> exemplares = new();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipalForm());
        }
    }
}