namespace FuncoesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Funções para strings
                ->Formatar
                ToLower(), 
                ToUpper(), 
                Trim()

                ->Buscar
                IndexOf, 
                LastIndexOf

                ->Recortar
                Substring(inicio) <- Recorta do valor de inicio em diante, 
                Substring(inicio, tamanho) Recorta do valor de inicio em diante, porem com um tamanho delimitado
                str.Split('') <- Recorta com base em um caracter

                ->Substituir
                Replace(char, char), 
                Replace(string, string)
                String.IsNullOrEmpty(str), 
                String.IsNullOrWhiteSpace(str)
                

                ->Conversão para numero
                int x = int.Parse(str), 
                int x = Convert.ToInt32(str)

                ->Conversão de número
                str = x.ToString(), 
                str = x.ToString("C"), 
                str = x.ToString("C3"),
                str = x.ToString("F2")
            */

            string original = "abcde FGHIJ ABC abc DEFG    ";

            //tudo para maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"-----");

            //tudo para Minusculo
            s1 = original.ToLower();
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToLower: -{s1}-");
            Console.WriteLine($"-----");

            //Sem espacos em branco
            s1 = original.Trim();
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"Trim: -{s1}-");
            Console.WriteLine($"-----");

            //Procura primeira ocorrencia
            int n1 = original.IndexOf("bc");
            Console.WriteLine($"IndexOf('bc'): -{n1}-");
            Console.WriteLine($"-----");

            //Procura ultima ocorrencia
            n1 = original.LastIndexOf("bc");
            Console.WriteLine($"LastIndexOf('bc'): -{n1}-");
            Console.WriteLine($"-----");

            //Recortar um string
            s1 = original.Substring(3);
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"Substring(3): -{s1}-");
            Console.WriteLine($"-----");

            //Recortar um string delimitando um tamanho de caracter
            s1 = original.Substring(3, 5);
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"Substring(3, 5): -{s1}-");
            Console.WriteLine($"-----");

            //Substituindo um char da string por outro
            s1 = original.Replace('a', 'x');
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"Replace('a', 'x'): -{s1}-");
            Console.WriteLine($"-----");

            //Substituindo uma parte da string por outra
            s1 = original.Replace("abc", "xy");
            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"Replace(): -{s1}-");
            Console.WriteLine($"-----");

            //Testando se a string é vazia
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"-----");

            //Testa se a string é vazia ou so é espaços em branco
            b1 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine($"IsNullOrWhiteSpace: {b1}");
            Console.WriteLine($"-----");
        }
    }
}