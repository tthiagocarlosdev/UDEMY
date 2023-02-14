using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 63 - Matrizes");
        Console.WriteLine("Problema exemplo");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        string[] v = Console.ReadLine().Split(" ");
        int m = int.Parse(v[0]);
        int n = int.Parse(v[1]);
        int[,] A = new int[m, n];
        
        //entrada de dados
        for (int i = 0; i < m; i++) {
            string[] x = Console.ReadLine().Split(" ");
            for (int j = 0; j < n; j++) {
                A[i, j] = int.Parse(x[j]);
            };
        };

        //processamento e saída de dados
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write(A[i, j] + " ");
            };
            Console.WriteLine();
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};