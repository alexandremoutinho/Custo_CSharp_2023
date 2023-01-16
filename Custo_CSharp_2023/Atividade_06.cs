using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_06
    {
        //Criar um algoritmo que leia um número que servirá para controlar quantos números pares serão impressos a partir de 2. 
        public static void Exercicio()
        {
            Console.Write("Informe o Número: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i <= value; i++)
            {
                if (i % 2 == 0)
                { if (i>=2)
                    Console.WriteLine($"É Mutiplo de 2 = {i}");
                }
            }
            Console.WriteLine(">>>>> The End <<<<<");
            Console.ReadLine();


        }

    }
}
