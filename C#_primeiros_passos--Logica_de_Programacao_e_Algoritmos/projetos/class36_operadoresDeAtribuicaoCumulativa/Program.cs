using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Operadores de atribuição cumulativa");
        Console.WriteLine("Número inteiro");

        int minutos, valorFinal;

        
        minutos = int.Parse(Console.ReadLine());

        if ( minutos  <= 100 ) {
            valorFinal = 50;
        } else {
            valorFinal = 50 + ((100 - minutos) * 2);
        };
        Console.WriteLine("Valor a pargar: " + valorFinal + ".00");

      Console.ReadLine();
    }
  }
};