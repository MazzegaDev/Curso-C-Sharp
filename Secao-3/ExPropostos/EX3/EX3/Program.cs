namespace EX3 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("1 - Valor");
      int v1 = int.Parse(Console.ReadLine());
      

      Console.WriteLine("2 - Valor");
      int v2 = int.Parse(Console.ReadLine());

      
      Console.WriteLine("3 - Valor");
      int v3 = int.Parse(Console.ReadLine());


      Console.WriteLine("4 - Valor");
      int v4 = int.Parse(Console.ReadLine());

      int dif = v1 * v2 - v3 * v4;
      Console.WriteLine($"DIFERENÇA = {dif}");
    }
  }
}