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
            
            int anos = 0;

            while ( pa <= pb && anos <= 100 ) {
              pa += (int)((pa * g1) / 100.0);
              pb += (int)((pb * g2) / 100.0);
              anos++;
            };

            if ( anos <= 100 ) {
              Console.WriteLine( anos + " anos.");  
            } else {
              Console.WriteLine("Mais de 1 seculo.");
            };
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};