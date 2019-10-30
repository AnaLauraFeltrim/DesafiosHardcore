﻿using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            Console.WriteLine("Qual o seu peso? ");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual a sua altura? ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            
            System.Console.WriteLine($"Seu IMC é de {imc}");

            if(imc >= 35){
                System.Console.WriteLine("Seu IMC indica obesidade mórbida");
            } 
            if ((imc >= 30)&&(imc < 35)){
                System.Console.WriteLine("Seu IMC indica obesidade");
            }
            if((imc >= 25)&&(imc < 30)){
                System.Console.WriteLine("Seu IMC indica excesso de peso");
            }
            if((imc >= 20)&&(imc < 25)){
                System.Console.WriteLine("Seu IMC indica normalidade");
            }
            if(imc < 20){
                System.Console.WriteLine("Seu IMC indica que você está abaixo do peso");
            }


        }
    }
}
