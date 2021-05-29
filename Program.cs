using System;

namespace subtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroNumero, segundoNumero;
            int num1, num2, subtracao;

            Console.Write("Por favor digite o primeiro número: ");
            primeiroNumero = Console.ReadLine();

            Console.Write("Por favor digite o segundo número: ");
            segundoNumero = Console.ReadLine();

            num1 = Int32.Parse(primeiroNumero);
            num2 = Int32.Parse(segundoNumero);

            subtracao = num1 + num2;

            Console.WriteLine("O resultado da soma dos dois números é: ", subtracao);
        }
    }
}
