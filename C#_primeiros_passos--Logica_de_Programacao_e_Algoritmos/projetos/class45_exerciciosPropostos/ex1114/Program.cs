using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1114");
        Console.WriteLine("Senha Fixa");
        Console.WriteLine("Valores/int");
        Console.WriteLine("------------------------");

        int senha = int.Parse(Console.ReadLine());

        while(senha != 2002){
            Console.WriteLine("Senha Invalida");
            senha = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Acesso Permitido");
                
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};