using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("class40_estruturaRepetitivaEnquanto");
        Console.WriteLine("Estrutura repetitiva enquanto");
        Console.WriteLine("5 valores/int");
        Console.WriteLine("------------------------");

        int numero = 1, somaValores = 0;

        while(numero != 0){
            numero = int.Parse(Console.ReadLine());
            somaValores += numero;
        }

        Console.WriteLine(somaValores);
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};