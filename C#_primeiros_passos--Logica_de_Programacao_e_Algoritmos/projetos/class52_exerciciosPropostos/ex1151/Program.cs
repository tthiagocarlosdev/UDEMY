using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1151");
        Console.WriteLine("Sequência Lógica");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, troca = 0;
        string fibonacci = "";

        fibonacci = a + " " + b;

        for(int i = 0; i < n -2; i++) {
            troca = a + b;
            fibonacci += " " + troca;
            a = b;
            b = troca;
        }

        Console.WriteLine(fibonacci);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};