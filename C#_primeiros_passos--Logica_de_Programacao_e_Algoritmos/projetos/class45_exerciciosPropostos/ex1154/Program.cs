using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1154");
        Console.WriteLine("Idades");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int idade = 1, somaIdades = 0;
        double idadeMedia, contador = 0.0;

        while (idade > 0) {
            idade = int.Parse(Console.ReadLine());
            if(idade > 0){
                somaIdades += idade;
                contador++;
            }
        }

        idadeMedia = (double) (somaIdades / contador);

        Console.WriteLine(idadeMedia.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};