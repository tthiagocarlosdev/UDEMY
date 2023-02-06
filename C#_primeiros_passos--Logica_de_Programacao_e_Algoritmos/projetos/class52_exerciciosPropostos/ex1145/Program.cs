using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1145");
        Console.WriteLine("Sequência Lógica 2");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x, y, contador = 1;
        string[] v = Console.ReadLine().Split(' ');
        x = int.Parse(v[0]);
        y = int.Parse(v[1]);

        while ( contador <= y ) {
            for (int i = 1; i <= x; i++) {
                if ( i < x ) {
                    Console.Write(contador + " ");
                } else {
                    Console.WriteLine(contador);
                };
                contador++;
            };
        };
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};