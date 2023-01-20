using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1047");
        Console.WriteLine("Tempo de Jogo com Minutos");
        Console.WriteLine("4 Valores/int");
        Console.WriteLine("------------------------");

        int horaInicial, minutoInicial, horaFinal, minutoFinal, tempoEmMinutoInicial, tempoEmMinutoFinal, duracaoEmMinutos = 0;
        int horasDeDuracao, minutosDeDuracao;
        string[] v = Console.ReadLine().Split(' ');
        horaInicial = int.Parse(v[0]);
        minutoInicial = int.Parse(v[1]);
        horaFinal = int.Parse(v[2]);
        minutoFinal = int.Parse(v[3]);

        tempoEmMinutoInicial = ((horaInicial * 60) + minutoInicial);
        tempoEmMinutoFinal = ((horaFinal * 60) + minutoFinal);

        if(tempoEmMinutoInicial < tempoEmMinutoFinal){
            duracaoEmMinutos = tempoEmMinutoFinal - tempoEmMinutoInicial;
        } else {
            duracaoEmMinutos = ((24 * 60) -tempoEmMinutoInicial) + tempoEmMinutoFinal;
        }

        horasDeDuracao = duracaoEmMinutos / 60;
        minutosDeDuracao = duracaoEmMinutos % 60;        

        Console.WriteLine("O JOGO DUROU "+ horasDeDuracao +" HORA(S) E "+ minutosDeDuracao+ " MINUTO(S)");
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
