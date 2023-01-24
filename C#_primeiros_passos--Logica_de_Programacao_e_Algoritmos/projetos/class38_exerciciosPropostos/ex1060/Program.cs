using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1060");
        Console.WriteLine("Números Positivos");
        Console.WriteLine("6 valores/int");
        Console.WriteLine("------------------------");

        int valoresPositivos = 0;
        double A, B, C, D, E, F;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(A > 0){
            valoresPositivos++;
        }
        if(B > 0){
            valoresPositivos++;
        }
        if(C > 0){
            valoresPositivos++;
        }
        if(D > 0){
            valoresPositivos++;
        }
        if(E > 0){
            valoresPositivos++;
        }
        if(F > 0){
            valoresPositivos++;
        }

        Console.WriteLine(valoresPositivos + " valores positivos");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};