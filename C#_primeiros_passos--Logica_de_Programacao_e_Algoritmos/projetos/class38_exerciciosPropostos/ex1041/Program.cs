using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1041");
        Console.WriteLine("Coordenadas de um Ponto");
        Console.WriteLine("2 Valores/double");
        Console.WriteLine("------------------------");

        double x = 0.0, y = 0.0;
        string quadrante = "";

        string[] v = Console.ReadLine().Split(' ');
        x = double.Parse(v[0], CultureInfo.InvariantCulture);
        y = double.Parse(v[1], CultureInfo.InvariantCulture);

        if(x == 0.0 && y == 0.0){
            quadrante = "Origem";
        } else if(y == 0.0){
            quadrante = "Eixo X";
        } else if(x == 0.0){
            quadrante = "Eixo Y";
        } else if(x > 0.0 && y > 0.0){
            quadrante = "Q1";
        } else if(x < 0.0 && y > 0.0){
            quadrante = "Q2";
        } else if(x < 0.0 && y < 0.0){
            quadrante = "Q3";
        } else if(x > 0.0 && y < 0.0){
            quadrante = "Q4";
        }

        Console.WriteLine(quadrante);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
