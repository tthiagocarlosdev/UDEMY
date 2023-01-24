using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1066");
        Console.WriteLine("Pares, Ímpares, Positivos e Negativos");
        Console.WriteLine("5 valores/int");
        Console.WriteLine("------------------------");

        int A, B, C, D, E, valoresPares = 0, valoresImpares = 0, valoresPositivos = 0, valoresNegativos = 0;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());
        E = int.Parse(Console.ReadLine());

        //determina valores pares
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

        //determina valolores impares
        if(A % 2 != 0){
            valoresImpares++;
        }
        if(B % 2 != 0){
            valoresImpares++;
        }
        if(C % 2 != 0){
            valoresImpares++;
        }
        if(D % 2 != 0){
            valoresImpares++;
        }
        if(E % 2 != 0){
            valoresImpares++;
        }

        //determina valores positivos
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

        //determina valores negativos
        if(A < 0){
            valoresNegativos++;
        }
        if(B < 0){
            valoresNegativos++;
        }
        if(C < 0){
            valoresNegativos++;
        }
        if(D < 0){
            valoresNegativos++;
        }
        if(E < 0){
            valoresNegativos++;
        }

        Console.WriteLine(valoresPares + " valor(es) par(es)");
        Console.WriteLine(valoresImpares + " valor(es) impar(es)");
        Console.WriteLine(valoresPositivos + " valor(es) positivo(s)");
        Console.WriteLine(valoresNegativos + " valor(es) negativo(s)");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};