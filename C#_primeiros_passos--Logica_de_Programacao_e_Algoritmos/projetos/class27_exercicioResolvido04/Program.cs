using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1019");
        Console.WriteLine("Conversão de Tempo");
        Console.WriteLine("Segundos");

        int tempoEmsegundos, horasInt, minutosInt, segundos;
        double horas, minutos;

        tempoEmsegundos = int.Parse(Console.ReadLine());

        // horas = (double) tempoEmsegundos / 3600;
        horasInt = tempoEmsegundos / 3600;
        minutos = ((tempoEmsegundos / 3600) / 60);
        // minutosInt = ((horas - horasInt) * 60);

        Console.WriteLine(tempoEmsegundos % 3600);
        // Console.WriteLine(horas);
        Console.WriteLine(horasInt);
        Console.WriteLine(minutos);
        // Console.WriteLine(minutosInt);

      Console.ReadLine();
    }
  }
};