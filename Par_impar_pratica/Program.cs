using System;

namespace Par_impar_pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, somar;

            Console.WriteLine(" Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            somar = (numero1 + numero2);

            if ((numero1 + numero2) % 2 == 0) 
            {
                Console.WriteLine("O resultado da soma é: " + somar+ " Nº Par.");
            }
            else       
            {
                Console.WriteLine("O resultado da soma é: " + somar + " Nº Ímpar.");
            }

        }
    }
}
