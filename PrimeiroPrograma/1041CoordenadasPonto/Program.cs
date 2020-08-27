using System;
using System.Globalization;

namespace _1041CoordenadasPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] dados = Console.ReadLine().Split(' ');
            x = double.Parse(dados[0], CultureInfo.InvariantCulture);
            y = double.Parse(dados[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if(x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }
    }
}
