using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1132");
        Console.WriteLine("Múltiplos de 13");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x, y, soma = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if(x < y){
            for(int i = x; i <= y; i++) {
                if(i % 13 != 0){
                    soma += i;
                }
            }
        } else {
            for(int i = y; i <= x; i++) {
                if(i % 13 != 0){
                    soma += i;
                }
            }
        }
        
        Console.WriteLine(soma);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};