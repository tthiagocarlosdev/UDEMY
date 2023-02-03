using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1096");
        Console.WriteLine("Sequencia IJ 3");
        // Console.WriteLine("");
        Console.WriteLine("------------------------");

        int contador = 7;
        for (int i = 1; i <= 9; i +=2) {
            for (int j = contador; j >= (contador - 2); j--) {
                Console.WriteLine("I="+ i + " J="+ j);
            }
            contador += 2;
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};