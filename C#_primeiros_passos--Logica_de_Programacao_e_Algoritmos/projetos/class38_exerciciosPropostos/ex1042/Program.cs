using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1042");
        Console.WriteLine("Sort Simples");
        Console.WriteLine("3 Valores/int");
        Console.WriteLine("------------------------");

        int A, B, C, troca;
        string[] v = Console.ReadLine().Split();
        A = int.Parse(v[0]);
        B = int.Parse(v[1]);
        C = int.Parse(v[2]);

        if(B < A){
            troca = A;
            A = B;
            B = troca;
        }
        if(C < A){
            troca = A;
            A = C;
            C = troca;
        }
        if(C < B){
            troca = B;
            B = C;
            C = troca;
        }
        
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
        Console.WriteLine();
        Console.WriteLine(v[0]);
        Console.WriteLine(v[1]);
        Console.WriteLine(v[2]);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
