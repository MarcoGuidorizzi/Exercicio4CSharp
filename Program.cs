using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, horas, resto; ;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = (N % 3600) / 60;

            Console.WriteLine("{0}:{1}:{2}", horas, resto, N % 60);


            Console.ReadLine();
        }
    }
}