using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 68 - Exercícios Propostos");
        Console.WriteLine("ex01");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        string[] linhaColunas = Console.ReadLine().Split(' ');
        int mLinhas = int.Parse(linhaColunas[0]);
        int nColunas = int.Parse(linhaColunas[1]);
        int[,] matriz = new int[nColunas, nColunas];
        
        for (int linhas = 0; linhas < mLinhas; linhas++) {
            string[] valor = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < nColunas; colunas++) {
                matriz[linhas, colunas] = int.Parse(valor[colunas]);
            };
        };

        //processamento e saída de dados
        Console.WriteLine("VALORES NEGATIVOS:");
        for (int linhas = 0; linhas < mLinhas; linhas++) {
            for (int colunas = 0; colunas < nColunas; colunas++) {
                if ( matriz[linhas, colunas] < 0 ) {
                    Console.WriteLine(matriz[linhas, colunas]);
                };
            };
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};