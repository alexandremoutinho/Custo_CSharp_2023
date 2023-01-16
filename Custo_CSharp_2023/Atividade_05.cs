using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_05
    {
        // 5 - Imprimir os números múltiplos de 5 no intervalo de 1 até 500
        public static void Exercicio() {


            for (int i = 0; i <=500; i++)
            {
                if (i%5==0)
                {
                    Console.WriteLine($"É Mutiplo de 5 = {i}");
                }
            }
            Console.WriteLine(">>>>> The End <<<<<");
            Console.ReadLine();
        
        
        }
    }
}
