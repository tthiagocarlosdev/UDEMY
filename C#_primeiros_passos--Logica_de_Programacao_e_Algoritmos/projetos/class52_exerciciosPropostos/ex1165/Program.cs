using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1165");
        Console.WriteLine("Número Primo");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) {
          int contador = 0;
          int valor = int.Parse(Console.ReadLine());

          for (int j = 1; j <= valor; j++) {
            if ( valor % j == 0 ) {
              contador++;
            };
          };

          if ( contador == 2) {
            Console.WriteLine(valor + " eh primo");
          } else {
            Console.WriteLine(valor + " nao eh primo");
          };    
        };
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};