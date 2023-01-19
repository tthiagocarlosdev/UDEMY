using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1045");
        Console.WriteLine("Tipos de Triângulos");
        Console.WriteLine("2 Valores/double");
        Console.WriteLine("------------------------");

        float A, B, C, troca;
        string[] v = Console.ReadLine().Split(' ');
        A = float.Parse(v[0], CultureInfo.InvariantCulture);
        B = float.Parse(v[1], CultureInfo.InvariantCulture);
        C = float.Parse(v[2], CultureInfo.InvariantCulture);

        //ordenacao dos valores em ordem decrescente
        if(B > A){
            troca = A;
            A = B;
            B = troca;
        }
        if(C > A){
            troca = A;
            A = C;
            C = troca;
        }
        if(C > B){
            troca  = B;
            B = C;
            C = troca;
        }

        //classificacao dos valores
        if(A >= B + C){
            Console.WriteLine("NAO FORMA TRIANGULO");
        } else if(Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)){
            Console.WriteLine("TRIANGULO RETANGULO");
        } else if(Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        } else if(Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2)){
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if(A == B && B == C){
            Console.WriteLine("TRIANGULO EQUILATERO");
        } else if(A == B || A == C || B == C){
            Console.WriteLine("TRIANGULO ISOSCELES");
        }


        Console.WriteLine("------------------------");
        Console.WriteLine(A.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(B.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(C.ToString("F1", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
  }
};
