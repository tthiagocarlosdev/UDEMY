using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("------------------------------");
      Console.WriteLine("          Retângulo");
      Console.WriteLine("------------------------------");

      double _base, altura, area, perimetro, diagonal;

      Console.Write("Digite a base: ");
      _base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite a altura: ");
      altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      area = _base * altura;
      perimetro = 2 * (_base + altura);
      diagonal = Math.Sqrt(Math.Pow(_base, 2) + Math.Pow(altura, 2));

      Console.WriteLine("------------------------------");
      Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
      Console.WriteLine("------------------------------");
      
      Console.ReadLine();
    }
  }
};