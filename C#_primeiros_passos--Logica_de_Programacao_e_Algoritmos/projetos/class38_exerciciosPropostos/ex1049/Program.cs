using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1049");
        Console.WriteLine("Animal");
        Console.WriteLine("3 palavras/string");
        Console.WriteLine("------------------------");

        string classificacao, tipo, alimentacao, animal = "";

        classificacao = Console.ReadLine();
        tipo = Console.ReadLine();
        alimentacao = Console.ReadLine();

        if(classificacao == "vertebrado"){
            if(tipo == "ave"){
                if(alimentacao == "carnivoro"){
                    animal = "aguia";
                } else if (alimentacao == "onivoro"){
                    animal = "pomba";
                }
            } else if(tipo == "mamifero"){
                if(alimentacao == "onivoro"){
                    animal = "homem";
                } else if(alimentacao == "herbivoro"){
                    animal = "vaca";
                }
            }
        } else if(classificacao == "invertebrado"){
            if(tipo == "inseto"){
                if(alimentacao == "hematofago"){
                    animal = "pulga";
                } else if(alimentacao == "herbivoro"){
                    animal = "lagarta";
                }
            } else if(tipo == "anelideo"){
                if(alimentacao == "hematofago"){
                    animal = "sanguessuga";
                } else if(alimentacao == "onivoro"){
                    animal = "minhoca";
                }
            }
        }

        Console.WriteLine(animal);
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
