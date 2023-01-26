using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1159");
        Console.WriteLine("Soma de Pares Consecutivos");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int x, somaPares = 0;

        x = int.Parse(Console.ReadLine());

        while ( x != 0 ) {

            if ( x % 2 == 0 ) {
                int contador = 5;
                while(contador > 0){
                    somaPares += x;
                    x += 2;
                    contador--;
                }
                Console.WriteLine(somaPares);
                somaPares = 0;
            } else if ( x % 2 == 1 ) {
                x += 1;
                int contador = 5;
                while(contador > 0){
                    somaPares += x;
                    x += 2;
                    contador--;
                }
                Console.WriteLine(somaPares);
                somaPares = 0;
            }

            x = int.Parse(Console.ReadLine());
            
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};