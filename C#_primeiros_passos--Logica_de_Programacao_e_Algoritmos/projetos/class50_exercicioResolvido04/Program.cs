using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        // Console.Clear();
        Console.WriteLine("ex1071");
        Console.WriteLine("Soma de Impares Consecutivos I");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x, y, somaImpares = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if(x < y){
            for(int i = x; i < y; i++){
                if(i % 2 != 0){
                    somaImpares += i;
                    Console.WriteLine("i: "+ i);
                    Console.WriteLine("soma: "+ somaImpares);
                }
            }
        } else if(x > y){
            for(int i = x; i > y; i--){
                if(i % 2 != 0){
                    somaImpares += i;
                    Console.WriteLine("i: "+ i);
                    Console.WriteLine("soma: "+ somaImpares);
                }
            }
        }

        Console.WriteLine(somaImpares);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};