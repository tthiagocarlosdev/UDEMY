using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1061");
        Console.WriteLine("Tempo de um Evento");
        Console.WriteLine("Dia e Hora Inicial");

        double A, B, C, delta, R1, R2;

        string[] v = Console.ReadLine().Split(' ');
        A = double.Parse(v[0], CultureInfo.InvariantCulture);
        B = double.Parse(v[1], CultureInfo.InvariantCulture);
        C = double.Parse(v[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(B, 2.0) - (4.0 * A * C);
        
        if ( A == 0.0 || delta < 0.0 ) {
            Console.WriteLine("Impossivel calcular");
        } else {
            R1 = ( -B + Math.Sqrt(delta)) / (2.0 * A);
            R2 = ( -B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
        }

      Console.ReadLine();
    }
  }
};