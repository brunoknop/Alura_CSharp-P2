using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente _titular;
        public double _saldo = 250;
        private int _agencia;
        private int _numero;

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _numero = value;
            }
        }
        public ContaCorrente(int agencia, int numero, Cliente titular)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public Cliente Titular { get; set; }
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