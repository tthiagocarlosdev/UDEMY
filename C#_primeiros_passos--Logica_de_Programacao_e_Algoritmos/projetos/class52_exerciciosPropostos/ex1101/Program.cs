using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1101");
        Console.WriteLine("Sequência de Números e Soma");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int m = 1, n = 1, soma = 0;

        do {
            
            string[] v = Console.ReadLine().Split(' ');
            if ( int.Parse(v[0]) > int.Parse(v[1]) ) {
                m = int.Parse(v[1]);
                n = int.Parse(v[0]);
            } else {
                m = int.Parse(v[0]);
                n = int.Parse(v[1]);
            };

            if ( m > 0 && n > 0 ) {

                for ( int i = m; i <= n; i++ ) {
                    Console.Write(i + " ");
                    soma += i;
                };

                Console.WriteLine("Sum=" + soma);
                soma = 0;
            };

        } while ( m > 0 && n > 0 );

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};