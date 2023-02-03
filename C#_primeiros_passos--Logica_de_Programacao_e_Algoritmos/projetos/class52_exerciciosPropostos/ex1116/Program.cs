using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1116");
        Console.WriteLine("Dividindo X por Y");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int x, y;
        double resultado = 0.0;

        int n = int.Parse(Console.ReadLine());

        while (n > 0) {
            
            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);

            if (y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                resultado = (double) x / y;
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }

            n--;
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};