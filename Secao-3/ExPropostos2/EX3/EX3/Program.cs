namespace EX3 {
  class Program {
    static void Main(string[] arg) {
      Console.WriteLine("1 - Valor");
      int v1 = int.Parse(Console.ReadLine());

      Console.WriteLine("2 - Valor");
      int v2 = int.Parse(Console.ReadLine());

      if(v1 % v2 == 0 || v2 % v1 == 0) {
        Console.WriteLine("Sao multiplos");
      } else {
        Console.WriteLine("Nao sao multiplos");
      }
    }
  }
}