using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex08");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        char[] sexo = new char[n];
        double[] altura = new double[n];
        double menorAltura = 0.0, maiorAltura = 0.0;
        double somaDasAlturasDasMulheres = 0.0;
        double mediaDasAlturasDasMulheres = 0.0;
        double numeroDeMulheres = 0.0;
        int numeroDeHomens = 0;
        
        //entrada de dados
        for (int i = 0; i < n; i++) {
            string[] v = Console.ReadLine().Split(' ');
            altura[i] = double.Parse(v[0], CultureInfo.InvariantCulture);
            sexo[i] = char.Parse(v[1]);
        };

        //processamento de dados
        //menor altura
        menorAltura = altura[0];
        for (int i = 0; i < n; i++) {
            if (altura[i] < menorAltura) {
                menorAltura = altura[i];
            };
        };

        //maior altura
        for (int i = 0; i < n; i++) {
            if (altura[i] > maiorAltura) {
                maiorAltura = altura[i];
            };
        };

        //soma das alturas das mulheres
        for (int i = 0; i < n; i++) {
            if (sexo[i] == 'F') {
                somaDasAlturasDasMulheres += altura[i];
                numeroDeMulheres++;
            };
        };

        //media das alturas das mulheres
        mediaDasAlturasDasMulheres = somaDasAlturasDasMulheres / numeroDeMulheres;

        //numero de homens
        for (int i = 0; i < n; i++) {
            if (sexo[i] == 'M') {
                numeroDeHomens++;
            };
        };

        //saída de dados
        Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Media das alturas das mulheres = " + mediaDasAlturasDasMulheres.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Numero de homens = " + numeroDeHomens);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};