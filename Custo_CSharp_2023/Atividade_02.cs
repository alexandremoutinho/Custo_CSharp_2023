namespace Custo_CSharp_2023
{
    internal class Atividade_02
    {
        //2. Entrar com um número e imprimir a seguinte saída: número, quadrado e raiz quadrada.

        public static void Exercicio() {

            Console.WriteLine('\n');
            Thread.Sleep(500);
            Console.Write("Entre com Numero: ");
            var value = Console.ReadLine();

            double numero = double.Parse(value);
            var quadrado = Math.Pow(numero, 2);
            var raiz = Math.Sqrt(numero);
            

            Console.WriteLine(
                $"Valor Recebido: {numero} \n" +
                $"Valor ao Quadrado: {quadrado}\n" +
                $"Valor Raiz: {raiz}");

            Mensagens.Mensagem_Pausa("Precione Enter Para Retornar ao Menu Principal!!");


        }
    }
}
