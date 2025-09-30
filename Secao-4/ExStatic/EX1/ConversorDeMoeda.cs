public class ConversorDeMoeda
{
    public static double Iof = 6.0;

    public static double ValotTotalPagar(double tdolar, double cot)
    {
    
        double valorTotal = tdolar * cot;
        return valorTotal + valorTotal * Iof / 100.0;
    }
}
