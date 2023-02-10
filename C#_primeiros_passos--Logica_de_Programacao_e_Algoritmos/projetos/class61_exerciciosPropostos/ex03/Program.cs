using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex03");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        int[] vetorA = new int[n];
        int[] vetorB = new int[n];
        int[] vetorC = new int[n];

        //entrada de dados
        string[] vA = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            vetorA[i] = int.Parse(vA[i]);
        };
        string[] vB = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            vetorB[i] = int.Parse(vB[i]);
        };

        //processamento e saída de dados
        for ( int i = 0; i < n; i++){
            vetorC[i] = vetorA[i] + vetorB[i];
        };

        for ( int i = 0; i < n; i++){
            if (i < n - 1) {
                Console.Write(vetorC[i] + " ");
            } else {
                Console.WriteLine(vetorC[i]);
            };
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};