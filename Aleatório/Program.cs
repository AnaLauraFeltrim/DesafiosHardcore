using System;
using System.Collections.Generic;

namespace Aleatório
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int [10];
            int x;
            

            for(x = 0; x <10; x++ ){
                Random taoAleatorio = new Random ();
                
                vetor[x]= taoAleatorio.Next(0,10);
                System.Console.WriteLine(vetor[x]);

            }

            for(x = 0; x<10; x++){
                if(vetor[x] % 2 == 0){
                    System.Console.WriteLine($"Par{vetor[x]} ");
                    
                }else{
                    System.Console.WriteLine($"Ímpar{vetor[x]} ");
                }
            }
                



        }
    }
}
