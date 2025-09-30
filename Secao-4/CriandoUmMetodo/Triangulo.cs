/*
    Metodos em C#
    A sintaxe de metodos e a seguinte
    Primeiro e se o metodo e publico ou nao: public,
    Depois e o tipo de retorno do metodo: double,
    Por fim o nome do metodo: CalcArea
*/
namespace CriandoUmMetodo
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;


        public double CalcArea()
        {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));


        }

        
    }
    
};

