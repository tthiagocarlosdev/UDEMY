using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 68 - Exercícios Propostos");
        Console.WriteLine("ex07");
        Console.WriteLine("------------------------");

        // declaração de variáveis e entrada de dados
        int Nlinhas = int.Parse(Console.ReadLine());
        int Ncolunas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[Nlinhas, Ncolunas];
        int[,] matrizGirarFila = new int[Nlinhas, Ncolunas];
        
        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            string[] valor = Console.ReadLine().Split(" ");
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                matriz[linhas, colunas] = int.Parse(valor[colunas]);
            };
        };

        int fila = int.Parse(Console.ReadLine());

        //processamento e saída de dados
        //calculo da matriz girar fila
        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                if ( linhas == fila - 1 ) {
                    if ( colunas != 0 ) {
                        matrizGirarFila[linhas, colunas ] = matriz[linhas, colunas - 1];
                    } else {
                        matrizGirarFila[linhas, colunas] = matriz[linhas, Ncolunas - 1];
                    };
                } else {
                    matrizGirarFila[linhas, colunas] = matriz[linhas, colunas];
                };
                
            };
        };
        
        //mostrar matriz girar fila
        for (int linhas = 0; linhas < Nlinhas; linhas++) {
            for (int colunas = 0; colunas < Ncolunas; colunas++) {
                Console.Write(matrizGirarFila[linhas, colunas] + " " );
            };
            Console.WriteLine();
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};