namespace EX2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Insira o valor de  X e Y");
      string[] vetor = Console.ReadLine().Split(' ');
      int x = int.Parse(vetor[0]);
      int y = int.Parse(vetor[1]);

      while(x != 0 && y != 0) {
        if(x > 0 && y > 0) {
          Console.WriteLine("Primeiro quadrante");
        }else if(x < 0 && y > 0) {
          Console.WriteLine("Segundo quadrante");
        }else if (x < 0 && y < 0) {
          Console.WriteLine("Terceiro quadrante");
        } else {
          Console.WriteLine("Quarto quadrante");
        }

        Console.WriteLine("Insira o valor de X e Y");
        vetor = Console.ReadLine().Split(' ');
        x = int.Parse(vetor[0]);
        y = int.Parse(vetor[1]);
      }
    }
  }
}