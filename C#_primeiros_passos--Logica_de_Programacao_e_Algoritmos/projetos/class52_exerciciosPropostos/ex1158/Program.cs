using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1058");
        Console.WriteLine("Soma de Ímpares Consecutivos III");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());

        for ( int i = 0; i < n; i++ ) {
            int somaImpares = 0, contador = 0;
            string[] v = Console.ReadLine().Split(' ');
            int x = int.Parse(v[0]);
            int y = int.Parse(v[1]);

            while ( contador < y ) {
                if ( x % 2 != 0 ) {
                    somaImpares += x;
                    contador++;
                };
                x++;
            };

            Console.WriteLine(somaImpares);
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};