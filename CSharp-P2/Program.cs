using System;

namespace CSharp_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaBruno = new ContaCorrente();
            ContaBruno.titular = "Bruno Knop";
            ContaBruno.agencia = 7700;
            ContaBruno.numero = 000789;
            ContaBruno.saldo = 123456.78;

            Console.WriteLine("Titular: " + ContaBruno.titular);
            Console.WriteLine("Agência: " + ContaBruno.agencia);
            Console.WriteLine("Conta: " + ContaBruno.numero);
            Console.WriteLine("Saldo: R$ " + ContaBruno.saldo);
        }
    }
}
