using System;

namespace _1037Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorQualquer = Double.Parse(Console.ReadLine(),System.Globalization.CultureInfo.InvariantCulture);
            string mensagem = "";

            if(valorQualquer < 0.0 || valorQualquer > 100.000000000000)
            {
                mensagem = "Fora de intervalo";
            }else if (valorQualquer >= 0.0 && valorQualquer <= 25.0)
            {
                mensagem = "Intervalo [0,25]";
            }
            else if (valorQualquer >= 25.000001 && valorQualquer <= 50.0000000)
            {
                mensagem = "Intervalo (25,50]";
            }
            else if (valorQualquer >= 50.000001 && valorQualquer <= 75.0000000)
            {
                mensagem = "Intervalo (50,75]";
            }
            else
            {
                mensagem = "Intervalo (75,100]";
            }
            Console.WriteLine(mensagem);

        }
    }
}
