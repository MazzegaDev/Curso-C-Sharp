using System.Globalization;

namespace SaidaDeDados {
    class Program {
        static void Main(string[] args) {
            /*
                -Saida de dados-
                Diferenca entre Write e WriteLine
                -> Write apenas escreve na mesma linha
                -> Write line faz uma quebra de linha no final
                
                Console.Write("Bom dia");
                Console.WriteLine("Boa tarde!");
                Console.WriteLine("Boa Noite!");
                Saida:
                Bom diaBoa tarde!
                Boa Noite! <- vem no final pois o "Boa tarde" e um WriteLine

                Console.WriteLine(genero);
                Console.WriteLine(idade);
                Console.WriteLine(saldo);
                Console.WriteLine(saldo.ToString("F2")); //<- imprime com duas casas decimais
                Console.WriteLine(nome);
                Console.WriteLine(saldo.ToString("F4"));
                Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // <- desconcidera a formatacao especifica de pais
            */     
            int idade = 20;
            double saldo = 10.35784;
            string nome = "Gui";

            /*
                PlaceHolder:               
                As variaveis iram ocupar o lugar das {0}...{1}.. que sao os placeholder,
                depois que escrevemos o output colocamos uma virgula e as variaveis,
                a ordem das variaveis importa.
                Podemos ecolher a quantidade de casas decimais em variaveis com o ponto flutuante ex:
                {2:F2}
            */
            Console.WriteLine("{0} tem {1} anos e tem saldo {2:F2} reais", nome, idade, saldo);

            /*
                Interpolacao 
            */
            Console.WriteLine($"{nome} tem {idade} e tem saldo {saldo:F2} reais.");

        }
    }
}