namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
      string frase, x, y, z, a, b, c;

      Console.Clear();
      Console.Write("Digite uma frase: ");
      frase = Console.ReadLine();
      Console.Write("Digite uma cor: ");
      x = Console.ReadLine();
      Console.Write("Digite uma cor em inglês: ");
      y = Console.ReadLine();
      Console.Write("Digite outra cor em inglês: ");
      z = Console.ReadLine();
      Console.Write("Digite 3 cores: ");
      string[] v = Console.ReadLine().Split(' ');
      a = v[0];
      b = v[1];
      c = v[2];

      Console.Clear();

      Console.WriteLine("Você digitou: " + frase);
      Console.WriteLine("Cor digitada: " + x);
      Console.WriteLine("Cor em inglês: " + y);
      Console.WriteLine("2a cor em inglês: " + z);
      Console.WriteLine("Cores: " + a + ", " + b + ", " + c);

      Console.ReadLine();
    }
  }
}