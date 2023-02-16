using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 66 - Exercício resolvido 01");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        int n = int.Parse(Console.ReadLine());
        int[,] A = new int[n, n];
        int numerosNegativos = 0;
        
        for (int i = 0; i < n; i++) {
            string[] x = Console.ReadLine().Split(" ");
            for (int j = 0; j < n; j++) {
                A[i, j] = int.Parse(x[j]);
            };
        };

        //processamento e saída de dados
        //diagonal principal
        Console.WriteLine("DIAGONAL PRINCIPAL: ");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i == j) {
                    Console.Write(A[i, j] + " ");
                } else {
                    Console.Write(" " + " ");
                };
            };
            Console.WriteLine();
        };

        //quantidade de número negativos
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if ( A[i,j] < 0) {
                    numerosNegativos++;
                };
            };
        };

        Console.WriteLine("QUIANTIDADE DE NEGATIVOS = " + numerosNegativos);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};