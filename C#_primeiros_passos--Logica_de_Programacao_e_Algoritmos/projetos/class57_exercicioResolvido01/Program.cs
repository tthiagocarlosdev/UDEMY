using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 57 - Vetores");
        Console.WriteLine("Exercício resolvido 01");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = 0;
        int[] vet;

        n = int.Parse(Console.ReadLine());
        vet = new int[n];

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++) {
            vet[i] = int.Parse(s[i]);
        };

        for (int i = 0; i < n; i++) {
            if ( vet[i] < 0) {
                Console.WriteLine(vet[i]);
            };
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};