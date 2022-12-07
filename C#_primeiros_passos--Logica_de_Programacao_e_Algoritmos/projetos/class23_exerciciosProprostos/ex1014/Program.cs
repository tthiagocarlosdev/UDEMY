using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1014");
      Console.WriteLine("km/Litros");

      int X;
      double Y, consumo;

      X = int.Parse(Console.ReadLine());
      Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      consumo = X / Y;

      Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

      Console.ReadLine();
    }
  }
};