using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex04");
        Console.WriteLine("1 valor/int n valores/double");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        double[] numeros = new double[n];
        double somaDosValores = 0.0, mediaAritmetica = 0.0;

        //entrada de dados
        string[] v = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            numeros[i] = double.Parse(v[i], CultureInfo.InvariantCulture);
        };

        //processamento de dados
        for ( int i = 0; i < n; i++){
            somaDosValores += numeros[i];
        };

        mediaAritmetica = somaDosValores / n;

        // saída dos dados
        Console.WriteLine(mediaAritmetica.ToString("F3", CultureInfo.InvariantCulture));
        for ( int i = 0; i < n; i++){
            if (numeros[i] < mediaAritmetica) {
                Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
            };
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};