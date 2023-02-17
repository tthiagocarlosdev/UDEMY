using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 67 - Exercício resolvido 02");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        string[] linhaColunas = Console.ReadLine().Split(' ');
        int m = int.Parse(linhaColunas[0]);
        int n = int.Parse(linhaColunas[1]);
        int[,] A = new int[n, n];
        int[] vetor = new int[m];
        
        for (int linhas = 0; linhas < m; linhas++) {
            string[] x = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < n; colunas++) {
                A[linhas, colunas] = int.Parse(x[colunas]);
            };
        };

        //processamento de dados
        for (int linhas = 0; linhas < m; linhas++) {
            int soma = 0;
            for (int colunas = 0; colunas < n; colunas++) {
                soma += A[linhas, colunas];
            };
            vetor[linhas] = soma;
        };

        // saída de dados - mostrar vetor
        for (int i = 0; i < m; i++) {
            Console.WriteLine(vetor[i]);
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};