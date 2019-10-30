using System;

namespace Vetores {
    class Program {
        static void Main (string[] args) {
            int posiçao;
            int i;
        

            System.Console.WriteLine ("Insira a quantidade de posições do vetor");
            posiçao = int.Parse (Console.ReadLine ());

            int[] vetor = new int[posiçao];

            for (i = 0; i < posiçao; i++) {
                System.Console.WriteLine ($"Digite o número da posição {i+1}");
                vetor[i] = int.Parse (Console.ReadLine ());  
            }
            Console.Clear();
            
            System.Console.WriteLine("Os números no vetor são: ");
            
            for(int y = 0; y < posiçao; y++){
                    System.Console.WriteLine(vetor[y]);
                }


        }
    }
}