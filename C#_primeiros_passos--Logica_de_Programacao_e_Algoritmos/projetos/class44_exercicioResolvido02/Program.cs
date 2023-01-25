using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("class44_exercicioResolvido02");
        // Console.WriteLine("Crescente e Decrescente");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        double idade, somaIdades = 0.0, contador = 0.0, mediaIdades = 0.0;

        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(idade < 0.0){
            Console.WriteLine("impossivel calcular");
        } else {
            while (idade > 0.0) {
                somaIdades += idade;
                contador++;
                idade = double.Parse(Console.ReadLine());
            }

            mediaIdades = somaIdades / contador;

            Console.WriteLine(mediaIdades.ToString("F2", CultureInfo.InvariantCulture));
        }
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};