using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("class46_estruturaRepetitivaPara");
        // Console.WriteLine("Grenais");
        // Console.WriteLine("gols/int");
        Console.WriteLine("------------------------");

        int soma = 0;
        int N = int.Parse(Console.ReadLine());

        for(int contador = 0; contador < N; contador++){
            int x = int.Parse(Console.ReadLine());
            soma += x;
        }

        Console.WriteLine(soma);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};