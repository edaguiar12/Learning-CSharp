using System;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos valores faremos a leitura");
            int N = Convert.ToInt32(Console.ReadLine());
            int contadorDeNumeros = N;
            Console.WriteLine("Agora digite valor por valor, e entre cada um deles digite o enter");
            int dentro = 0, fora = 0;
            for (int i = 0; i < N; i++)
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
                contadorDeNumeros--;
                Console.WriteLine("Faltam {0} números!", contadorDeNumeros);
            }
            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);
        }
    }
}
