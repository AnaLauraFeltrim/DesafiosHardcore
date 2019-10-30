using System;

namespace LadosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            

            Console.WriteLine("Insira três aresta de um triângulo");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());

            

            if(num1 + num2 > num3){
                if((num1 == num2)&&(num2 == num3)){
                    System.Console.WriteLine("Esse triângulo é equilátero");
                }
                if((num1 == num2)&&(num2 != num3)){
                    System.Console.WriteLine("Esse triângulo é Isósceles");
                }
                if((num1 != num2)&&(num2 != num3)){
                    System.Console.WriteLine("Esse triângulo é Escaleno");
                }
                    
            }else {
                System.Console.WriteLine("Isso não pode ser um triângulo");
            }


        }
    }
}
