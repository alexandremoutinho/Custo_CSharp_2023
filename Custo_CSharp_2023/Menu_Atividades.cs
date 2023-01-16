using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Menu_Atividades
    {
        public static void Menu()
        {
            var op = "";
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("#=============================================================================#");
                Console.WriteLine("#============< BEM-VIDO AO SISTEMA DE ATIVIDADE DO CURSO C# >=================#");
                Console.WriteLine("#=============================================================================#");
                Console.WriteLine("\n");
                Console.WriteLine("#---------------------------< Menu de Atividades >---------------------------#");
                Console.WriteLine("# 01 >> Atividade = Exercicio 01                                             #");
                Console.WriteLine("# 02 >> Atividade = Exercicio 02                                             #");
                Console.WriteLine("# 03 >> Atividade = Exercicio 03                                             #");
                Console.WriteLine("# 04 >> Atividade = Exercicio 04                                             #");
                Console.WriteLine("# 05 >> Atividade = Exercicio 05                                             #");
                Console.WriteLine("# 06 >> Atividade = Exercicio 06                                             #");
                Console.WriteLine("# 07 >> Atividade = Exercicio 07                                             #");
                Console.WriteLine("# 00 >> Sair                                                                 #");
                Console.WriteLine("#=============================================================================#");
                Console.Write(">>> Escolha a Atividades desejada: ");
                op= Console.ReadLine();

                if (op!=null)
                {
                    if (op != "00") { 
                    Console.Clear();
                    Start_Menu(op.ToString());
                    }
                    else
                    {
                        Console.WriteLine("<<<<<<<<<< Sistema de Atividades Finalizado com Sucesso !!! >>>>>>>>>>");
                        Console.ReadLine();
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Informe um valor Valido!!");
                    Console.ReadLine();
                    break;
                }



            }
        }
        public static void Start_Menu(string op)
        {

          if(op=="01"){
                Mensagens.MenuAtividade("Atividade 01", "Criar um algoritmo que imprima o produto entre dois números.");
                Atividade_01.Exercicio();
            
           }
            else if (op=="02")
            {
                Mensagens.MenuAtividade("Atividade 02", " Entrar com um número e imprimir a seguinte saída: \n número, quadrado e raiz quadrada.");
                Atividade_02.Exercicio();
            }
            
            else if (op == "03") {
                Mensagens.MenuAtividade("Atividade 03", " Ler os nomes e os pesos de duas pessoas e imprimir\n os dados da pessoa mais gorda.");
                Atividade_03.Exercicio();
            }

            else if (op == "04")
            {
                Mensagens.MenuAtividade("Atividade 04", " O Índice de Massa Corporal (IMC) é um critério da \n Organização Mundial de Saúde para dar uma indicação\n sobre a condição de peso de uma pessoa adulta.");
                Atividade_04.Exercicio();
            }
            else if (op == "05")
            {
                Mensagens.MenuAtividade("Atividade 05", " Imprimir os números múltiplos de 5 no intervalo de 1 até 500.");
                Atividade_05.Exercicio();
            }
            else if (op == "06")
            {
                Mensagens.MenuAtividade("Atividade 06", " Criar um algoritmo que leia um número que servirá para controlar\n quantos números pares serão impressos a partir de 2.");
                Atividade_06.Exercicio();
            }

            else if (op == "07")
            {
                Mensagens.MenuAtividade("Atividade 07", " Armazenar 10 nomes e imprimir uma listagem numerada.");
                Atividade_07.Exercicio();
            }

            else { 
                Mensagens.Menssagem_Erro(" Opção Invalida", "Precione Enter Para Retornar ao Menu Principal!!");
          }
        }


    }
}
