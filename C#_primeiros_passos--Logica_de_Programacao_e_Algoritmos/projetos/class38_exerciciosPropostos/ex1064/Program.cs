using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1064");
        Console.WriteLine("Positivos e Média");
        Console.WriteLine("6 valores/int");
        Console.WriteLine("------------------------");

        int valoresPositivos = 0;
        double A, B, C, D, E, F, somaDosValoresPositivos = 0, mediaDosValoresPositivos = 0;

        A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        E = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        F = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(A > 0){
            valoresPositivos++;
            somaDosValoresPositivos += A;
        }
        if(B > 0){
            valoresPositivos++;
            somaDosValoresPositivos += B;
        }
        if(C > 0){
            valoresPositivos++;
            somaDosValoresPositivos += C;
        }
        if(D > 0){
            valoresPositivos++;
            somaDosValoresPositivos += D;
        }
        if(E > 0){
            valoresPositivos++;
            somaDosValoresPositivos += E;
        }
        if(F > 0){
            valoresPositivos++;
            somaDosValoresPositivos += F;
        }

        mediaDosValoresPositivos = somaDosValoresPositivos / valoresPositivos;

        Console.WriteLine(valoresPositivos + " valores positivos");
        Console.WriteLine(mediaDosValoresPositivos.ToString("F1", CultureInfo.InvariantCulture));
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};