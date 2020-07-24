using System;
using System.Globalization;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, raiz;
            string[] dados = new string[3];
            dados = Console.ReadLine().Split(" ");
            a = Convert.ToDouble(dados[0],CultureInfo.InvariantCulture);
            b = Convert.ToDouble(dados[1], CultureInfo.InvariantCulture);
            c = Convert.ToDouble(dados[2], CultureInfo.InvariantCulture);

            if(a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            { 
                delta = (b * b) - (4 * a * c);
                if(delta < 0)
                {
                    Console.WriteLine("Impossivel calcular");
                }
                else
                {
                    raiz = Math.Sqrt(delta);
                    x1 = ((-(b)) + raiz) / (2 * a);
                    x2 = ((-(b)) - raiz) / (2 * a);
                    Console.WriteLine("X1 = {0}", x1.ToString("F5").Replace(',','.'));
                    Console.WriteLine("X2 = {0}", x2.ToString("F5").Replace(',','.'));
                }

            }

        }
    }
}
