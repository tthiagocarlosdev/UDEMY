using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1142");
        Console.WriteLine("PUM");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        int c = 1;

        for (int i = 0; i < n; i++) {
            for(int j = 0; j < 3; j++) {
                Console.Write(c + " ");
                c++;
            };
            Console.WriteLine("PUM");
            c++;
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};