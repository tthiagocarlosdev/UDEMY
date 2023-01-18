using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1046");
        Console.WriteLine("Tempo de Jogo");
        Console.WriteLine("A/B inteiro");

        int horaInicial, horaFinal, tempoDeJogo;

        string[] valores = Console.ReadLine().Split(' ');
        horaInicial = int.Parse(valores[0]);
        horaFinal = int.Parse(valores[1]);
        
        if(horaInicial >= horaFinal){
            tempoDeJogo = (24 - horaInicial) + horaFinal;
        } else {
            tempoDeJogo = horaFinal - horaInicial;
        }
            
        Console.WriteLine("O JOGO DUROU " + tempoDeJogo + " HORA(S)");

        Console.ReadLine();
    }
  }
};