using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1071");
        Console.WriteLine("Soma de Impares Consecutivos I");
        Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        int x, y, somaImpares = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if(x < y){
            for(int i = x; i < y; i++){
                if(i % 2 != 0){
                    somaImpares += i;
                }
            }
        } else if(x > y){
            for(int i = x - 1; i > y; i--){
                if(i % 2 != 0){
                    somaImpares += i;
                }
            }
        }

        Console.WriteLine(somaImpares);

        // Resolução do professor
        /*int x, y, min, max, soma;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if(x < y){
            min = x;
            max = y;
        } else {
            min = y;
            max = x;
        }

        soma = 0;
        for(int i = min + 1; i < max; i++){
            if(i % 2 != 0){
                soma = soma + i;
            }
        }
        Console.WriteLine(soma);*/

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};