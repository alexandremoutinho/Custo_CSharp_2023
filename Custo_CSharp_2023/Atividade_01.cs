using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_01
    {
        // 1. Criar um algoritmo que imprima o produto entre dois números.

        public static void Exercicio()
        {
            

            Console.WriteLine('\n');
            Thread.Sleep(500);
            Console.Write("Entre com o Primeiro Numero: ");
            var numero_01 = Console.ReadLine();
            
            Console.WriteLine('\n');

            Console.Write("Entre com o Segundo Numero: ");
            var numero_02 = Console.ReadLine();

            Console.WriteLine($"Valor do Primeiro Nº: {numero_01} e Segundo Nº: {numero_02}");

            Mensagens.Mensagem_Pausa("Precione Enter Para Retornar ao Menu Principal!!");
        }
    }
}
