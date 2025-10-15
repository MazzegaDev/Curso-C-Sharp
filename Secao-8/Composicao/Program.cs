using System.Globalization;
using Composicao.Entities;
using Composicao.Entities.Enums;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Composição
                ->É um tipo de associação que permite que um objeto contenha outro

                Relação:
                tem-um ou tem-varios

                Vantagens
                ->Organização = Divisão de responsabilidades
                ->Coesao
                ->Flexibilidade
                ->Reuso
            */
            Console.Write($"Enter department's name: ");
            string depName = Console.ReadLine();

            Console.WriteLine($"Enter worker data: ");

            Console.Write($"Name: ");
            string name = Console.ReadLine();

            Console.Write($"Level - Junior/MidLevel/Senior");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            
            Console.Write($"Base salary");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(depName);
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write($"How many contracts? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write($"Value per hour");
                double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, perHour, hours);
                worker.AddContract(contract);
            }


            Console.WriteLine($"");
            Console.Write($"Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Departament.Name}");

            Console.WriteLine($"Income for {month}:{year} {worker.Income(year, month)}");

        }
    }
}