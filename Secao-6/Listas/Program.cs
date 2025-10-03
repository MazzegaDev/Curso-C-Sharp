using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Listas
                ->Lista e uma estrutura de dados:
                    >Homogenea -Dados do mesmo tipo
                    >Ordenada -Elementos acessados por meio de posiçoes
                    >Inicia vazia, e seus elementos sao alocados sob demanda
                    >Cada elemento ocupa um "no" da lista
                
                Como usar:
                Listas pertencem a um namespace entao precissamos chamar esse namespace com: System.Collections.Generic

                Criar e instanciar uma lista:
                List<tipo> list = new List<mesmo tipo>();

                Criando uma lista ja com valores:
                List<string> list = new List<string> {"Maria", "Alex"};

                Vantagens
                ->Tamanho variavel
                ->Facilidade para se realizar inserçoes e deleçoes
                Desvantagens
                ->Acesso sequencial aos elementos*(Pode ser otimizada) 
            */
            List<string> list = new List<string>();
            List<string> list2 = new List<string> { "Maria", "Alex" };
        }
    }
}