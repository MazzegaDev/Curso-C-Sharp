namespace EX1 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Insira a senha.");
      int senha = int.Parse(Console.ReadLine());

      while (senha != 2002) {
        Console.WriteLine("Senha Invalida - Insira novamente a senha!");
        senha = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Acesso Permitido.");
    }
  }
}