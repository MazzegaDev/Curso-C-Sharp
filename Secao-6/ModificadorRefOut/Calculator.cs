
public class Calculator
{   
    /*
        Modificadores ref e out

        ->Ref
        Quando chamamos uma funçao e passamos uma varivael com parametro, precisamos utilizar o ref para que o parametro da funçao aponte para  a variavel original
        ->Out
        O modificador out tem a mesma funçao que o ref, porem ele nao exige que a variavel seja inicializada com algum valor
    */
    public static void Triple(int origin, out int result)
    {
        result = origin * 3;
    }
}
