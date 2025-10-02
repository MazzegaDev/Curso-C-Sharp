

public class Calculator
{   
    /*
        Modificador Params
        O modificador params nos permite passar um numero variavel de parametros para uma funcao
    */
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}
