using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 59 - Vetores");
        Console.WriteLine("Exercício resolvido 03");
        // Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = 0, QuantidadeDePessoasComMenos16Anos = 0;
        double somaDasAlturas = 0.0, alturaMedia = 0.0;
        double percentualDePessoasComMenos16Anos = 0.0;
        string[] nomes;
        int[] idades;
        double[] alturas;
        
        n = int.Parse(Console.ReadLine());
        nomes = new string[n];
        idades = new int[n];
        alturas = new double[n];

        //entrada de dados
        for (int i = 0; i < n; i++) {
            string[] s = Console.ReadLine().Split(' ');
            nomes[i] = s[0];
            idades[i] = int.Parse(s[1]);
            alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
        };

        //soma das alturas
        for ( int i = 0; i < n; i++) {
            somaDasAlturas += alturas[i];
        };

        // altura média
        alturaMedia = somaDasAlturas / n;

        // pessoas com menos de 16 anos
        for ( int i = 0; i < n; i++) {
            if ( idades[i] < 16) {
                QuantidadeDePessoasComMenos16Anos++;
            };
        };

        //percentual de pessoas com menos de 16 anos
        percentualDePessoasComMenos16Anos = ((QuantidadeDePessoasComMenos16Anos * 100.0) / n);

        Console.WriteLine("Altura média: " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Pessoas com menos de 16 anos: " + percentualDePessoasComMenos16Anos.ToString("F1", CultureInfo.InvariantCulture) + "%");

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};