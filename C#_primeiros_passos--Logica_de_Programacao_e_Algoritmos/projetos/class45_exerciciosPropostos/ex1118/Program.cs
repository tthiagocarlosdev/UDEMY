using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1118");
        Console.WriteLine("Várias Notas Com Validação");
        Console.WriteLine("2 notas/reais");
        Console.WriteLine("------------------------");

        double notaA, notaB, media;
        int X = 1;

        while(X != 2){
            notaA = double.Parse(Console.ReadLine());

            while(notaA < 0.0 || notaA > 10.0){
                Console.WriteLine("nota invalida");
                notaA = double.Parse(Console.ReadLine());
            }

            notaB = double.Parse(Console.ReadLine());

            while(notaB < 0.0 || notaB > 10.0){
                Console.WriteLine("nota invalida");
                notaB = double.Parse(Console.ReadLine());
            }

            media = (notaA + notaB) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            X = int.Parse(Console.ReadLine());

            while( X != 1 && X != 2){
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());
            } 

        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};