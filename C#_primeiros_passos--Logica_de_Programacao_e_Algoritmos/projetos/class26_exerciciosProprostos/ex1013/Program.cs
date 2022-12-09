using System;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("Exercício 1013");
      Console.WriteLine("O Maior");
      Console.WriteLine("A/B/C");

      int A, B, C, maiorAB, maiorABC;
      string[] vet;

      vet = Console.ReadLine().Split(' ');
      A = int.Parse(vet[0]);
      B = int.Parse(vet[1]);
      C = int.Parse(vet[2]);
    
      maiorAB = ((A + B + Math.Abs(A - B)) / 2);
      maiorABC = ((C + maiorAB + Math.Abs(C - maiorAB)) / 2);
      
      Console.WriteLine(maiorABC + " eh o maior");
      
      Console.ReadLine();
    }
  }
};