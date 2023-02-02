using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1074");
        Console.WriteLine("Par ou Ímpar");
        Console.WriteLine("1 valor/int N valores/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());

        for ( int i = 0; i < n; i++ ) {

            int x = int.Parse(Console.ReadLine());

            if ( x == 0) {
                Console.WriteLine("NULL");
            } else if ( x % 2 == 0 ) {
                Console.Write("EVEN ");
            } else {
                Console.Write("ODD ");
            }

            if ( x > 0 ) {
                Console.WriteLine("POSITIVE");
            } else if ( x < 0 ) {
                Console.WriteLine("NEGATIVE");
            }
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};