namespace DateTimeKindISO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                DateTimeKind:
                ->Tipo enumerado especial que define tres valores possiveis para a localidade da data:
                
                Seus tipos:
                >Local: Fuso horario do sistema. Exemplo: São Paulo = GMT-3
                >UTC: Fuso horario GMT
                >Unspecified

                Boa Pratica:
                ->Armazenar em formato UTC: Bancos de dados,JSON,XML
                ->Instanciar e mostrar em formato Local

                Conversão:
                UTC para local -> myDate.ToLocalTime();
                Local para UTC -> myDate.ToUniversalTime();

                Padrão ISO 8601
                Formato:
                -> yyyy-MM-ddTHH:mm:ssZ
                Z -> Indica que a hora esta em UTC
            */

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1 Kind: {d1.Kind}");
            Console.WriteLine($"d1 to local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to utc: {d1.ToUniversalTime()}");


            DateTime d4 = DateTime.Parse("2000-02-14 13:05:58");
            DateTime d5 = DateTime.Parse("2000-05-05T13:05:58Z");
        }
    }
}