using System;

namespace Exercicio_SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEsse programa consiste em exibir uma sequência de números pares começando com 0 e tendo como fim o número digitado");
            Console.Write("Para iniciá-lo digite um número:  ");
            int numerodigitado = Convert.ToInt32(Console.ReadLine());


            if(numerodigitado >=1)
            {
                int n = 0;
                while(n<= numerodigitado)
                {
                  Console.WriteLine ($"{n}");
                  n += 2;
                }
            }
            else
            {
                Console.WriteLine("O número digitado não é valido!");
            }
          

        }
    }
}
