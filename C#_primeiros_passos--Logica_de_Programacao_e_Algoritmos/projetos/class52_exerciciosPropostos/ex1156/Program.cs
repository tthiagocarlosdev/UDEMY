using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1156");
        Console.WriteLine("Sequência S II");
        // Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        double n = 1.0, s = 1.0;

        for ( double i = 3.0; i <= 39.0; i += 2.0 ) {
            s += i / Math.Pow(2.0, n);
            n++;
        };

        Console.WriteLine(s.ToString("F2", CultureInfo.CurrentCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};