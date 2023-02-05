using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1153");
        Console.WriteLine("Fatorial Simples");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        int fatorial = 1;

        for(int i = 1; i <= n; i++) {
            fatorial *= i;
        }

        Console.WriteLine(fatorial);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};