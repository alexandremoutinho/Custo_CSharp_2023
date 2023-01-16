using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_09
    {   //Entrar com uma data no formato “DDMMAA” e imprimir dia, mês e ano separados
        public static void Exercicio() {

            Console.Write($"Informe a Data: ");
            string data = Console.ReadLine();
            
            DateTime get_data = DateTime.Parse(data);

            Console.WriteLine($"Dia {get_data.Day} Mês {get_data.Month} Ano {get_data.Year}");

            Console.ReadLine();
        
        }
    }
}
