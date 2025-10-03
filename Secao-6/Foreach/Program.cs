namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ->Foreach
                O laço foreach e usado para percorrer arrays sua leitura:
                Para cada objeto em arr faça.

                string[] arr = new string[] {"Maria", "Joao", "Alex"}
                foreach(string obj in arr){}
                
                obj sendo o apelido para cada elemento no vetor
            */
            string[] arr = new string[] { "Maria", "Joao", "Alex" };
            foreach (string obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}