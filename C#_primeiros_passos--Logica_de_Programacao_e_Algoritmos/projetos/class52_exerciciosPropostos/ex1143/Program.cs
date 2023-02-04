using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1143");
        Console.WriteLine("Quadrado e ao Cubo");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        int c = 1, potencia = 2;

        for (int i = 0; i < n; i++) {
            for(int j = 0; j < 3; j++) {
                Console.Write(Math.Pow(c, potencia));
                if(j < 2){
                    Console.Write(" ");
                }
                potencia++;
            };
            Console.WriteLine();
            potencia = 1;
            c++;
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};