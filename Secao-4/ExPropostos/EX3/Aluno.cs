namespace EX3
{
    public class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double Verificar()
        {
            if (CalcularNotaFinal() >= 60)
            {
                return CalcularNotaFinal();
            }
            else
            {
                double dif = CalcularNotaFinal() - 60;
                return dif;
            }
        }
    }    
}


