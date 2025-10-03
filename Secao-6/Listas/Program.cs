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

                ->Operçoes com lista
                    >Inserir elemento na lista: Add,Insert(Voce pode falar a posiçao)
                    >Tamanho da lista: Count
                    >Encontrar primeiro ou ultimo elemento: list.Find, list.FindLast
                    >Encontrar primeira ou ultima posiçao: list.FindIndex, list.FindLastIndex
                    >Filtrar a lista com base em um predicado (Cria uma nova lista com esses elementos): list.FindAll
                    >Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

            */
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count" + list.Count);
            Console.WriteLine($"--------");
            string s1 = list.Find(x => x[0] == 'A'); //<- forma com lambda/Func anonima
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First index 'A': {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last index 'A': {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"-------");
            list.RemoveRange(2, 2); //A partir da posiçao 2 quero remover 2 elementos
            foreach (string obj  in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"-------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"--------");
            
        }
    }
}