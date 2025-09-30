using System.Globalization;

namespace TF2
{
    public class Func
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porc)
        {
            SalarioBruto += SalarioBruto * porc / 100.0;
        }

        public override string ToString()
        {
            return $"Funcionario: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}


