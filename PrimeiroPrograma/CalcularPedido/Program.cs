using System;
using System.Globalization;

namespace CalcularPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            string dadosDigitados;
            int quantidade;
            int codigo;
            double valorTotal;
            string[,] cardapio = new string[6, 2] { {"","" }, { "1", "4.00" }, { "2", "4.50" }, { "3", "5.00" }, { "4", "2.00" }, { "5", "1.50" } };

            double retornarPreco(string[,] tabeladePreco, int codigo)
            {
                return Convert.ToDouble(tabeladePreco[codigo,1], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Digite o código e a quantidade");
            dadosDigitados = Console.ReadLine();
            codigo = (int)Char.GetNumericValue(dadosDigitados[0]);
            quantidade = (int)Char.GetNumericValue(dadosDigitados[2]);
            valorTotal = quantidade * retornarPreco(cardapio, codigo);

            Console.WriteLine("Total: R$ {0}", valorTotal);

        }
    }
}
