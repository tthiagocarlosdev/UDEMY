using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex02");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        int totalDeNumerosPares = 0;

        //entrada de dados
        string[] v = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            numeros[i] = int.Parse(v[i]);
        };

        //processamento e saída de dados
        for( int i = 0; i < n; i++){
            if ( numeros[i] % 2 == 0 ) {
                if (i < n - 1) {
                    Console.Write(numeros[i] + " ");
                } else {
                    Console.WriteLine(numeros[i]);
                };
                totalDeNumerosPares++;
            };
        };

        Console.WriteLine(totalDeNumerosPares);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};