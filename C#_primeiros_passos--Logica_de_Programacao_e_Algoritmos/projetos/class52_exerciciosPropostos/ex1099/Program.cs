using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1099");
        Console.WriteLine("Soma de Ímpares Consecutivos II");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        int x, y, maior, menor, somaImpares = 0;
        
        for ( int i = 0; i < n; i++ ) {

            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);
            
            if ( x < y) {
                maior = y;
                menor = x;
            } else {
                maior = x;
                menor = y;
            };

            for ( int j = menor + 1; j < maior; j++ ) {
                if ( j % 2 != 0) {
                    somaImpares += j;
                };

            };

            Console.WriteLine(somaImpares);
            somaImpares = 0;    
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};