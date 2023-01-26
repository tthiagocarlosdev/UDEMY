using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1117");
        Console.WriteLine("Validação de Nota");
        Console.WriteLine("2 Valores/double");
        Console.WriteLine("------------------------");

        double notaA, notaB, media;

        notaA = double.Parse(Console.ReadLine());

        while(notaA < 0.0 || notaA > 10.0) {
            Console.WriteLine("nota invalida");
            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        notaB = double.Parse(Console.ReadLine());

        while(notaB < 0.0 || notaB > 10.0) {
            Console.WriteLine("nota invalida");
            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        media = ((notaA + notaB) / 2);

        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};