using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treino_linq
{
    internal class Pessoa
    {
        public int Idade { get; set; } 
        public string Nome { get; set; }
        
        public Pessoa(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }

    }
}
