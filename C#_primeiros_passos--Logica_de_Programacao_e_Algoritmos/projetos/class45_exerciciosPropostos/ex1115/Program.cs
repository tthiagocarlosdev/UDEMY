using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1115");
        Console.WriteLine("Quadrante");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int x = 1, y = 1;

        while(x != 0 && y != 0){
            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);

            if(x > 0 && y > 0){
                Console.WriteLine("primeiro");
            } else if(x < 0 && y > 0){
                Console.WriteLine("segundo");
            } else if(x < 0 && y < 0){
                Console.WriteLine("terceiro");
            } else if(x > 0 && y < 0){
                Console.WriteLine("quarto");
            }
        }
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};