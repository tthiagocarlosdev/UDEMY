using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1021");
        Console.WriteLine("Notas e Moedas");
        Console.WriteLine("Valor em real");

        double numero;
        int quociente, dividendo, divisor,resto;

        numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        dividendo = (int)(numero * 100.0 + 0.5);

        Console.WriteLine("NOTAS:");

        
        divisor = 100;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 50;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 20;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 10;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 5;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        divisor = 2;
        dividendo = resto;
        quociente = (dividendo / (divisor * 100));
        resto = dividendo % (divisor * 100);
        Console.WriteLine(quociente + " nota(s) de R$ "+ divisor + ".00");

        Console.WriteLine("MOEDAS:");

        divisor = 100;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 1.00");

        divisor = 50;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.50");

        divisor = 25;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.25");

        divisor = 10;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.10");

        divisor = 5;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.05");

        divisor = 1;
        dividendo = resto;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        Console.WriteLine(quociente + " moeda(s) de R$ 0.01");

      Console.ReadLine();
    }
  }
};