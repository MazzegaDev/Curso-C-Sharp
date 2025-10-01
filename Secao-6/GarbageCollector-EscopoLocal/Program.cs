namespace GarbageCollectorEscopoLocal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ->Desalocaçao por garbage collector
                O garbage collector atua no heap monitorando os objetos, quando ele detecta um objeto sem referencia ele e automaticamente desalocado
                
                ->Desalocaçao por escopo
                Na desalocacao por escopo as variaveis sao automaticamente desalocadas quando seu escopo sai de execucao, por exemplo:
                void method1(){
                    int x = 10;
                    if(x > 0){
                        int y = 20;
                    }
                    Console.WriteLine(x);
                }
                Depois que sair do escopo do if a variavel y nao vai mais existir pois ela perdera seu escopo
            */
        }
    }
}