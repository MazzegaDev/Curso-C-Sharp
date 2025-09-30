namespace EscopoEInicializacao {
  class Program { 
    static void Main(string[] args) {
      double preco = double.Parse(Console.ReadLine());
      double desc = 0.0;

      if(preco > 100.0) {
        desc = preco * 0.1;
      }

      Console.WriteLine(desc);

    }
  }
  
}