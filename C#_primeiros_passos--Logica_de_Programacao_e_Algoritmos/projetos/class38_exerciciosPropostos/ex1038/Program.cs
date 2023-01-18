using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1038");
        Console.WriteLine("Lanche");
        Console.WriteLine("Código/Quantidade");

        int codigoProduto, quantidadeProduto;
        double valorTotal = 0.0;

        string[] valores = Console.ReadLine().Split(' ');
        codigoProduto = int.Parse(valores[0]);
        quantidadeProduto = int.Parse(valores[1]);
            
        
        switch (codigoProduto)
        {
            case 1:
                valorTotal = (double)(quantidadeProduto * 4.00);
            break;
            case 2:
                valorTotal = (double)(quantidadeProduto * 4.50);
            break;
            case 3:
                valorTotal = (double)(quantidadeProduto * 5.00);
            break;
            case 4:
                valorTotal = (double)(quantidadeProduto * 2.00);
            break;
            case 5:
                valorTotal = (double)(quantidadeProduto * 1.50);
            break;
            // default:
            //     Console.WriteLine("Código inválido!");
            // break;
        }

        Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InstalledUICulture));
        

        Console.ReadLine();
    }
  }
};