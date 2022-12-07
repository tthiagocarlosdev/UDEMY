using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      int n1;
      char ch;
      double n2;
      string nome;
      char sexo;
      int idade;
      double altura;
      

      Console.Clear();
      Console.Write("Digite um número inteiro: ");
      n1 = int.Parse(Console.ReadLine());
      Console.Write("Digite o sexo [F][M]: ");
      ch = char.Parse(Console.ReadLine());
      Console.Write("Digite um número double: ");
      n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite o nome, sexo, idade e altura: ");
      string[] vet = Console.ReadLine().Split(' ');
      nome = vet[0];
      sexo = char.Parse(vet[1]);
      idade = int.Parse(vet[2]);
      altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

      Console.Clear();

      Console.WriteLine("Você digitou");
      Console.WriteLine("Número inteiro: " + n1);
      Console.WriteLine("Sexo: " + ch);
      Console.WriteLine("Número double: " + n2.ToString("F2", CultureInfo.InvariantCulture) + "\n");
      Console.WriteLine("Nome: " + nome);
      Console.WriteLine("Sexo: " + sexo);
      Console.WriteLine("Idade: " + idade);
      Console.WriteLine("Altura: " + altura.ToString(CultureInfo.InvariantCulture));

      Console.ReadLine();
    }
  }
}