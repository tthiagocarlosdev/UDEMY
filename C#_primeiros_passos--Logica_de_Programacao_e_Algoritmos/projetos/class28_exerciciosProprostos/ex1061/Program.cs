using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1061");
        Console.WriteLine("Tempo de um Evento");
        Console.WriteLine("Dia e Hora Inicial");

        int diaInicial, horaInicial, minutoInicial, segundoInicial;
        int diaFinal, horaFinal, minutoFinal, segundoFinal;
        int tempoInicial, tempoFinal, duracaoEmSegundos;
        int dias, horas, minutos, segundos, resto;

        string[] v = Console.ReadLine().Split(' ');
        diaInicial = int.Parse(v[1]);

        string[] y = Console.ReadLine().Split(':');
        horaInicial = int.Parse(y[0]);
        minutoInicial = int.Parse(y[1]);
        segundoInicial = int.Parse(y[2]);
        
        string[] x = Console.ReadLine().Split(' ');
        diaFinal = int.Parse(x[1]);

        string[] z = Console.ReadLine().Split(':');
        horaFinal = int.Parse(z[0]);
        minutoFinal = int.Parse(z[1]);
        segundoFinal = int.Parse(z[2]);

        tempoInicial = (diaInicial * 86400) + (horaInicial * 3600) + (minutoInicial * 60) + segundoInicial;
        tempoFinal = (diaFinal * 86400) + (horaFinal * 3600) + (minutoFinal * 60) + segundoFinal;

        duracaoEmSegundos = tempoFinal - tempoInicial;

        dias = duracaoEmSegundos / 86400;
        resto = duracaoEmSegundos % 86400;
        horas = resto / 3600;
        resto = resto % 3600;
        minutos = resto / 60;
        segundos = resto % 60;

        // Console.WriteLine(duracaoEmSegundos);
        Console.WriteLine(dias + " dia(s)");
        Console.WriteLine(horas + " hora(s)");
        Console.WriteLine(minutos + " minuto(s)");
        Console.WriteLine(segundos + " segundo(s)");


      Console.ReadLine();
    }
  }
};