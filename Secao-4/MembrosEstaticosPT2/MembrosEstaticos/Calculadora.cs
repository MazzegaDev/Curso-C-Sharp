
public class Calculadora
{
    public static double PI = 3.14;
     

    public static double CalcularCirc(double raio)
    {
        return 2.0 * PI * raio;
    }

    public static double Volume(double raio)
    {
        return 4.0 / 3 * PI * Math.Pow(raio, 3.0);
    }
}
