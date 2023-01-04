using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1019");
        Console.WriteLine("Conversão de Tempo");
        Console.WriteLine("Segundos");

        int tempoEmSegundos, horas, minutos, segundos, resto;

        tempoEmSegundos = int.Parse(Console.ReadLine());

        horas = tempoEmSegundos / 3600;
        resto = tempoEmSegundos % 3600;
        minutos = resto / 60;
        segundos = resto % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        

      Console.ReadLine();
    }
  }
};