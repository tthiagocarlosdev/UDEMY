using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1067");
        Console.WriteLine("Números Ímpares");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++) {
          if(i % 2 != 0){
            Console.WriteLine(i);
          }
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};