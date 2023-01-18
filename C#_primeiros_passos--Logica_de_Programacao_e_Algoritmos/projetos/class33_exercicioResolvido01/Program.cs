using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();

        Console.WriteLine("Exercício resolvido");

        double nota1, nota2, notaFinal;
        
        Console.WriteLine("Digite a 1ª nota");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a 2ª nota");
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        notaFinal = nota1 + nota2;

        Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

        if ( notaFinal < 60.0 ) {
            Console.WriteLine("REPROVADO");
        }
        
      Console.ReadLine();
    }
  }
};