using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1070");
        Console.WriteLine("Seis Números Ímpares");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int valor = int.Parse(Console.ReadLine());

        if (valor % 2 == 0) {
            valor++;
        }

        Console.WriteLine(valor);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
        Console.WriteLine(valor += 2);
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};