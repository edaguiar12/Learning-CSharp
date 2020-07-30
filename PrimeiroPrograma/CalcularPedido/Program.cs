using System;
using System.Globalization;

namespace CalcularPedidoWithArrayPreco
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dadosDigitados;
            int quantidade;
            int codigo;
            double valorTotal;
            double subtotal;
            string[,] cardapio = new string[6, 2] { {"","" }, { "1", "4.00" }, { "2", "4.50" }, { "3", "5.00" }, { "4", "2.00" }, { "5", "1.50" } };

            Console.WriteLine("Digite o código e a quantidade");
            dadosDigitados = Console.ReadLine().Split(' ');
            codigo = int.Parse(dadosDigitados[0]);
            quantidade = int.Parse(dadosDigitados[1]);
            subtotal = Double.Parse(cardapio[codigo, 1], CultureInfo.InvariantCulture);
            valorTotal = quantidade * subtotal;
            Console.WriteLine("Total: R$ "+ valorTotal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
