using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();

        Console.WriteLine("Condicional Simples");

        int x = 5;
        
        Console.WriteLine("Bom dia");

        if ( x < 5 ) {
            Console.WriteLine("Boa tarde");
        }
        
        Console.WriteLine("Boa noite");
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Condicional Composta");

        int horas;

        Console.WriteLine("Quantas horas? ");
        horas = int.Parse(Console.ReadLine());

        if ( horas < 12 ){
            Console.WriteLine("Bom dia!");
        }
        else {
            Console.WriteLine("Boa tarde!");
        }

         Console.WriteLine("-----------------------------");

        Console.WriteLine("Encademamento de estruturas condicionais");

        int hora;

        Console.WriteLine("Quantas horas? ");
        hora = int.Parse(Console.ReadLine());

        if ( hora < 12 ){
            Console.WriteLine("Bom dia!");
        }
        else {
            if ( hora < 18 ) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }


      Console.ReadLine();
    }
  }
};