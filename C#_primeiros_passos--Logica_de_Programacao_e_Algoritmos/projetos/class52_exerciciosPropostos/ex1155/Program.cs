using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1155");
        Console.WriteLine("Sequência S");
        // Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        double s = 0;

        for ( double i = 1.0; i <= 100.0; i++ ) {
            s += 1 / i;
        };

        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};