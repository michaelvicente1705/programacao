using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    public class Pessoa
    {
        private int _idade;

        public int Idade
        {

            get { return _idade; }

            //o set valida se o valor é nulo, caso ele for ou menor que zero ele atribue o valor 0
            set { 
                if (value >= 0)
                {
                    _idade = value;
                }
                else
                {
                    _idade = 0;
                }
               
            }
        }

        public string Nome { get; set; }
        public string Sexo { get; set; }

    }
}
