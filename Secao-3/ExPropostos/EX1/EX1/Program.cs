namespace EX1{
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("1 - valor");
      int v1 = int.Parse(Console.ReadLine());

      Console.WriteLine("2 - valor");
      int v2 = int.Parse(Console.ReadLine());

      int total = v1 + v2;
      Console.WriteLine($"SOMA = {total}");


    }
  }
}