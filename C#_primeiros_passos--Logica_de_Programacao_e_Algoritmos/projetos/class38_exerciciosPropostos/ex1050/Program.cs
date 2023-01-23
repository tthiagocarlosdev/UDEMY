using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1050");
        Console.WriteLine("DDD");
        Console.WriteLine("1 Valor/int");
        Console.WriteLine("------------------------");

        int DDD = int.Parse(Console.ReadLine());
        string destino = "";

        if(DDD == 61){
            destino = "Brasilia";
        } else if(DDD == 71){
            destino = "Salvador";
        } else if(DDD == 11){
            destino = "Sao Paulo";
        } else if(DDD == 21){
            destino = "Rio de Janeiro";
        } else if(DDD == 32){
            destino = "Juiz de Fora";
        } else if(DDD == 19){
            destino = "Campinas";
        } else if(DDD == 27){
            destino = "Vitoria";
        } else if(DDD == 31){
            destino = "Belo Horizonte";
        } else {
            destino = "DDD nao cadastrado";
        }

        Console.WriteLine(destino);

        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};