using System.Globalization;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Sintaxe alternativa
                ->Condicional ternaria
                É uma estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição.

                Sintaxe:
                (condição) ? valor_se_verdadeiro : valor_se_falso

                Exemplo:
                (2 > 4) ? 50 : 80 -> 80
                (10 != 3) ? "Maria" : "Alex" -> "Maria"
            */

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Se preco < 20 -> preco * 0.1
            //Se preco nao for < 20 -> preco * 0.05
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);

        }
    }
}