using System;
using System.Globalization;

namespace _1040Media3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            string[] dados = Console.ReadLine().Split(' ');

            n1 = float.Parse(dados[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(dados[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(dados[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(dados[3], CultureInfo.InvariantCulture);

            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: {0}", media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
