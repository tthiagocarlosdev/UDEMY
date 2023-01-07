using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1018");
        Console.WriteLine("Cédulas");
        Console.WriteLine("Número inteiro");

        int numero, cedulaCem, cedulaCinquenta, cedulaVinte, cedulaDez, cedulaCinco, cedulaDois, cedulaUm;
        int restoDeCem, restoDeCinquenta, restoDeVinte, restoDeDez, restoDeCinco, restoDeDois, restoDeUm;

        numero = int.Parse(Console.ReadLine());
        cedulaCem = numero / 100;
        restoDeCem = numero % 100;
        cedulaCinquenta = restoDeCem / 50;
        restoDeCinquenta = restoDeCem % 50;
        cedulaVinte = restoDeCinquenta / 20;
        restoDeVinte = restoDeCinquenta % 20;
        cedulaDez = restoDeVinte / 10;
        restoDeDez = restoDeVinte % 10;
        cedulaCinco = restoDeDez / 5;
        restoDeCinco = restoDeDez % 5;
        cedulaDois = restoDeCinco / 2;
        restoDeDois = restoDeCinco % 2;
        cedulaUm = restoDeDois / 1;
        // restoDeUm = restoDeDois % 1;

        Console.WriteLine(numero);
        Console.WriteLine(cedulaCem + " nota(s) de R$ 100,00");
        // Console.WriteLine(restoDeCem);
        Console.WriteLine(cedulaCinquenta + " nota(s) de R$ 50,00");
        // Console.WriteLine(restoDeCinquenta);
        Console.WriteLine(cedulaVinte + " nota(s) de R$ 20,00");
        // Console.WriteLine(restoDeVinte);
        Console.WriteLine(cedulaDez + " nota(s) de R$ 10,00");
        // Console.WriteLine(restoDeDez);
        Console.WriteLine(cedulaCinco + " nota(s) de R$ 5,00");
        // Console.WriteLine(restoDeCinco);
        Console.WriteLine(cedulaDois + " nota(s) de R$ 2,00");
        // Console.WriteLine(restoDeDois);
        Console.WriteLine(cedulaUm + " nota(s) de R$ 1,00");
        // Console.WriteLine(restoDeUm);

      Console.ReadLine();
    }
  }
};