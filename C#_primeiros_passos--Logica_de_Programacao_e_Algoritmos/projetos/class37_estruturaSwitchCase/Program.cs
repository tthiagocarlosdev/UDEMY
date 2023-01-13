using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Estrutura switch-case");
        Console.WriteLine("Número inteiro");

        string diaDaSemana = "";
        
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1: 
                diaDaSemana = "domingo";
            break;
            case 2:
                diaDaSemana = "segunda";
            break;
            case 3:
                diaDaSemana = "terça";
            break;
            case 4:
                diaDaSemana = "quarta";
            break;
            case 5:
                diaDaSemana = "quinta";
            break;
            case 6:
                diaDaSemana = "sexta";
            break; 
            case 7:
                diaDaSemana = "sabado";
            break;
            default:
                diaDaSemana = "valor inválido";
            break;
        };

        Console.WriteLine("Dia da semana: " + diaDaSemana);
        Console.ReadLine();
    }
  }
};