using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_07
    {
        public static void Exercicio()
        {
            int index = 1;
            int cout_qtde = 10;
            string nome;

            List<Pessoa> pessoas = new List<Pessoa>();

            while (true){
                
                Console.Write($"Insira o Nome ( {index} ): ");
                nome = Console.ReadLine().ToString();
                pessoas.Add(new Pessoa { Nome = nome });
                index+=1;
                cout_qtde -= 1;
                if (cout_qtde==0)
                {
                    break;
                }

            }

            index= 1;
            Console.Clear();
            Mensagens.MenuAtividade("Atividade 07", " Armazenar 10 nomes e imprimir uma listagem numerada.");
            Console.WriteLine("|===============< Print Lista >===============|");
            foreach (var pessoa in pessoas) {
                
                Console.WriteLine($"id:{index} Nome: {pessoa.Nome}");
                index+=1;
            }

            Console.WriteLine(">>>>> The End <<<<<");
            Console.ReadLine();

        }
    }
}
