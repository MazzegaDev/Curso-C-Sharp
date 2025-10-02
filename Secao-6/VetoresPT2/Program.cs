using System.Globalization;

namespace VetoresPT2
{
    class Program
    {
        /*
            Vetores do tipo classe
            A maneira de criar um vetor classe e a mesma que do tipo valor, porem na hora de atribuir valores em sua posiçao e diferente, para atribuir valores dentro de um vetor classe precissamos instanciar a classe e passar os valroes dos atributos previamente atribuidos. EX
            Product[] vet = new Product[n];
            loop{
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vet[i] = new Product {Name = name, Price = price}
            }
        */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vetor = new Product[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Product { Name = name, Price = price };
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Price;
            }

            double avg = soma / n;
            Console.WriteLine($"AVAREGE PRICE {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}