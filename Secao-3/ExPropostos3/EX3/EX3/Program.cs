namespace EX3 {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Informe um dos produtos: ");
      Console.Write(" 1-Alcool  2-Gasolina  3-Diesel  4-FIM");
      int op = int.Parse(Console.ReadLine());
      int contD = 0;
      int contG = 0;
      int contA = 0;

      while(op != 4) {
        if(op > 4) {
          Console.WriteLine("OP invalida");
        }else if (op == 3) {
          contD++;
        } else if(op == 2) {
          contG++;
        }else if(op == 1) {
          contA++;
        }

        Console.WriteLine("Informe um dos produtos: ");
        Console.Write(" 1-Alcool  2-Gasolina  3-Diesel  4-FIM");
        op = int.Parse(Console.ReadLine());
      }

      Console.WriteLine("MUITO OBRIGADO!");
      Console.WriteLine($"Alcool: {contA}:");
      Console.WriteLine($"Gasolina: {contG}");
      Console.WriteLine($"Diesel: {contD}");
    }
  }
}