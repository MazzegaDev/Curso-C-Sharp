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
            */
            //Declarar uma matriz:
            // tipo, representação [,], variavel, instancia, quantidade de linhas e colunas.
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank); //Retorna a quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); //Retorna o tamanho da primeira dimensão -> linhas

            Console.WriteLine(mat.GetLength(1)); //Retorna o tamanho da segunda dimensão -> colunas
        }
    }
}