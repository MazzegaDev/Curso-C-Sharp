using System.Globalization;

namespace EstruturaWhile {
  class Program {
    static void Main(string[] args) {
     /*
        estrutura while
        while(condicao){
          comando
        }
        
       passo a passo 
        1 - testa para ver se e true e entrar no loop
        2 - executa os comandos dentro do loop
        3 - verifica se a condicao ainda e true, se sim continua executando
        4 - se a condicao se tornar false saia do loop



     */

      //Atribuimos o valor
      Console.Write("Digite um numero");
      double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      //Verificamos se o valor e maioro ou igual a zero
      while (n1 >= 0.0) {
        //Se sim repita ate ser falso o comando abaixo
        double raiz = Math.Sqrt(n1);
        Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

        Console.Write("Digite outro numero");

        //Verifica se o valor continua respeitando a condicao
        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      }

      Console.WriteLine("Numero negativo.");



    }
  }
}