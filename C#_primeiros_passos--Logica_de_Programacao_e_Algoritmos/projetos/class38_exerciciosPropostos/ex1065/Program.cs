using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1065");
        Console.WriteLine("Pares entre Cinco Números");
        Console.WriteLine("5 valores/int");
        Console.WriteLine("------------------------");

        int A, B, C, D, E, valoresPares = 0;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        E = int.Parse(Console.ReadLine());

        if(A % 2 == 0){
            valoresPares++;
        }
        if(B % 2 == 0){
            valoresPares++;
        }
        if(C % 2 == 0){
            valoresPares++;
        }
        if(D % 2 == 0){
            valoresPares++;
        }
        if(E % 2 == 0){
            valoresPares++;
        }

        Console.WriteLine(valoresPares + " valores pares");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};