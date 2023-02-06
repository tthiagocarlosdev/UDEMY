using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1060");
        Console.WriteLine("Crescimento Populacional");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int t = int.Parse(Console.ReadLine());

        for ( int i = 0; i < t; i++ ) {
            string[] v = Console.ReadLine().Split(' ');
            int pa = int.Parse(v[0]);
            int pb = int.Parse(v[1]);
            double g1 = double.Parse(v[2], CultureInfo.InvariantCulture);
            double g2 = double.Parse(v[3], CultureInfo.InvariantCulture);

            Console.WriteLine(pa);
            Console.WriteLine(pb);
            Console.WriteLine(g1.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(g2.ToString("F1", CultureInfo.InvariantCulture));
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};