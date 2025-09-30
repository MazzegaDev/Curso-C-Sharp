using System.Globalization;

public class Produto
{   

    /*
        Ordem sugerida para implementaçao de membros de classe
        1 - Atributos privados
        2 - Propriedades autoimplementadas
        3 - Construtores
        4 - Propriedades customizadas
        5 - Outros metodos da classe 
    */

    private string _nome;
    /*
        Auto-Properties
        Elas definem automaticamente os metodos get e set para os atributos que nao nescessitam de uma logica particular
    */
    public double Preco { get; private set; }
    public int Quantidade  { get; private set; }

    public Produto()
    {
        
    }
    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        Quantidade = quantidade;
    }
    //Sobrecarga -> quando nossa classe tem mais de um construtor
    public Produto(string nome, double preco) : this()
    {
        _nome = nome;
        Preco = preco;
        Quantidade = 5;
    }

    /*
        Getters e Setters para acessar e definir o valor do atributo nome de uma
        forma "Controlada"
    */

    /*
        Properties
        Sao definicoes de metodos encapsulados porem exponde uma sintaxe similiar a de atributos e nao de metodos.
        Elas facilitam o acesso e a definicao de valores pois podemos fazer isso come se fossem um atributo normal

        Product p1 = new Product();

        p1.Nome = "TV";

        Assim acessamos a propertie Nome e definimos um valor pelo seu set
    */
    public string Nome
    {
        get { return _nome; }
        set {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }
    
    
    
    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
    public override string ToString()
    {
        return _nome
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}