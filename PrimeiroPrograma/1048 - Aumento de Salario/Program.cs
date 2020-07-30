using System;
using System.Globalization;

namespace _1048AumentodeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double percentualReajuste = 0.0;
            if(salario > 2000)
            {
                percentualReajuste = 4;
            }
            else if (salario < 400.01)
            {
                percentualReajuste = 15.0;
            }
            else if (salario > 400.00 && salario < 800.01)
            {
                percentualReajuste = 12.0;
            }
            else if (salario > 800.00 && salario < 1200.01)
            {
                percentualReajuste = 10.0;
            }
            else
            {
                percentualReajuste = 7.0;
            }

            double valorReajuste = percentualReajuste / 100.00 * salario;

            Console.WriteLine("Novo salario: " + (salario + valorReajuste).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentualReajuste.ToString());
        }
    }
}
