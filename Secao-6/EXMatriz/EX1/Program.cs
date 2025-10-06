namespace EXMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Informe o valor de linhas.");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o valor de colunas.");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int l = 0; l < M; l++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int c = 0; c < N; c++)
                {
                    mat[l, c] = int.Parse(values[c]);
                }
            }
            Console.WriteLine($"Informe um numero da matriz");
            int X = int.Parse(Console.ReadLine());

            for (int l = 0; l < M ; l++)
            {
                for (int c = 0; c < N; c++)
                {
                    if (mat[l, c] == X)
                    {
                        Console.WriteLine($"Position {l},{c}:");
                    }
                    if (c > 0)
                    {
                        Console.WriteLine($"Left: {mat[l, c - 1]}");
                    }
                    if (l > 0)
                    {
                        Console.WriteLine($"Up: {mat[l - 1, c]}");
                    }
                    if (c < N - 1)
                    {
                        Console.WriteLine($"Right: {mat[l, c + 1]}");
                    }
                    if (l < M - 1)
                    {
                        Console.WriteLine($"Down: {mat[l + 1, c]}");
                    }
                }
            }
        }
    }
}