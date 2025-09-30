namespace EstruturaFOR {
  class Program {
    static void Main(string[] args) {
      Console.Write("Quantos numeros inteiros voce vai digitar ");
      int n = int.Parse(Console.ReadLine());

      int soma =  0;

      for (int i = 0; i < n; i++) {
        Console.Write($"Digite o valor #{i + 1}:");
        int valor = int.Parse(Console.ReadLine());

        soma += valor;
      }
      Console.WriteLine($"Soma = {soma}");
      
    }
  }
}