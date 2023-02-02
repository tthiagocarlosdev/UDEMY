using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1094");
        Console.WriteLine("Experiências");
        Console.WriteLine("n valores/int e char");
        Console.WriteLine("------------------------");

        int totalCobaias = 0, totalDeCoelhos = 0, totalDeRatos = 0, totalDeSapos = 0;
        double percentualDeCoelhos = 0.0, percentualDeRatos = 0.0, percentualDeSapos = 0.0;

        int n = int.Parse(Console.ReadLine());

        for ( int i = 0; i < n; i++ ) {
            int v1;
            char v2;
            string[] v = Console.ReadLine().Split(' ');
            v1 = int.Parse(v[0]);
            v2 = char.Parse(v[1]);

            totalCobaias += v1;

            if (v2 == 'C') {
                totalDeCoelhos += v1;
            } else if (v2 == 'R') {
                totalDeRatos += v1;
            } else {
                totalDeSapos += v1;
            }
        }

        percentualDeCoelhos = (totalDeCoelhos * 100.0) / totalCobaias;
        percentualDeRatos = (totalDeRatos * 100.0) / totalCobaias;
        percentualDeSapos = (totalDeSapos * 100.0) / totalCobaias;

        Console.WriteLine("Total: " + totalCobaias + " cobaias");
        Console.WriteLine("Total de coelhos: " + totalDeCoelhos);
        Console.WriteLine("Total de ratos: " + totalDeRatos);
        Console.WriteLine("Total de sapos: " + totalDeSapos);
        Console.WriteLine("Percentual de coelhos: " + percentualDeCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de ratos: " + percentualDeRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de sapos: " + percentualDeSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};