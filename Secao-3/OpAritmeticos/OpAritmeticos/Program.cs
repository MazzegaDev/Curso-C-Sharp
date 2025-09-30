namespace OpAritmeticos {
  class Program {
    static void Main(string[] args) {
      int n1 = 3 + 4 * 2;
      int n2 = (3 + 4) * 2; // () prioriza a operaçao.
      int n3 = 17 % 3;
      int n4 = 10 / 8; // Perde informçao pois o resultado e quebrado.
      double n5 = (double)10 / 8; // Forma correta com o casting ou 10.0 / 8

      double a = 1.0, b = -3.0, c = -4.0;

      double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

      double x1 = (-b + Math.Sqrt(delta) ) / (2.0 * a); // 1 -> -b + Math.Sqrt(delta) 2 -> 2.0 * a 3 -> divide os dois

      Console.WriteLine(delta);
      Console.WriteLine(x1);
    }
  }
}