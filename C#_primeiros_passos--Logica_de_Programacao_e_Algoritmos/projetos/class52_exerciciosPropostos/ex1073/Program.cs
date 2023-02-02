using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1073");
        Console.WriteLine("Quadrado de Pares");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());

        for ( int i = 1; i <= n; i++ ) {
            if ( i % 2 == 0) {
                Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
            }
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};