using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list_pessoa = new List<Pessoa>();

            while (true)
            {
                Console.Write("Deseja cadastrar uma pessoa?");

                if (Console.ReadLine() == "sim")
                {

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());
                    Pessoa n1 = new Pessoa(nome, idade);
                    list_pessoa.Add(n1);
                }
                else
                {
                    break;
                }
            }


            if (list_pessoa.Count() != 0 )
            {
              int maior = 0;
              string maiorNome = null;
              foreach (Pessoa x in list_pessoa)
                {
                    if (x.Idade > maior)
                    {
                        maior = x.Idade;
                        maiorNome = x.PessoaNo;
                    }
                    Console.WriteLine("A pessoa com a maior idade é: ", maiorNome, "com, ", maior, " anos");
                    //Console.WriteLine(x.Idade);
                    //Console.WriteLine(x.PessoaNo);
                }
            // list_pessoa.ForEach(pessoa => Console.WriteLine(String.Format("{0} {1} {2} {3} {4} {5}", "Idade:", pessoa.Idade, "Nome:", pessoa.PessoaNo, "ID:", pessoa.Id)));
                
            }
            Console.ReadKey();


            //Console.ReadKey();
        }
    }
}
