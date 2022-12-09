using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1015");
      Console.WriteLine("Distância");
      Console.WriteLine("x1/y1/x2/y2");

      double x1, y1, x2, y2, distancia;
      string[] p1;
      string[] p2;

      p1 = Console.ReadLine().Split(' ');
      p2 = Console.ReadLine().Split(' ');

      x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
      y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);
      x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
      y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

      distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

      Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
};