using System;
using System.Globalization;

namespace ProgramaTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos fazer uma venda?");
            Console.WriteLine("Digite, separado por espaços o código da peça, a quantidade a ser comprada e o valor unitário. " +
                "Ou, se desejar sair, digite 0");
            double valorTotal = 0.0;
            for (int i = 0; i < 2; i++)
            {
                string[] produtos = Console.ReadLine().Split(" ");
                int quantidade = Convert.ToInt32(produtos[1]);
                double valorUnitario = Convert.ToDouble(produtos[2], CultureInfo.InvariantCulture);
                valorTotal += (quantidade * valorUnitario);
            }
            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
