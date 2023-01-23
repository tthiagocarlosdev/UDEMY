using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1051");
        Console.WriteLine("Imposto de Renda");
        Console.WriteLine("1 Valor/double");
        Console.WriteLine("------------------------");

        double valorDoImposto = 0.0;
        double receita = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(receita <= 2000.0){
            Console.WriteLine("Isento");
        } else if(receita <= 3000.0){
            double valorIncidente = receita  - 2000.0;
            valorDoImposto = valorIncidente * 0.08;
            Console.WriteLine("R$ " + valorDoImposto.ToString("F2", CultureInfo.InvariantCulture));
        } else if(receita <= 4500.0){
            double valorIncidente = receita - 3000.0;
            valorDoImposto = (valorIncidente * 0.18) + 80;
            Console.WriteLine("R$ " + valorDoImposto.ToString("F2", CultureInfo.InvariantCulture));
        } else if(receita > 4500.0){
            double valorIncidente = receita - 4500.0;
            valorDoImposto = (valorIncidente * 0.28) + 80 + 270;
            Console.WriteLine("R$ " + valorDoImposto.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
