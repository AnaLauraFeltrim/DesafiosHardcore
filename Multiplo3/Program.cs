using System;

namespace Multiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            do{
            


            Console.Write("Insira o número ou 0 para terminar: ");
            num1 = int.Parse(Console.ReadLine());

            if(num1 % 3 == 0){
                Console.WriteLine("O número é divisível por 3");
            }

            else{
                Console.WriteLine("O número não é divisível por 3");
            }

            }while(num1 != 0);

        }
    }
}
