using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_08
    {   //8. Para vários tributos a base cálculo é o salário mínimo. Fazer um algoritmo que leia o valor do salário mínimo e o valor do salário de uma pessoa. Calcular e imprimir quantos salários mínimos a pessoa ganha.
        public static void Exercicio()
        {
            float salario_minimo = 1302.00f;

            Console.Write("Informe o Seu Salário: ");
            float valor_do_salario = float.Parse(Console.ReadLine());
            int qtde_salario = (int)(valor_do_salario/salario_minimo);

            Console.Write($"Com base no Salário Mínimo atual: R$ {salario_minimo.ToString("F2")}\nO seu Salario corresponde a {qtde_salario} Salários Mínimos");
            

            Console.ReadLine();

        }
    }
}
