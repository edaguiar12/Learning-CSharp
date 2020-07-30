using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] dados = Console.ReadLine().Split(' ');

            A = int.Parse(dados[0]);
            B = int.Parse(dados[1]);
            C = int.Parse(dados[2]);
            D = int.Parse(dados[3]);

            if (B > C && D > A && C+D > A+B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
