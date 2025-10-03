namespace ModificadorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int result;
            //Parametro se referencia diretamente a essa variavel
            Calculator.Triple(a, out result);
            Console.WriteLine($"{result}");
        }
    }
} 