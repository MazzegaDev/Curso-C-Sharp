namespace EX2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Digite a quantidade de valores a serem lidos.");
      int n = int.Parse(Console.ReadLine());
      int contIN = 0;
      int contOUT = 0;


      for(int i = 0; i < n; i++) {

        Console.WriteLine("Digite um valor inteiro");
        int x = int.Parse(Console.ReadLine());
        
        if(x >= 10 && x <= 20) {
          contIN++;
        } else {
          contOUT++;
        }
      }
      Console.WriteLine($"{contIN} in");
      Console.WriteLine($"{contOUT} out");
    }
  }

}