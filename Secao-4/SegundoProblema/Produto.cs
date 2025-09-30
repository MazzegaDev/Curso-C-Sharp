using System.Globalization;

namespace SegundoProblema
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quant)
        {
            Quantidade += quant;
        }

        public void RemoverProduto(int quant)
        {
            Quantidade -= quant;
        }
        //Faz um sobreposiçao
        //Simplismente criamos um metodo que quando o objeto produto e chamado retorna os dados do produto em forma de string.
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " Quantidade: " + Quantidade + " Unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}