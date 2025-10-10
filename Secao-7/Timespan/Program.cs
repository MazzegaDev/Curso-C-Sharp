namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                TimeSpan
                ->Representa uma duração e seu tipo é valor (struct), ele representa uma duração de ticks (100 nanosegundos)

                Instanciação
                ->new TimeSpan(dia,hora, minuto, segundo, milesegundos);
                Todos os parametros sao opicionais

                TimeSpan padrão:
                ->new TimeSpan();

                Gerar TimeSpan pelo ticks:
                ->new TimeSpan(900000000L); = 00:01:30

                Metodo from
                ->O metodo from nos permite criar um TimeSpan apartir de um valor

                FromDays - Cria um TimeSpan apartir de um dia
                ->TimeSpan.FromDays(1.5);

                FromHours - Cria um TimeSpan apartir de uma hora
                ->TimeSpan.FromHours(1.5);

                FromMinutes - Cria um TimeSpan apartir de um minuto
                ->TimeSpan.FromMinutres(1.5);

                FromSeconds - Cria um TimeSpan apartir de um segundo
                ->TimeSpan.FromSeconds(1.5);

                FromMilliseconds - Cria um TimeSpan apartir de um milisegundo
                ->TimeSpan.FromMilliseconds(1.5);

                FromTicks - Cria um TimeSpan apartir de um tick
                ->TimeSpan.FromTicks(9000000L);
            */

            // TimeSpan t1 = new TimeSpan(0, 1, 30);
            // TimeSpan t2 = new TimeSpan(900000000L);


            // Console.WriteLine(t1);
            // Console.WriteLine(t2);


            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}