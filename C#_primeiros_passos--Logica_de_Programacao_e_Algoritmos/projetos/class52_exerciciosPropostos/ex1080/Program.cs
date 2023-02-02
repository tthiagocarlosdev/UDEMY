using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1080");
        Console.WriteLine("Maior e Posição");
        Console.WriteLine("100 valores/int");
        Console.WriteLine("------------------------");

        int n = 0, maior = 0, posicao = 0;

        for (int i = 0; i < 100; i++) {
            n = int.Parse(Console.ReadLine());
            if ( n > maior) {
                maior = n;
                posicao = i + 1;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};