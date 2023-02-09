using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 54 - Vetores");
        Console.WriteLine("Problema exemplo");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = 0;
        double[] vet;

        n = int.Parse(Console.ReadLine());
        vet = new double[n];

        for (int i = 0; i < n; i++) {
            vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        };

        for (int i = 0; i < n; i++) {
            Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};