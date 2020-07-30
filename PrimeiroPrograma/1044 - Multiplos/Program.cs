using System;

namespace _1044Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dadosRecebidos = Console.ReadLine().Split(' ');

            int A = int.Parse(dadosRecebidos[0]);
            int B = int.Parse(dadosRecebidos[1]);

            string mensagem;
            if (A == B)
            {
                mensagem = "Sao Multiplos";
            }
            else if (A < B)
            {
                mensagem = B % A == 0 ? "Sao Multiplos" : "Nao sao Multiplos";
            }
            else
            {
                mensagem = A % B == 0 ? "Sao Multiplos" : "Nao sao Multiplos";
            }

            Console.WriteLine(mensagem);

        }
    }
}
