using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1017");
      Console.WriteLine("Tempo/Velocidade");

      int tempo, velocidadeMedia, distancia;
      double litros;

      tempo = int.Parse(Console.ReadLine());
      velocidadeMedia = int.Parse(Console.ReadLine());

      distancia = velocidadeMedia * tempo;

      litros = (double) distancia / 12;

      Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

      
      Console.ReadLine();
    }
  }
};