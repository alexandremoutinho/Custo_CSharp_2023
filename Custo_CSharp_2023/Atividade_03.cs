namespace Custo_CSharp_2023
{   //3. Ler os nomes e os pesos de duas pessoas e imprimir os dados da pessoa mais gorda.
    internal class Atividade_03
    {
        public static void Exercicio()
        {
            
            List<Pessoa> pessoas = new List<Pessoa>();

            string nome;
            double peso;

            int cout_pessoas = 1;
            while (true)
            {                
                
                
                Console.Write($"Informe {cout_pessoas}ª Nome: ");
                nome = Console.ReadLine();
                
                Console.Write($"Informe o Peso do(a) {nome}: ");
                peso = double.Parse(Console.ReadLine());
                
                pessoas.Add(new Pessoa { Nome = nome, Peso = peso });
                Console.WriteLine($"|============================================================|");
                Console.WriteLine($"| Dados da {cout_pessoas}ª Pessoa: Nome: {nome} Peso: {peso} |");
                Console.WriteLine($"|============================================================|");
                cout_pessoas += 1;

                if (cout_pessoas>2) { break; }
            }
            nome = "";
            peso = 0.00;
            foreach(var ps in pessoas)
            {
                
                if (ps.Peso > peso) { peso= ps.Peso;  nome = ps.Nome; }
            }
            Console.WriteLine($"|======================================================|");
            Console.WriteLine($"| Pessoa com o Maior Peso é {nome} com o Peso {peso}Kg |");
            Console.WriteLine($"|======================================================| ");
            Console.ReadLine();
        }

         
    }
}
