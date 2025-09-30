using System.Globalization;

namespace EX1
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcArea()
        {
            return Largura * Altura;
        }
        public double CalcPerimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double CalcDiagonal()
        {
            double elevados = Largura * Largura + Altura * Altura;
            return Math.Sqrt(elevados);
        }

        public override string ToString()
        {
            return $"Area {CalcArea().ToString("F2", CultureInfo.InvariantCulture)} Perimetro {CalcPerimetro().ToString("F2", CultureInfo.InvariantCulture)} Diagonal {CalcDiagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

}

