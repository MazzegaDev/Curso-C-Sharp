namespace BoxingUnboxing
{
    class Program
    {
        /*
            Boxing e unboxing
            
            ->Boxing 
            Boxing e a conversao de um objeto tipo valor para um objeto tipo referencia compativel.
            ->Unboxing e a conversao de um objeto tipo referencia para um objeto tipo valor compativel
        */
        static void Main(string[] args)
        {
            //Boxing
            int x = 20;
            Object obj = x;
            // A variavel obj referencia para um objeto no heap

            //Unboxing
            int y = (int)obj; //So funciona se os tipos forem compativeis
        }
    }
}