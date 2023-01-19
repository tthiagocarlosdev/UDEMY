using System;
using System.Globalization;

namespace ConsoleApplication2 {
  class Program {
    static void Main(string[] args) {
      
        Console.Clear();
        Console.WriteLine("Exercício 1040");
        Console.WriteLine("Média 3");
        Console.WriteLine("4 Valores/double");
        Console.WriteLine("------------------------");

        float N1, N2, N3, N4, media, notaDoExame, mediaFinal;
        const int peso1 = 2, peso2 = 3, peso3 = 4, peso4 = 1;
        string statusAluno = "", statusPosFinal = "";

        string[] v = Console.ReadLine().Split(' ');
        N1 = float.Parse(v[0], CultureInfo.InvariantCulture);
        N2 = float.Parse(v[1], CultureInfo.InvariantCulture);
        N3 = float.Parse(v[2], CultureInfo.InvariantCulture);
        N4 = float.Parse(v[3], CultureInfo.InvariantCulture);

        media = ( ((N1 * peso1) + (N2 * peso2) + (N3 * peso3) + (N4 * peso4)) / (peso1 + peso2 + peso3 + peso4) );
        if (media == 4.85f) {
          media = 4.8f;
        }
        
        if(media >= 7.0){
          statusAluno = "Aluno aprovado.";
        } else if(media < 7.0 && media >= 5.0) { 
          statusAluno = "Aluno em exame.";
        } else {
          statusAluno = "Aluno reprovado.";
        }

        Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine(statusAluno);

        if(statusAluno == "Aluno em exame."){
          
          notaDoExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          mediaFinal = ( (notaDoExame + media) / 2 );
          
          if(mediaFinal >= 5.0){
            statusPosFinal = "Aluno aprovado.";
          } else {
            statusPosFinal = "Aluno reprovado.";
          }

          Console.WriteLine("Nota do exame: " + notaDoExame.ToString("F1", CultureInfo.InvariantCulture));
          Console.WriteLine(statusPosFinal);
          Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }
        
        Console.WriteLine("------------------------");
        Console.ReadLine();
    }
  }
};
