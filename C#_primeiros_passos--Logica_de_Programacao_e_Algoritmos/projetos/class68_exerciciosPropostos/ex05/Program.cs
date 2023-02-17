using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 68 - Exercícios Propostos");
        Console.WriteLine("ex05");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        string[] linhasColunas = Console.ReadLine().Split(' ');
        int Nlinhas = int.Parse(linhasColunas[0]);
        int Ncolunas = int.Parse(linhasColunas[1]);
        int[,] matrizA = new int[Nlinhas, Ncolunas];
        int[,] matrizB = new int[Nlinhas, Ncolunas];
        int[,] matrizC = new int[Nlinhas, Ncolunas];
        
        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            string[] valor = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                matrizA[linhas, colunas] = int.Parse(valor[colunas]);
            };
        };

        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            string[] valor = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                matrizB[linhas, colunas] = int.Parse(valor[colunas]);
            };
        };

        //processamento e saída de dados
        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                matrizC[linhas, colunas] = matrizA[linhas, colunas] + matrizB[linhas, colunas];
            };
        };

        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                Console.Write(matrizC[linhas, colunas] + " ");
            };
            Console.WriteLine();
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};