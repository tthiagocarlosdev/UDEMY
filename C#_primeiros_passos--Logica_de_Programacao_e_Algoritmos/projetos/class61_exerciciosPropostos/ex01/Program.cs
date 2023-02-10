using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex01");
        Console.WriteLine("1 valor/int n valores/double");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        double[] numeros = new double[n];
        double maiorNumero = 0;
        int indiceDoMaiorNumero = 0;

        //entrada de dados
        string[] v = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            numeros[i] = double.Parse(v[i], CultureInfo.InvariantCulture);
        };

        //processamento de dados
        for( int i = 0; i < n; i++){
            if ( numeros[i] > maiorNumero) {
                maiorNumero = numeros[i];
                indiceDoMaiorNumero = i;
            };
        };

        // saída de dados
        Console.WriteLine(maiorNumero.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(indiceDoMaiorNumero);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};