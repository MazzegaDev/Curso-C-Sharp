
using System.Globalization;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                DateTime
                ->Representa um instante seu valor é do tipo valor (struct)
                ->Para guardar data em uma variavel ela precisa ser do tipo DateTime
                ->Um objeto DateTime internamento armazena o numero de ticks (100 nano segundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum

                Operações
                ->Pegar a data atual do sistema: 
                DateTime.Now

                ->Criar uma data: 
                new DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo)

                ->Data atual com horario zerado:
                DateTime.Today

                ->Pegar o horario universal:
                DateTime.UtcNow

                Formatações
                ->Texto para DateTime: 
                DateTime.Parse("2009-05-05 13:05:58")
                
                ->Especificar um formato para DateTime: 
                DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            */

            // DateTime d1 = DateTime.Now;
            // Console.WriteLine(d1);
            // Console.WriteLine($"ticks: {d1.Ticks}");
            // DateTime d1 = new DateTime(2025, 11, 25);
            // Console.WriteLine(d1);
            // Console.WriteLine($"-------");
            // DateTime d2 = new DateTime(2025, 11, 25, 20, 45, 3);
            // Console.WriteLine(d2);
            // Console.WriteLine($"--------");
            // DateTime d5 = DateTime.Today;
            // Console.WriteLine(d5);

            // DateTime d6 = DateTime.UtcNow;
            // Console.WriteLine(d6);
            // DateTime d1 = DateTime.Parse("2000-08-15");
            // DateTime d2 = DateTime.Parse("2009-05-05 13:05:58");
            // DateTime d3 = DateTime.Parse("05/05/2020");

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d2);
        }
    }
}