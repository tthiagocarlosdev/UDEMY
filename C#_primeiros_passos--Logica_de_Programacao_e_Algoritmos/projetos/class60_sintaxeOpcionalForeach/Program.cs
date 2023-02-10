using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 60 - Sintaxe opcional: foreach");
        Console.WriteLine("Problema exemplo");
        // Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = int.Parse(Console.ReadLine());
        string[] nomes = new string[n];

        //entrada de dados
        for (int i = 0; i < n; i++) {
            nomes[i] = Console.ReadLine();
        };

        // saída de dados
        Console.WriteLine("Nomes lidos:");
        foreach (string elemento in nomes) {
            Console.WriteLine(elemento);
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};