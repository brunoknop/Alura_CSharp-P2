using System;

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente recebedor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.Sacar(valor);
            recebedor.Depositar(valor);
            return true;
        }
    }

    public void MostraSaque()
    {

    }
}