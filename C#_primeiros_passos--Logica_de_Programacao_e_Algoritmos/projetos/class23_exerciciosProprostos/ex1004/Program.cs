using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int A, B, PROD;

      A = int.Parse(Console.ReadLine());
      B = int.Parse(Console.ReadLine());

      PROD = A * B;

      Console.WriteLine("PROD = " + PROD);

      Console.ReadLine();
    }
  }
}