using System.Globalization;

namespace EntradaDeDadosPT2 {
  class Program {
    static void Main(string[] args) {

      int n1 = int.Parse(Console.ReadLine()); //Converte a string em inteiro
      char ch = char.Parse(Console.ReadLine());
      double dp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Resolve o erro do . como separador 


      Console.WriteLine($"Voce digitou {n1}, {ch}, {dp.ToString("F2", CultureInfo.InvariantCulture)}");

      string[] vet = Console.ReadLine().Split(' ');
      string nome = vet[0];
      char sexo = char.Parse(vet[1]);
      int idade = int.Parse(vet[2]);
      double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

      Console.WriteLine(nome);
      Console.WriteLine(sexo);
      Console.WriteLine(idade);
      Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}