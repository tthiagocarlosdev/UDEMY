using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex06");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine()), maiorIdade = 0;
        string[] nomes = new string[n];
        int[] idades = new int[n];
        string pessoaMaisVelha = "";
        
        //entrada de dados
        
        for (int i = 0; i < n; i++) {
            string[] v = Console.ReadLine().Split(' ');
            nomes[i] = v[0];
            idades[i] = int.Parse(v[1]);
        };

        //processamento de dados
        for ( int i = 0; i < n; i++){
            if ( idades[i] > maiorIdade) {
                maiorIdade = idades[i];
                pessoaMaisVelha = nomes[i];
            };
        };

        // saída dos dados
        Console.WriteLine("Pessoa mais velha: " + pessoaMaisVelha);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};