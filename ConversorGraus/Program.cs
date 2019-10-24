using System;

namespace ConversorGraus
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int f;
            Console.WriteLine("Insira a temperatura em centígrados");
            c = int.Parse(Console.ReadLine());

            
            f = ((c*9/5) + 32);
            System.Console.WriteLine($"o valor em Fahrenheit é: {f}");
            
        }
    }
}
