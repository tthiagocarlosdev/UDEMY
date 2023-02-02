using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1072");
        Console.WriteLine("Intervalo 2");
        Console.WriteLine("1 valor/int e N valores/int");
        Console.WriteLine("------------------------");

        int dentro = 0, fora = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            int x = int.Parse(Console.ReadLine());
            if( x >= 10 && x <= 20 ){
                dentro++;
            } else {
                fora++;
            }
        }

        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};