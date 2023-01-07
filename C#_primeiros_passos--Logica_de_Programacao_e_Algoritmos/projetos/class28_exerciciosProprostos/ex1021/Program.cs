using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1021");
        Console.WriteLine("Notas e Moedas");
        Console.WriteLine("Valor em real");

        double numero, valor, resto;
        double notas;
        // cedulaCem, cedulaCinquenta, cedulaVinte, cedulaDez, cedulaCinco, cedulaDois, cedulaUm;
        // int restoDeCem, restoDeCinquenta, restoDeVinte, restoDeDez, restoDeCinco, restoDeDois, restoDeUm;

        numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(numero);
        Console.WriteLine("NOTAS:");

        valor = 100.00;
        notas = (numero / 100) / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ valor.ToString("F2", CultureInfo.InvariantCulture));
        resto = numero % valor;
        // Console.WriteLine(resto);
        /*
        valor = 5000;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 2000;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 1000;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 500;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 200;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        Console.WriteLine("MOEDAS:");

        valor = 100;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " moeda(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 50;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " moeda(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 25;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " moeda(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 10;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " moeda(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 5;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " moeda(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);

        valor = 1;
        notas = (int) resto / valor;
        Console.WriteLine(notas + " nota(s) de R$ "+ (valor / 100).ToString("F2", CultureInfo.InvariantCulture));
        resto = (int) resto % valor;
        // Console.WriteLine(resto);
  */      
      Console.ReadLine();
    }
  }
};