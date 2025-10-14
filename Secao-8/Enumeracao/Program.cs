
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Enumerações
            ->É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
            ->Palavra chave em C#: enum, enum é um tipo valor

            Vantagem:
            ->Melhor semantica, codigo mais legivel e auxiliado pelo compilador

            Sintaxe:

            enum nomeDaVariavel: tipo {
                PendingPayment = 0,
                Processing = 1,
                Shipped =  2,
                Delivered = 3,
            }

            class Order{
                public int Id {get; set;}
                public nomeDaVariavel {get; set;}
            }

            Convertendo string para enum:
            string txt = OrderStatus.PendingPayment.ToString();

            Convertendo enum para string:
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");


            */
            //Classe da order

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                //OrderStatus -> nome do tipo enum
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}