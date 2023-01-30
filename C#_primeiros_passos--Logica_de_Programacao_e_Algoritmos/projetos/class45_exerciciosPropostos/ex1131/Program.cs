using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("ex1131");
        Console.WriteLine("Grenais");
        Console.WriteLine("gols/int");
        Console.WriteLine("------------------------");

        int golsInter, golsGremio, grenais = 0, vitoriasInter = 0, vitoriasGremio = 0, empate = 0, x = 1;
        string vencedor = "";

        while(x != 2){
            string[] v = Console.ReadLine().Split(' ');
            golsInter = int.Parse(v[0]);
            golsGremio = int.Parse(v[1]);

            grenais++;

            if(golsInter == golsGremio){
                empate++;
            } else if(golsInter > golsGremio){
                vitoriasInter++;
            } else {
                vitoriasGremio++;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            x = int.Parse(Console.ReadLine());
        }

        if(vitoriasInter > vitoriasGremio){
            vencedor = "Inter venceu mais";
        } else if(vitoriasGremio > vitoriasInter){
            vencedor = "Gremio venceu mais";
        } else {
            vencedor = "Nao houve vencedor";
        }

        Console.WriteLine(grenais + " grenais");
        Console.WriteLine("Inter:" + vitoriasInter);
        Console.WriteLine("Gremio:" + vitoriasGremio);
        Console.WriteLine("Empates:" + empate);
        Console.WriteLine(vencedor);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};