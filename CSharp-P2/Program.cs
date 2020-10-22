using System;
using System.Security.Cryptography.X509Certificates;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente bruno = new Cliente();
            bruno.Nome = "Bruno Knop";
            bruno.Profissão = "Desenvolvedor";
            bruno.Cpf = "12345678000";

            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.Titular = bruno;
            contaBruno.Numero = 5050;
            contaBruno.Saldo = 10;

            Console.WriteLine("Titular da conta: " + contaBruno.Titular.Nome);
            Console.WriteLine("O saldo da conta é: R$ " + contaBruno.Saldo);
            Console.Write("O CPF do titular é: " + bruno.Cpf);
            Console.WriteLine("\n");

        }
    }
}
