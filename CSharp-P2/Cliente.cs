using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string Profissão { get; set; }

        public string Cpf
        {
            get
            {
                char[] novoCpf = new char[14];

                int countNovoCpf = 0;

                for (int count = 0; count < _cpf.Length; count++)
                {
                    if (count == 3)
                    {
                        novoCpf[countNovoCpf] = '.';
                        countNovoCpf++;
                        novoCpf[countNovoCpf] = _cpf[count];
                    }
                    if (count == 6)
                    {
                        novoCpf[countNovoCpf] = '.';
                        countNovoCpf++;
                        novoCpf[countNovoCpf] = _cpf[count];
                    }
                    if (count == 9)
                    {
                        novoCpf[countNovoCpf] = '-';
                        countNovoCpf++;
                        novoCpf[countNovoCpf] = _cpf[count];
                    }
                    novoCpf[countNovoCpf] = _cpf[count];
                    countNovoCpf++;
                }
                string mostraCpf = new string(novoCpf);
                return mostraCpf;
            }
           
            set
            {
                if (value.Length != 11)
                {
                    return;
                }
                _cpf = value;
            }
        }
    }
}
