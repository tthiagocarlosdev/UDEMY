using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      Console.Clear();
      Console.WriteLine("------------------------------");
      Console.WriteLine("          IdadeMédia");
      Console.WriteLine("------------------------------");

      string nomeA, nomeB;
      int idadeA, idadeB;
      double idadeMedia;
      string[] vet;

      Console.Write("Digite o nome e idade: ");
      vet = Console.ReadLine().Split(' ');
      nomeA = vet[0];
      idadeA = int.Parse(vet[1]);
      
      Console.Write("Digite o nome e idade: ");
      vet = Console.ReadLine().Split(' ');
      nomeB = vet[0];
      idadeB = int.Parse(vet[1]);

      idadeMedia = (double) (idadeA + idadeB) / 2.0;

      Console.WriteLine("------------------------------");
      Console.WriteLine("A idade média de " + nomeA + " e " + nomeB + " é de " + idadeMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos");
      Console.WriteLine("------------------------------");
      
      Console.ReadLine();
    }
  }
};