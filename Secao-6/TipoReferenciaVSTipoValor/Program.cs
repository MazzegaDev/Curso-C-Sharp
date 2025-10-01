namespace TipoReferenciaVSTipoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
                ->tipos referencia
                Classes sao do tipo Referencia ou seja quando declaramos uma variavel do tipo de uma classe essa variavel vai ficar no stack, porem quando instanciamos uma classe nesse variavel o valor do objeto vai ficar no heap assim a variavel que guarda a instancia da classe vai apontar para o endereco de memoria aonde fica o objeto
                Tipos referencia tambem aceitam tipos null que indica que a variavel nao aponta para ninguem

                ->tipos valor
                A linguagem C# possui os structs que sao os tipos basicos, eles sao do tipo valor ou seja ficam diretamente na memoria
                ->Criando seus proprios structs
                struct Point{
                    public double X,Y;

                    public override string ToString(){
                        return "(" + X + "," + Y + ")";
                    }
                }
                Para inicializar uma variavel struct
                p = new Point();

                ->valores padrao
                Quando alocamos com new qualquer tipo estruturado (classe, struct array) sao atribuitos valores padroes para cada elemento
                -> numeros = 0
                -> bool = false
                -> char = caractere codigo 0
                -> objeto = null            
                OBS: Variaveis apenas declaradas porem nao instanciadas, inicia como nao atribuidas e o proprio compilador nao permite que ela sejam acessada.
            */

            Point p;
            p.X = 10; //Inicializando o tipo struct
            p.Y = 20;
            Console.WriteLine($"{p}");

            p = new Point();
            p.X = 40;
            p.Y = 20;
            Console.WriteLine($"{p}");
        }
    }
}