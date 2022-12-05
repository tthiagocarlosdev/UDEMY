using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      double A, B, C, D, diferenca;

      Console.Clear();

      A = int.Parse(Console.ReadLine());
      B = int.Parse(Console.ReadLine());
      C = int.Parse(Console.ReadLine());
      D = int.Parse(Console.ReadLine());

      diferenca = (A * B - C * D);

      Console.WriteLine("DIFERENCA = " + diferenca);

      Console.ReadLine();
    }
  }
}