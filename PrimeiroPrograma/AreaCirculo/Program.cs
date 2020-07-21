using System;
using System.Globalization;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi, area;

            Console.WriteLine("Passe o valor do Raio");
            raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            pi = 3.14159;
            area = pi * (raio * raio);
            Console.WriteLine("A={0}",area.ToString("F4").Replace(',','.'));
        }
    }
}
