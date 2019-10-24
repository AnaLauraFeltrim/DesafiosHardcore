using System;

namespace pLANETAS
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            
            
            System.Console.WriteLine("Digite o sua peso em N: ");
            peso = int.Parse(Console.ReadLine());



            System.Console.WriteLine($"Seu peso em Marte é {peso * 0.38}");
            System.Console.WriteLine($"Seu peso em Mercúrio é {peso * 0.37}");
            System.Console.WriteLine($"Seu peso em Venus é {peso * 0.88 }");
            System.Console.WriteLine($"Seu peso em Jupter é {peso * 2.64 }");
            System.Console.WriteLine($"Seu peso em Saturno é {peso * 1.15 }");
            System.Console.WriteLine($"Seu peso em Urano é {peso * 1.17}");
        }
    }
}
