using System;

namespace Tipos {
    class Program {
        static void Main(string[] args) {
            /*
                Numeros pequenos -> byte
                Numeros medios para grandes -> int
                Numeros muitos grandes -> long
            */
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'f';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Guilherme";
            object obj1 = "Guilherme";
            object obj2 = 4.5f;
            n1++;
            
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int ValorIntMinimo = int.MinValue;
            int ValorIntMaximo = int.MaxValue;

            sbyte ValorSbyteMinimo = sbyte.MaxValue;
            decimal ValorDecimalMaximo = decimal.MaxValue;

            Console.WriteLine(ValorIntMinimo);
            Console.WriteLine(ValorIntMaximo);
            Console.WriteLine(ValorSbyteMinimo);
            Console.WriteLine(ValorDecimalMaximo);
        }
    }
}