using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1044");
        Console.WriteLine("Múltiplos");
        Console.WriteLine("A/B inteiro");

        int A, B, resto, menor, maior;

        string[] valores = Console.ReadLine().Split(' ');
        A = int.Parse(valores[0]);
        B = int.Parse(valores[1]);
        menor = A;
        maior = B;

        if(menor > B){
            menor = B;
            maior = A;
        }
            
        if(maior % menor == 0){ 
            Console.WriteLine("Sao Multiplos");
        } else {
            Console.WriteLine("Nao sao Multiplos");
        }

        Console.ReadLine();
    }
  }
};