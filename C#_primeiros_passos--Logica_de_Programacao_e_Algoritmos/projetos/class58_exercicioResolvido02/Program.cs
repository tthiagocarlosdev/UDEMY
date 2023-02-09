using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 58 - Vetores");
        Console.WriteLine("Exercício resolvido 02");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        int n = 0;
        double soma = 0.0, media = 0.0;
        double[] vet;

        n = int.Parse(Console.ReadLine());
        vet = new double[n];

        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++) {
            vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            soma += vet[i];
        };

        media = (double)(soma / n);

        for (int i = 0; i < n; i++) {
            if (i < n - 1) {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            } else {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            };
        };

        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};