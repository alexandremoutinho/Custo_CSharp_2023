using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custo_CSharp_2023
{
    internal class Mensagens
    {

        public static void Menssagem_Erro(string mensagem="",string local="")
        {
            Console.Clear();
            Console.WriteLine("#===========================================#");
            Console.WriteLine($"#<<{mensagem}>>#");
            Console.WriteLine("#===========================================#");
            Console.Write($">>>>{local}");
            Console.ReadLine();
        }

        public static void Mensagem_Pausa(string mensagem="")
        {
            
            Console.Write($"#<< {mensagem} >>#");
            Console.ReadLine();
            Console.Clear();
        }

        public static void MenuAtividade(string atividade = "",string mensagem = "") 
        {
            Console.WriteLine("#-----------------------------------------------------------------------#");
            Console.WriteLine($"#---------------------------< {atividade} >---------------------------#");
            Console.WriteLine("#-----------------------------------------------------------------------#");
            Console.WriteLine("Exercicio Proposto:");
            Console.WriteLine($"{mensagem}");
            Console.WriteLine("#-----------------------------------------------------------------------#");
        }
    }
}
