using System;
using System.Security.Cryptography.X509Certificates;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var bruno = CriarCliente();
            ExibirTotalDeContas();
            var contaBruno = CriarContaCorrente(bruno);
            ExibirInformacoesDeConta(bruno, contaBruno);
            ExibirTotalDeContas();

            Console.WriteLine("\n");

        }

        private static ContaCorrente CriarContaCorrente(Cliente bruno)
        {
            return new ContaCorrente(5050, 789453, bruno);
        }

        private static void ExibirInformacoesDeConta(Cliente bruno, ContaCorrente contaBruno)
        {
            Console.WriteLine("Titular da conta: " + contaBruno.Titular.Nome);
            Console.WriteLine("O saldo da conta é: R$ " + contaBruno.Saldo);
            Console.WriteLine("O CPF do titular é: " + bruno.Cpf);
        }

        private static void ExibirTotalDeContas()
        {
            Console.WriteLine("Total de contas até o momento: " + ContaCorrente.TotalDeContasCriadas);
        }

        private static Cliente CriarCliente()
        {
            Cliente bruno = new Cliente();
            bruno.Nome = "Bruno Knop";
            bruno.Profissão = "Desenvolvedor";
            bruno.Cpf = "12345678000";
            return bruno;
        }
    }
}
