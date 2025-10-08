namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Sintaxe alternativa: switch-case
                ->switch-case
                São uma estrututra de condição logica de uma variavel, essa condição envolve testar se a varivel coresponde a um case:

                var minhaVariavel = ...;
                switch(minhaVariavel){
                    case1:
                        cw("caso 1");
                        break;
                    default:
                        cw("Valor invalido")
                }
                    >Default
                    Default e usado quando nenhum dos casos sao validos, assim aplicamos um valor padrao

                Essa estrutura é util quando temos muitos testes logicos encadeado, usando switch case podemos melhorar a legibilidade do codigo
            */
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine($"Day: {day}");
        }
    }
}