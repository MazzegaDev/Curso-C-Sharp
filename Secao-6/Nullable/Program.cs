namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ->Nullable
                E um recurso do C# que permite que dados do tipo valor (struct)
                possam receber o valor null
                -Uso comum:
                    >Campo de banco de dados que podem valer nullo
                    >Dados e parametros opcionais 
                
                ->Operador de coalescencia nula
                Esse operador e representado pelo ??, ele e usado para verificaçoes, exemplo.
                double? x = null;
                double y = x ?? 0.0;
                Queremos atribuir y com o valor de x, porem caso o x seja nullable queremos definir outro valor, entao usamos o operador de coalescencia nula para isso
                  >Se nao for nulo, y recebe o valor de x
                  >Se for nulo, y recebe o valor a direita do operador
            */

            double? x = null; //Permite a variavel receber um valor null
            double? y = 10.0;

            //Pega o valor se existir ou o valor padrao -> como e null -> 0
            Console.WriteLine(x.GetValueOrDefault());
            //Como o valor existe -> 10
            Console.WriteLine(y.GetValueOrDefault());
            //Exibte se dentro da variavel tem um valor, retorna um boolean
            Console.WriteLine(x.HasValue); // ->False, pois x nao tem valor 
            Console.WriteLine(y.HasValue); // ->True, pois y tem valor

            //Imprime o valor diretamente da variavel, se o valor for nullable ela lança uma exeçao.
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine($"Y is null");
            }

            double? w = null;
            double? z = 10;

            double a = w ?? 5; // se w for null, a recebe 5
            double b = z ?? 5; // se z for null, b recebe 5
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}