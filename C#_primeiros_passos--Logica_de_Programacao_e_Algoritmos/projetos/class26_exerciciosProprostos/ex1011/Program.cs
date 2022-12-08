using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1011");
      Console.WriteLine("Esfera");
      Console.WriteLine("RAIO");

      double raio, volume;
      const double Pi = 3.14159;

      raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      volume = (4.0/3) * Pi * Math.Pow(raio, 3);

      Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
      
      Console.ReadLine();
    }
  }
};