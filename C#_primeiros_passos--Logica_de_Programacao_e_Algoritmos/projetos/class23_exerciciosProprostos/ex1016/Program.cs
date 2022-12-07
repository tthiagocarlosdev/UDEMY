using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1016");
      Console.WriteLine("km");

      int distancia, tempo;

      distancia = int.Parse(Console.ReadLine());

      tempo = distancia * 2;

      Console.WriteLine(tempo + " minutos");

      Console.ReadLine();
    }
  }
};