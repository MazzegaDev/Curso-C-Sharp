namespace EX1 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Informe um numero");
      int num = int.Parse(Console.ReadLine());

      if (num < 0) {
        Console.WriteLine("NEGATIVO");
      } else {
        Console.WriteLine("NAO NEGATIVO");
      }
    }
  }
}