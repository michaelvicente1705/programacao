using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list_funconario = new List<Funcionario>();
            
            list_funconario.Add(new Funcionario() { Idade= 28, Nome = "Pedro", Sexo = "Masculino", Unidade = "Sao Paulo", Area = "Contabilidade", Salario = 2500});
            list_funconario.Add(new Funcionario() { Idade= 55, Nome = "Gabriel", Sexo = "Masculino", Unidade = "Sao Paulo", Area = "Producao", Salario = 2500});
            list_funconario.Add(new Funcionario() { Idade= 37, Nome = "Maria", Sexo = "Feminino", Unidade = "Sao Paulo", Area = "Atendimento", Salario = 2250});
            list_funconario.Add(new Funcionario() { Idade= 45, Nome = "Alice", Sexo = "Feminino", Unidade = "Sao Paulo", Area = "Recursos Humanos", Salario = 2300});
            list_funconario.Add(new Funcionario() { Idade= 41, Nome = "Mariana", Sexo = "Feminino", Unidade = "Sao Paulo", Area = "Recursos Humanos", Salario = 2150});

            int cont = 0;
            foreach (Funcionario x in list_funconario)
            {
                
                //list_pessoa.ForEach(pessoa => Console.WriteLine(String.Format("{0} {1} {2} {3} {4} {5}", "Idade:", pessoa.Idade, "Nome:", pessoa.PessoaNo, "ID:", pessoa.Id)));
                if (x.Unidade == "Santo andre")
                {
                    cont++;
                   
                }
            }
            Console.WriteLine(cont);
            cont = 0;
            
            var funcQuery =
                from funcionario in list_funconario
                where (funcionario.Unidade.Equals("Sao Paulo"))
                select funcionario;
            cont=funcQuery.Count();

            cont = 0;
            
            var ContFunc = list_funconario.Where(funcionario2 => funcionario2.Unidade.Equals("Santo Andre")).Count();


            Console.WriteLine(cont);

            Console.ReadKey();


        }
    }
}
