using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.WriteLine("Exemplo 1");

      int x, y;

      x = 5;

      y = 2 * x;

      Console.WriteLine(x);
      Console.WriteLine(y);
      
      Console.ReadLine();

      Console.WriteLine("Exemplo 2");

      int w;
      double z;

      w = 5;

      z = 2 * w;

      Console.WriteLine(w);
      Console.WriteLine(z);

      Console.ReadLine();

      Console.WriteLine("Exemplo 3 -  Calcular a área de um trapézio");

      double b, B, h, area;

      b = 6.0;
      B = 8.0;
      h = 5.0;

      area = ((B + b) / 2.0) * h;

      Console.WriteLine(area);

      Console.ReadLine();

      Console.WriteLine("Exemplo 4");

      int i, f;
      double resultado;

      i = 5;
      f = 2;

      resultado = (double) i / f;

      Console.WriteLine(resultado);

      Console.ReadLine();

      Console.WriteLine("Exemplo 5");

      double m;
      int n;

      m = 5.0;
      n = (int) m;

      Console.WriteLine(n);

      Console.ReadLine();
    }
  }
}