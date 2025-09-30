using System.Globalization;
namespace EX2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Entre com seu nome completo: ");
      string nomeCompleto = Console.ReadLine();
      Console.WriteLine("Nome completo: " + nomeCompleto);

      Console.WriteLine("Quantos quartos tem sua casa: ");
      int quartos = int.Parse(Console.ReadLine());
      Console.WriteLine("Tem " + quartos + " quartos");

      Console.WriteLine("Entre com o preço de um produto: ");
      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("O preço e " + preco.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
      Console.WriteLine("--- Mesma linha ---");
      string[] vet = Console.ReadLine().Split(' ');
      string nome = vet[0];
      int idade = int.Parse(vet[1]);
      double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

    
      Console.WriteLine(nome);
      Console.WriteLine(idade);
      Console.WriteLine(altura.ToString("F2"));
    }
  }
}