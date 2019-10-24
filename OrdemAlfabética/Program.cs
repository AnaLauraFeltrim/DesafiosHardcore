using System;
using System.Collections.Generic;

namespace OrdemAlfabética
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            System.Console.WriteLine("Insira um nome: ");
            nome1 = Console.ReadLine();
            System.Console.WriteLine("Insira outro nome: ");
            nome2 = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Aqui estão seus nomes em ordem alfabética");

            List<string> lista = new List<string>();

            lista.Add(nome1);
            lista.Add(nome2);

            lista.Sort();

            foreach(string item in lista){
                System.Console.WriteLine(item);
            }

            
            
        }
    }
}
