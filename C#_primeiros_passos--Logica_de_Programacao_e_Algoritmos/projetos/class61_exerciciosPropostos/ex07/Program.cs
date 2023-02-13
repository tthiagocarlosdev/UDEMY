using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex07");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        string[] nomes = new string[n];
        double[] notaA = new double[n];
        double[] notaB = new double[n];
        double[] medias = new double[n];
        string[] alunosAprovados = new string[n];
        
        //entrada de dados
        for (int i = 0; i < n; i++) {
            string[] v = Console.ReadLine().Split(' ');
            nomes[i] = v[0];
            notaA[i] = double.Parse(v[1], CultureInfo.InvariantCulture);
            notaB[i] = double.Parse(v[2], CultureInfo.InvariantCulture);
        };

        //processamento de dados
        //calculo das medias
        for ( int i = 0; i < n; i++){
            medias[i] = ((notaA[i] + notaB[i]) / 2);
        };

        //alunos aprovados
        int j = 0;
        for ( int i = 0; i < n; i++){
            if ( medias[i] >= 6.0) {
                alunosAprovados[j] = nomes[i];
                j++;
            };
        };

        // saída dos dados
        Console.WriteLine("Alunos aprovados:");
        foreach( string aluno in alunosAprovados ){
            Console.WriteLine(aluno);
        };

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};