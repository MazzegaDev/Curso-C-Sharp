namespace EX4 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Informe a hora de inicio e de termino do jogo");
      string[] hrs = Console.ReadLine().Split();
      int inicio = int.Parse(hrs[0]);
      int termino = int.Parse(hrs[1]);

      int duracao;
      if(inicio < termino) {
        duracao = termino - inicio;
      } else {
        duracao = 24 - inicio + termino;
      }
      Console.WriteLine($"O jogo durou {duracao}HORA(S)");

    }
  }
}