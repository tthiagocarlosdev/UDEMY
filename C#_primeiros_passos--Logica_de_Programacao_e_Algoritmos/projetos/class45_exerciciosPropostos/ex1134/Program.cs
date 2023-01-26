using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1134");
        Console.WriteLine("Tipo de Combustível");
        Console.WriteLine("1 Valor/int");
        Console.WriteLine("------------------------");

        int alcool = 0, gasolina = 0, diesel = 0, combustivel = 0;

        while (combustivel != 4) {

            combustivel = int.Parse(Console.ReadLine());

            while ( combustivel < 1 || combustivel > 4) {
                combustivel = int.Parse(Console.ReadLine());
            }

            if ( combustivel == 1 ) {
                alcool++;
            } else if( combustivel == 2) {
                gasolina++;
            } else if ( combustivel == 3) {
                diesel++;
            }
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};