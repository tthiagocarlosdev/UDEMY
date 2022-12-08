using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1012");
      Console.WriteLine("Área");
      Console.WriteLine("A/B/C");

      double A, B, C;
      const double Pi = 3.14159;
      double areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
      string[] vet;

      vet = Console.ReadLine().Split(' ');
      A = double.Parse(vet[0], CultureInfo.InvariantCulture);
      B = double.Parse(vet[1], CultureInfo.InvariantCulture);
      C = double.Parse(vet[2], CultureInfo.InvariantCulture);

      areaTrianguloRetangulo = (A * C) / 2;
      areaCirculo = Pi * Math.Pow(C, 2);
      areaTrapezio = ((A + B) * C) / 2;
      areaQuadrado = Math.Pow(B, 2);
      areaRetangulo = A * B;

      Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
      Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
      
      Console.ReadLine();
    }
  }
};