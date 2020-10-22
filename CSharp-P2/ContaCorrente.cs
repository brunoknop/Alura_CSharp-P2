using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente _titular;
        public int _agencia;
        public int _numero;
        public double _saldo = 250;

        public Cliente Titular { get; set; }
        public int Agência { get; set; }
        public int Numero { get; set; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente recebedor)
        {
            if (_saldo < valor)
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
    }
}