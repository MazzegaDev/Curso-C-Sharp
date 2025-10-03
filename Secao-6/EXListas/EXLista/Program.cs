using System.Collections.Generic;
using System.Globalization;

namespace EXListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");

                Console.Write($"ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
            }

            Console.Write($"Enter the employee id that will have salary increase: ");
            int increaseId = int.Parse(Console.ReadLine());
            Employee result = list.Find(x => x.ID == increaseId);
            if (result != null)
            {
                Console.WriteLine($"Inform the percentage");
                double percent = double.Parse(Console.ReadLine());
                result.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine($"This id does not exist");
            }

            Console.WriteLine($"Update list of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine($"{obj.ID}, {obj.Name}, {obj.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}