using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1157");
        Console.WriteLine("Divisores I");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        
        for ( int i = 1; i <= n; i++ ) {
            if ( n % i == 0 ) {
                Console.WriteLine(i);
            };
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};