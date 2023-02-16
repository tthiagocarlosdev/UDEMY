using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 68 - Exercícios Propostos");
        Console.WriteLine("ex03");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        int ordemDaMatriz = int.Parse(Console.ReadLine());
        int[,] matriz = new int[ordemDaMatriz, ordemDaMatriz];
        
        for (int linhas = 0; linhas < ordemDaMatriz; linhas++) {
            string[] valor = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < ordemDaMatriz; colunas++) {
                matriz[linhas, colunas] = int.Parse(valor[colunas]);
            };
        };

        //processamento e saída de dados
        for (int linhas = 0; linhas < ordemDaMatriz; linhas++) {
            int maiorElemento = 0;
            for (int colunas = 0; colunas < ordemDaMatriz; colunas++) {
                if ( matriz[linhas, colunas] > maiorElemento) {
                    maiorElemento = matriz[linhas, colunas];
                };
            };
            Console.WriteLine(maiorElemento);
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};