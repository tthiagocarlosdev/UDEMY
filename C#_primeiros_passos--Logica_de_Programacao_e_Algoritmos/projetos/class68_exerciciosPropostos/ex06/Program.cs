using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 68 - Exercícios Propostos");
        Console.WriteLine("ex06");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        int NlinhasColunas = int.Parse(Console.ReadLine());
        double[,] matriz = new double[NlinhasColunas, NlinhasColunas];
        double[,] matrizExponencial = new double[NlinhasColunas, NlinhasColunas];
        double[] elementosDaLinhaEscolhida = new double[NlinhasColunas];
        double[] elementosDaColunaEscolhida = new double[NlinhasColunas];
        
        for (int linhas = 0; linhas < NlinhasColunas; linhas++) {
            string[] valor = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < NlinhasColunas; colunas++) {
                matriz[linhas, colunas] = double.Parse(valor[colunas], CultureInfo.InvariantCulture);
            };
        };

        int linhaEscolhida = int.Parse(Console.ReadLine());
        int colunaEscolhida = int.Parse(Console.ReadLine());
        double somaDosPositivos = 0.0;

        //processamento e saída de dados
        //cálculo da soma dos positivos
        for (int linhas = 0; linhas < NlinhasColunas; linhas++) {
            for (int colunas = 0; colunas < NlinhasColunas; colunas++) {
                if ( matriz[linhas, colunas] > 0.0 ) {
                    somaDosPositivos += matriz[linhas, colunas];
                };
            };
        };

        //mostrar elementos da linha escolhida
        for (int colunas = 0; colunas < NlinhasColunas; colunas++) {
            elementosDaLinhaEscolhida[colunas] = matriz[linhaEscolhida, colunas];
        };

        //elementos da coluna escolhida
        for (int linhas = 0; linhas < NlinhasColunas; linhas++) {
            elementosDaColunaEscolhida[linhas] = matriz[linhas, colunaEscolhida];
        };

        //calculo da matriz alterada
        for (int linhas = 0; linhas < NlinhasColunas; linhas++) {
            for (int colunas = 0; colunas < NlinhasColunas; colunas++) {
                if ( matriz[linhas, colunas] < 0.0 ) {
                    matrizExponencial[linhas, colunas] = Math.Pow(matriz[linhas, colunas], 2);
                } else {
                    matrizExponencial[linhas, colunas] = matriz[linhas, colunas];
                };
                
            };
        };
        
        Console.WriteLine("SOMA DOS POSITIVOS: " + somaDosPositivos.ToString("F1", CultureInfo.InvariantCulture));
        Console.Write("LINHA ESCOLHIDA: ");
        for (int indice = 0; indice < NlinhasColunas; indice++) {
            Console.Write( elementosDaLinhaEscolhida[indice].ToString("F1", CultureInfo.InvariantCulture) + " ");
        };
        Console.WriteLine();

        //mostrar elementos da coluna escolhida
        Console.Write("COLUNA ESCOLHIDA: ");
        for (int indice = 0; indice < NlinhasColunas; indice++) {
            Console.Write( elementosDaColunaEscolhida[indice].ToString("F1", CultureInfo.InvariantCulture) + " ");
        };
        Console.WriteLine();

        //mostrar diagonal principal
        Console.Write("DIAGONAL PRINCIPAL: ");
        for (int linhas = 0; linhas < NlinhasColunas; linhas++) {
            for (int colunas = 0; colunas < NlinhasColunas; colunas++) {
                if ( linhas == colunas ) {
                    Console.Write( matriz[linhas, colunas].ToString( "F1", CultureInfo.InvariantCulture ) + " " );
                };
            };
        };
        Console.WriteLine();

        //matriz alterada
        Console.WriteLine("MATRIZ ALTERADA: ");
        for (int linhas = 0; linhas < NlinhasColunas; linhas++) {
            for (int colunas = 0; colunas < NlinhasColunas; colunas++) {
                Console.Write(matrizExponencial[linhas, colunas].ToString( "F1", CultureInfo.InvariantCulture ) + " " );
            };
            Console.WriteLine();
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};