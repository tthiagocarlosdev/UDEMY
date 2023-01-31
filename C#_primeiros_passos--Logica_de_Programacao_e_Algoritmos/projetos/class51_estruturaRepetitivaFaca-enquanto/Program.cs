using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 51 - Estrutura repetitiva faça-enquanto");
        // Console.WriteLine("Soma de Impares Consecutivos I");
        // Console.WriteLine("2 valores/int");
        Console.WriteLine("------------------------");

        double temperaturaCelsius, temperaturaFahrenheit;
        char repetir;

        do {
            Console.Write("Digite a temperatura em Celsius: ");
            temperaturaCelsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            temperaturaFahrenheit = ((9.0 * temperaturaCelsius) / 5.0) + 32.0;

            Console.WriteLine("Equivalente em Fahrenheit: " + temperaturaFahrenheit.ToString("F1", CultureInfo.InvariantCulture));

            Console.Write("Deseja repetir (s/n)? ");
            repetir = char.Parse(Console.ReadLine());
        } while (repetir == 's');

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};