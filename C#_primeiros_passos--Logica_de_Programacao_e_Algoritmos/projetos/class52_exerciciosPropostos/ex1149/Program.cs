using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1149");
        Console.WriteLine("Somando Inteiros Consecutivos");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int a, n, j = 1, soma = 0;

        string[] v = Console.ReadLine().Split(' ');
        a = int.Parse(v[0]);
        n = int.Parse(v[j]);
        while (n <= 0) {
            j++;
            n = int.Parse(v[j]);
        }

        for ( int i = 0; i < n; i++ ) {
            soma += a + i;
        };

        Console.WriteLine(soma);
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};