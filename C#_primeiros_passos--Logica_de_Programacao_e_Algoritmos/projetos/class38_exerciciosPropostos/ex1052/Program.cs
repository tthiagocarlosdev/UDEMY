﻿using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1052");
        Console.WriteLine("Mês");
        Console.WriteLine("1 valor/int");
        Console.WriteLine("------------------------");

        int numero = int.Parse(Console.ReadLine());
        string mes = "";

        switch (numero){
            case 1:
                mes = "January";
                break;
            case 2:
                mes = "February";
                break;
            case 3:
                mes = "March";
            break;
            case 4:
                mes = "April";
                break;
            case 5:
                mes = "May";
                break;
            case 6:
                mes = "June";
                break;
            case 7:
                mes = "July";
                break;
            case 8:
                mes = "August";
                break;
            case 9:
                mes = "September";
                break;
            case 10:
                mes = "October";
                break;
            case 11:
                mes = "November";
                break;
            case 12:
                mes = "December";
                break;
        }

        Console.WriteLine(mes);
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};