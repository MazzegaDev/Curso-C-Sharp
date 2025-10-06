namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ->Matrizes
                Matriz e um arranjo bidimensional, a matriz e uma estrutura de dados:
                    >Homogenea
                    >Ordenada
                    >Alocada de uma vez so, em um bloco continuo de memoria
                Vantagens:
                    >Acesso imediato aos elementos pela sua posiçao
                Desvantagens:
                    >Tamanho fixo
                    >Dificuldade para se realizar inserçoes e deleçoes
                Declarar uma matriz:
                    >tipo, representação [,], variavel, instancia, quantidade de linhas e colunas.
                    >double[,] mat = new double[2, 3];
                Metodos:
                    >Console.WriteLine(mat.Length);
                    >Console.WriteLine(mat.Rank); //Retorna a quantidade de linhas
                    >Console.WriteLine(mat.GetLength(0)); //Retorna o tamanho da primeira dimensão -> linhas
                    >Console.WriteLine(mat.GetLength(1)); //Retorna o tamanho da segunda dimensão -> colunas
            */
            Console.WriteLine($"Informe o numero de linhas e colunas");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            //Linhas
            for (int l = 0; l < n; l++)
            {
                string[] values = Console.ReadLine().Split(' ');
                //Colunas
                for (int c = 0; c < n; c++)
                {
                    //Preenche as linhas das colunas
                    mat[l, c] = int.Parse(values[c]);
                }
            }
            Console.WriteLine($"Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int negatives = 0;
            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (mat[l, c] < 0)
                    {
                        negatives++;
                    }
                }
            }
            Console.WriteLine($"Negatives count: {negatives}");
        }
    }
}