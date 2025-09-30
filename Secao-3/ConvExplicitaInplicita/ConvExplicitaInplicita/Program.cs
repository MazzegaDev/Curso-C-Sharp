namespace ConvExplicitaInplicita
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
          Converçao Explicita /Casting ->  E uma conversao explicita de tipos compativeis


          Converçao Inplicita entre tipos -> E quando um conteudo de um determinado tipo 
          pode ser atribuido a uma variavel de outro tipo
      */

      //Conversao implicita de tipos: Float -> 4 bytes | Double -> Bytes, ou seja um float cabe em um double
      float x = 4.5f;
      double y = x;

      Console.WriteLine(y);


      //Casting explicito de tipos
      double a;
      float b;

      a = 5.1;
      b = (float)a;
      Console.WriteLine(b);

      double c;
      int d;

      c = 5.1;
      d = (int)c;
      //Apos o casting de double ou int para int iria ocorrer uma perda de informacao, pois os valores decimais serao truncados (Perdidos)
      Console.WriteLine(d);

      int e = 5;
      int f = 2;
      /*
          O casting tambem e necessario quando fazemos um divisao, pois
          o compilador entende que queremos fazer uma divisao inteira e ele ira descartar o resto:
          e/f = 2, 5<- sera descartado
          (double) e/f -> um double dividido por um inteiro = double, ou seja 2,5

       */
      double resultado = (double)e / f;
      Console.WriteLine(resultado);

    }
  }
}