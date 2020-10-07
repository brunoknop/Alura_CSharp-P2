using System;

namespace CSharp_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaBruno = new ContaCorrente();
            ContaBruno.titular = "Bruno Knop";
            ContaBruno.agencia = 987;
            ContaBruno.numero = 654321;
            ContaBruno.saldo = 123456.78;

            ContaCorrente ContaToia = new ContaCorrente();
            ContaToia.titular = "Vitória Kayser Knop";
            ContaToia.agencia = 987;
            ContaToia.numero = 654321;
            ContaToia.saldo = 100;

            ContaBruno.Sacar(654);
            Console.WriteLine("");
            ContaBruno.Depositar(789);
            Console.WriteLine("");
            ContaBruno.Transferir(4567, ContaToia);

        }
    }
}
