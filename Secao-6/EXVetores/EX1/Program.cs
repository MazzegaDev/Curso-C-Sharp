

namespace EXVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] quarto = new Estudante[10];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Email: ");
                string email = Console.ReadLine();
                Console.Write($"Quarto: ");
                int nQuarto = int.Parse(Console.ReadLine());
                quarto[nQuarto] = new Estudante(nome, email);
            }

            Console.WriteLine($"Quartos ocupados");
            for (int i = 0; i < quarto.Length; i++)
            {
                if (quarto[i] != null)
                {
                    Console.WriteLine($"{i}: {quarto[i].Nome}, {quarto[i].Email}");
                }
            }
        }
    }
}