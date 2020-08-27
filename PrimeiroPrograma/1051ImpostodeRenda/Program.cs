using System;
using System.Globalization;

namespace _1051ImpostodeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salariocontribuicao = 0.0;
            double impostoDevido = 0.0;

            if (salarioinicial < 2000.01)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                salariocontribuicao = salarioinicial - 2000.00;
                if (salariocontribuicao < 1000.00)
                {
                    impostoDevido += salariocontribuicao * 0.08;
                }
                else
                {
                    impostoDevido += 1000.00 * 0.08;
                    salariocontribuicao -= 1000.00;
                    if (salariocontribuicao < 1500.00)
                    {
                        impostoDevido += salariocontribuicao * 0.18;
                    }
                    else
                    {
                        impostoDevido += 1500.00 * 0.18;
                        salariocontribuicao -= 1500.00;
                        if (salariocontribuicao > 0)
                        {
                            impostoDevido += salariocontribuicao * 0.28;
                        }
                    }
                }
                Console.WriteLine("R$ " + impostoDevido.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
