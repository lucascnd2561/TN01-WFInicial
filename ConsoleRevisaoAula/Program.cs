﻿namespace ConsoleRevisaoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a 1ª nota do aluno!");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a 2ª Nota do Aluno!");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if ( media >=7)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado!");
            }
            else
            {
                Console.WriteLine("Recupeção !");
            }
        }
    }
}
