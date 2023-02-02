using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1096");
        Console.WriteLine("Sequencia IJ 2");
        // Console.WriteLine("");
        Console.WriteLine("------------------------");

        int i = 1;

        while (i <= 9) {

            int j = 7;
            while (j >= 5) {
                Console.WriteLine("I="+i+" J="+j);
                j--;
            }
            
            i+=2;
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};