using System;

namespace Troca_variável
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;

            Console.WriteLine("Insira a variável A: ");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira a variável B: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            d = b;

            System.Console.WriteLine($"O valor de A é {d} e o valor de B é {c}");

        }


        }
    }
