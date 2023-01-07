using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1020");
        Console.WriteLine("Idade em Dias");
        Console.WriteLine("Número inteiro");

        int quantidadeDeDias, anos, meses, dias, resto;

        quantidadeDeDias = int.Parse(Console.ReadLine());

        anos = quantidadeDeDias / 365;
        meses = (quantidadeDeDias % 365) / 30;
        dias = (quantidadeDeDias % 365) % 30;
        
        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");

      Console.ReadLine();
    }
  }
};