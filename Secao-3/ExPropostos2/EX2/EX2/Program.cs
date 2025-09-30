namespace EX2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Informe um numero inteiro");
      int num = int.Parse(Console.ReadLine());

      if(num %2 == 0) {
        Console.WriteLine("PAR");
      } else {
        Console.WriteLine("IMPAR");
      }
    }
  }
}