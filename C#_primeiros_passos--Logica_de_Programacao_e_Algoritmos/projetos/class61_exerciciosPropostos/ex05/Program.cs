using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex05");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        int somaDosValoresPares = 0, quantidadeDosValoresPares = 0;
        double mediaAritmeticaDosPares = 0.0;

        //entrada de dados
        string[] v = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            numeros[i] = int.Parse(v[i]);
        };

        //processamento de dados
        for ( int i = 0; i < n; i++){
            if ( numeros[i] % 2 == 0) {
                somaDosValoresPares += numeros[i];
                quantidadeDosValoresPares++;
            };
        };

        mediaAritmeticaDosPares = (double)somaDosValoresPares / quantidadeDosValoresPares;

        // saída dos dados
        Console.WriteLine(mediaAritmeticaDosPares.ToString("F1", CultureInfo.InvariantCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};