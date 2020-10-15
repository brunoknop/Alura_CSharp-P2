using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente bruno = new Cliente();
            bruno.nome = "Bruno Knop";
            bruno.profissão = "Desenvolvedor";
            bruno.cpf = "123.456.789.00";

            Console.WriteLine("Acessando o nome pelo cliente: " + bruno.nome);

            ContaCorrente novaConta = new ContaCorrente();
            novaConta.titular = bruno;
            novaConta.numero = 5050;
            novaConta.saldo = 10000;

            Console.WriteLine("Acessando o nome pela conta: " + novaConta.titular.nome);

        }
    }
}
