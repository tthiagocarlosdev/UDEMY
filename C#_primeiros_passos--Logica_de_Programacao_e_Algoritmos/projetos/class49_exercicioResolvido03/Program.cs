using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1078");
        Console.WriteLine("Tabuada");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++){
            Console.WriteLine(i + " x " + n + " = " + i * n);
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};