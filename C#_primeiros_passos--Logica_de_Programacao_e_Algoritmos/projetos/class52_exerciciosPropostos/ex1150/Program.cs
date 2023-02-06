using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1050");
        Console.WriteLine("Ultrapassando Z");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x = int.Parse(Console.ReadLine());
        int z = 0, soma = 0, quantidadeDeNumeros = 0;
        
        while ( x >= z ) {
            z = int.Parse(Console.ReadLine());
        };

        while (soma < z) {
            soma += x;
            x++;
            quantidadeDeNumeros++;
        }

        Console.WriteLine(quantidadeDeNumeros);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};