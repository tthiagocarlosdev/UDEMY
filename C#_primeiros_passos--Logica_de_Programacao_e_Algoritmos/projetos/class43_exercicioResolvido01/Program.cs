using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1113");
        Console.WriteLine("Crescente e Decrescente");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x = 0, y = 1;
        
        while(x != y){

            string[] v = Console.ReadLine().Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);

            if(x > y){
                Console.WriteLine("Decrescente");
            } else if (x < y){
                Console.WriteLine("Crescente");
            }
        }
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};