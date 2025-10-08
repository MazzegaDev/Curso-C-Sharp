namespace InferenciaVAR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Inferencia var
                ->Var
                Ela serve para inferir automaticamente o tipo da variavel conforme o valor atribuido a ela:
                var x = 10 <- x é um int
            */

            var x = 10;
            var y = 20.0;
            var z = "Guilherme";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}