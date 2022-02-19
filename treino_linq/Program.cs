using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treino_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listPessoas = new List<Pessoa>();
            string op = "sim";
            while (op == "sim")
            {
                Console.Write("Insira seu nome: ");
                string nomeInput = Console.ReadLine();

                Console.Write("Insira sua idade: ");
                int idadeInput = Convert.ToInt32(Console.ReadLine());

                Pessoa p = new Pessoa(idadeInput, nomeInput);

                listPessoas.Add(p);

                var nameQuery =
                from name in listPessoas
                where (name.Nome.Contains("Silva"))
                select name;

                Console.Write("Deseja cadastrar mais alguém ? ");
               op = Convert.ToString(Console.ReadLine());

                if (op != "sim")
                {
                    foreach (Pessoa num in nameQuery)
                    {
                        Console.Write("{0,1} ", num.Nome);
                    }
                }
                

            } ;


            // 3. Query execution.
           
            
            Console.ReadKey();

        }
    }
}
