namespace EntradaDeDadosPT1 {
  class Program {
    static void Main(string[] args) {
      /*
         Console.ReadLine() -> le dados do teclado
      */

      string frase = Console.ReadLine();
      string x = Console.ReadLine();
      string y = Console.ReadLine();
      string z = Console.ReadLine();

      Console.WriteLine("Voce digitou -> " + frase);
      Console.WriteLine(x);
      Console.WriteLine(y);
      Console.WriteLine(z);

      string[] vet = Console.ReadLine().Split(' '); // Cria um array com as palavras separadas por espaço
      string p1 = vet[0]; // Recebe a primeira palavra do array
      string p2 = vet[1]; // Recebe a segunda palavra do array
      string p3 = vet[2]; // Recebe a terceira palavra do array



      Console.WriteLine("Array de palavras");
      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine(p3);
    }
  }
}