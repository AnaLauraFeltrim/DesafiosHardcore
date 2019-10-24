using System;

namespace Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidade;
            int tempo;
            int dist;
            int litros;

            System.Console.WriteLine("Digite a velocidade média em Km: ");
            velocidade = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o tempo decorrido em horas: ");
            tempo = int.Parse(Console.ReadLine());

            dist = tempo*velocidade;
            litros = dist/12;

            System.Console.WriteLine($"A quantidade de gasolina usada foi de {litros}");
            
        }
    }
}
