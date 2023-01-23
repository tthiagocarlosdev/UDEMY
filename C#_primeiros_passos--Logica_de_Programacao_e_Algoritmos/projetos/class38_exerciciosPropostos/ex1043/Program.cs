using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1043");
        Console.WriteLine("Triângulo");
        Console.WriteLine("3 Valores/double");
        Console.WriteLine("------------------------");

        double A, B, C, areaTrapezio, perimetroTriangulo;
        string[] v = Console.ReadLine().Split(' ');
        A = double.Parse(v[0], CultureInfo.InvariantCulture);
        B = double.Parse(v[1], CultureInfo.InvariantCulture);
        C = double.Parse(v[2], CultureInfo.InvariantCulture);

        if(A + B > C && A + C > B && C + B > A){
            perimetroTriangulo = A + B + C;
            Console.WriteLine("Perimetro = " + perimetroTriangulo.ToString("F1", CultureInfo.InvariantCulture));
        } else {
            areaTrapezio = (((A + B) * C) / 2);
            Console.WriteLine("Area = " + areaTrapezio.ToString("F1", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};