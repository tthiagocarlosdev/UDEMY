using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1079");
        Console.WriteLine("Médias Ponderadas");
        Console.WriteLine("1 valor/int 3 valores/double");
        Console.WriteLine("------------------------");

        double v1, v2, v3, media;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string[] v = Console.ReadLine().Split();
            v1 = double.Parse(v[0], CultureInfo.InvariantCulture);
            v2 = double.Parse(v[1], CultureInfo.InvariantCulture);
            v3 = double.Parse(v[2], CultureInfo.InvariantCulture);

            media = (((v1 * 2) + (v2 * 3) + (v3 * 5)) / 10);

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};