using System;

namespace Impares0_10 {
    class Program {
        static void Main (string[] args) {
            int num = 1;

            Console.WriteLine ("10 primeiros ímpares: ");

            for (num = 1; num < 10; num+=2) {

                if (num % 2 != 0) {
                    Console.WriteLine ($"{num}");
                }
            }
        }
    }
}