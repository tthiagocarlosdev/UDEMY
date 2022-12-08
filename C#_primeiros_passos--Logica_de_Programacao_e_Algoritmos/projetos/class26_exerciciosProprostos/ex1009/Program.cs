using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1009");
      Console.WriteLine("Salário com bônus");
      Console.WriteLine("NOME/SALARIO/VENDAS");

      string nomeVendedor;
      double salarioFixo, totalDeVendas, comissao, totalAReceber;

      nomeVendedor = Console.ReadLine();
      salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      comissao = totalDeVendas * 0.15;
      totalAReceber = salarioFixo + comissao;

      Console.WriteLine("TOTAL = R$ " + totalAReceber.ToString("F2", CultureInfo.InvariantCulture));
      
      Console.ReadLine();
    }
  }
};