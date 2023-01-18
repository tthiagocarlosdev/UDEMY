using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Operadores de atribuição cumulativa");
        Console.WriteLine("Número inteiro");

        int minutos;
        double valorFinal = 50.0;
        
        minutos = int.Parse(Console.ReadLine());

        if ( minutos  > 100 ) {
            valorFinal += ((minutos - 100) * 2);
        };

        Console.WriteLine("Valor a pargar: " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
  }
};