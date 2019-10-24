using System;

namespace Retangulo {
    class Program {
        static void Main (string[] args) {
            int num1 = 0;
            int num2 = 0;
            int total = 0;
            int perimetro;
            double diagonal;

            Console.WriteLine ("Digite o valor da base: ");
            num1 = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o valor da altura: ");
            num2 = int.Parse (Console.ReadLine ());
            total = num1 * num2;
            perimetro = (num1 * 2) + (num2 * 2);
            diagonal = Math.Sqrt ((num1 * num1) + (num2 * num2));

            Console.WriteLine ($"O valor da área é igual a: {total}");
            System.Console.WriteLine ($"O valor da diagonal é: {diagonal}");
            System.Console.WriteLine ($"O valor do perímetro é: {perimetro}");
        }
    }
}