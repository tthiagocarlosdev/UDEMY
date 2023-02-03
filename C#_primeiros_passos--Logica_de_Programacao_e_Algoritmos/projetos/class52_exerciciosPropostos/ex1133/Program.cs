using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1133");
        Console.WriteLine("Resto da Divisão");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x, y;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if(x < y){
            for(int i = x+1; i < y; i++) {
                if(i % 5 == 2 || i % 5 == 3) {
                    Console.WriteLine(i);
                }
            }
        } else {
            for(int i = y+1; i < x; i++) {
                if(i % 5 == 2 || i % 5 == 3){
                    Console.WriteLine(i);
                }
            }
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};