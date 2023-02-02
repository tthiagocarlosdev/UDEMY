using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1075");
        Console.WriteLine("Resto 2");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10000; i++) {
          if(i % n == 2){
            Console.WriteLine(i);
          }
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};