using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, maior, medio, menor;
            string[] vetor = Console.ReadLine().Split(' ');
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            if (A == B && A == C)
            {
                maior = A;
                medio = B;
                menor = C;
            }
            else if (A > B && A > C)
            {
                if (B >= C)
                {
                    maior = A;
                    medio = B;
                    menor = C;
                }
                else
                {
                    maior = A;
                    medio = C;
                    menor = B;
                }
            }
            else if (B > A && B > C)
            {
                if (A >= C)
                {
                    maior = B;
                    medio = A;
                    menor = C;
                }
                else
                {
                    maior = B;
                    medio = C;
                    menor = A;
                }
            }
            else
            {
                if (B >= A)
                {
                    maior = C;
                    medio = B;
                    menor = A;
                }
                else
                {
                    maior = C;
                    medio = A;
                    menor = B;
                }
            }

            if (maior >= medio + menor)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(maior, 2) == Math.Pow(medio, 2) + Math.Pow(menor, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(maior, 2) > Math.Pow(medio, 2) + Math.Pow(menor, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (maior == medio || medio == menor)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else if (Math.Pow(maior, 2) < Math.Pow(medio, 2) + Math.Pow(menor, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (maior == medio && maior == menor)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (maior == medio || medio == menor)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }





        }
    }
}