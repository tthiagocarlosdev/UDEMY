using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1144");
        Console.WriteLine("Sequência Lógica");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        int c = 1, potencia = 2;

        for (int i = 0; i < n; i++) {
            for(int j = 0; j < 3; j++) {
                if(j < 2){
                    Console.Write(Math.Pow(c, potencia) + " ");
                } else {
                    Console.WriteLine(Math.Pow(c, potencia));
                }
                potencia++;
            };
            potencia = 1;
            
            for(int j = 0; j < 3; j++) {
                if(j != 0){
                    Console.Write(" " + (Math.Pow(c, potencia) + 1));
                } else {
                    Console.Write(Math.Pow(c, potencia));
                }
                potencia++;
            };
            Console.WriteLine();
            potencia = 1;

            c++;
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};