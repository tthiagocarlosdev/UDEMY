using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício resolvido 03");
        Console.WriteLine("Menor número");
        Console.WriteLine("Três inteiros");

        int A, B, C, menor;

        string[] v = Console.ReadLine().Split(' ');
        A = int.Parse(v[0]);
        B = int.Parse(v[1]);
        C = int.Parse(v[2]);

        menor = A;

        if ( B < menor ) {
            menor = B;
        } else if ( C < menor ) {
            menor = C;
        };

        Console.WriteLine("MENOR = " + menor);

      Console.ReadLine();
    }
  }
};