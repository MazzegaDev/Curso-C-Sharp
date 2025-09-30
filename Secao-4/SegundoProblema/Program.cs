using System.Globalization;

namespace SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine($"Entre os dados do produto");

            Console.Write($"Nome: ");
            produto1.Nome = Console.ReadLine();

            Console.Write($"Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Quantidade no estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());

            double vTotal = produto1.ValorTotalEmEstoque();
            Console.WriteLine($"Dados do produto: {produto1}");

            Console.Write($"Digite o numero de produtos a ser adicionado ao esotque: ");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);
            
            vTotal = produto1.ValorTotalEmEstoque();
            Console.WriteLine($"Dados atualizados: {produto1}");

            Console.Write($"Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto1.RemoverProduto(qte);

            vTotal = produto1.ValorTotalEmEstoque();
           Console.WriteLine($"Dados atualizados: {produto1}");
        }
    }
}