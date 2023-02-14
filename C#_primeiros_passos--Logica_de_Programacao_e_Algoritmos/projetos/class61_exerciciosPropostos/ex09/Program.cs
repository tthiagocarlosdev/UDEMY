using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Aula 61 - exercícios Propostos");
        Console.WriteLine("ex09");
        Console.WriteLine("1 valor/int n valores/int");
        Console.WriteLine("------------------------");

        // declaração de variáveis
        int n = int.Parse(Console.ReadLine());
        string[] produto = new string[n];
        double[] precoDeCompras = new double[n];
        double[] precoDeVenda = new double[n];
        double[] lucroDaVenda = new double[n];
        double[] percentualDeLucro = new double[n];
        int lucroAbaixoDe10 = 0, lucroEntre10e20 = 0, lucroAcimaDe20 = 0;
        double valorTotalDeCompras = 0.0, valorTotalVenda = 0.0, lucroTotal = 0.0;
        
        //entrada de dados
        for (int i = 0; i < n; i++) {
            string[] v = Console.ReadLine().Split(' ');
            produto[i] = v[0];
            precoDeCompras[i] = double.Parse(v[1], CultureInfo.InvariantCulture);
            precoDeVenda[i] = double.Parse(v[2], CultureInfo.InvariantCulture);
        };

        //processamento de dados
        // calculo do lucro
        for (int i = 0; i < n; i++) {
            lucroDaVenda[i] = precoDeVenda[i] - precoDeCompras[i];
        };

        //calculo do percentual de lucro
        for ( int i = 0; i < n; i++) {
            percentualDeLucro[i] = ((lucroDaVenda[i] * 100.0) / precoDeCompras[i]);
        };

        // calculo dos lucros
        for ( int i = 0; i < n; i++) {
            if ( percentualDeLucro[i] < 10.0 ) {
                lucroAbaixoDe10++;
            } else if ( percentualDeLucro[i] >= 10.0 && percentualDeLucro[i] <= 20.0 ) {
                lucroEntre10e20++;
            } else {
                lucroAcimaDe20++;
            };
        };

        //calculo dos valores totais
        for ( int i = 0; i < n; i++ ) {
            valorTotalDeCompras += precoDeCompras[i];
            valorTotalVenda += precoDeVenda[i];
        };

        lucroTotal = valorTotalVenda - valorTotalDeCompras;

        //saída de dados
        Console.WriteLine("Lucro   abaixo de 10%: " + lucroAbaixoDe10);
        Console.WriteLine("Lucro   entre 10% e 20%: " + lucroEntre10e20);
        Console.WriteLine("Lucro   acima de 20%: " + lucroAcimaDe20);
        Console.WriteLine("Valor   total de compra: " + valorTotalDeCompras.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor   total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Lucro   total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};