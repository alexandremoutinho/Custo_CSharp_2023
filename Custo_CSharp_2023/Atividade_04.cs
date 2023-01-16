using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Atividade_04
    {
        //4. O Índice de Massa Corporal (IMC) é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.

        public static void Exercicio()
        {
            string nome;
            double peso;
            double altura;

            try { 
            Console.Write("Informe o Nome: ");                
            nome = Console.ReadLine();
            Console.Write("Peso: ");                
            peso = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");                
            altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);

            Console.WriteLine($"{nome} Seu IMC é : {imc} ");

                if (imc <= 18.5)
                {
                    Mensagens.Mensagem_Pausa($"{nome} você esta Abaixo do Peso");
                }
                else if (imc >18.5 && imc <= 25)
                {
                    Mensagens.Mensagem_Pausa($"{nome} você esta com Peso Normal");
                }
                else if (imc > 25 && imc <= 30)
                {
                    Mensagens.Mensagem_Pausa($"{nome} você esta Acima do Peso");
                }
                else { Mensagens.Mensagem_Pausa($"{nome} você esta Obeso vc preciado perder {peso - 80}"); }


                Console.ReadLine();
            }
            catch (Exception ex)
            {   
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.Clear();
                Mensagens.MenuAtividade("Atividade 04", " O Índice de Massa Corporal (IMC) é um critério da \n Organização Mundial de Saúde para dar uma indicação\n sobre a condição de peso de uma pessoa adulta.");

                Atividade_04.Exercicio();
            }

                       
            

            
        }

    }
}
