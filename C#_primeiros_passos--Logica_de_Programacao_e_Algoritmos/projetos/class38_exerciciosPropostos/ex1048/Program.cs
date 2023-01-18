using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1048");
        Console.WriteLine("Aumento de Salário");
        Console.WriteLine("Salário/double");

        double salario, novoSalario = 0.0, reajusteGanho = 0.0;
        int percentual = 0;

        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(salario > 2000.0){
            novoSalario = (double)(salario + (salario * 0.04));
            reajusteGanho = (double)(salario * 0.04);
            percentual = 4;
        } else if(salario > 1200.0){
            novoSalario = (double)(salario + (salario * 0.07));
            reajusteGanho = (double)(salario * 0.07);
            percentual = 7;
        } else if(salario  > 800.0){
            novoSalario = (double)(salario + (salario * 0.10));
            reajusteGanho = (double)(salario * 0.10);
            percentual = 10;
        } else if(salario > 400.0){
            novoSalario = (double)(salario + (salario * 0.12));
            reajusteGanho = (double)(salario * 0.12);
            percentual = 12;
        } else {
            novoSalario = (double)(salario + (salario * 0.15));
            reajusteGanho = (double)(salario * 0.15);
            percentual = 15;
        }

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InstalledUICulture));
        Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InstalledUICulture));
        Console.WriteLine("Em percentual: " + percentual + " %");
        

        Console.ReadLine();
    }
  }
};