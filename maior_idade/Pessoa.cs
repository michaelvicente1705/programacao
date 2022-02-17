using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_idade
{
    internal class Pessoa
    {
        public int Id { get; set; } 
        public string PessoaNo { get; set; }
        public int Idade { get; set; } 

        static int Contador { get; set; }

        public Pessoa(string pessoa_nome, int idade)
        {
            Id= Contador+1;
            PessoaNo = pessoa_nome;
            Idade = idade;
            Contador++;
        }



    }
}
