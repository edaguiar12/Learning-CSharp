using System;

namespace _1042SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');

            int n1, n2, n3;
            int primeiro, segundo, terceiro;

            n1 = int.Parse(dados[0]);
            n2 = int.Parse(dados[1]);
            n3 = int.Parse(dados[2]);

            primeiro = n1;
            segundo = n2;
            terceiro = n3;

            if (n1 < n2)
            {
                if(n1 < n3)
                {
                    primeiro = n1;
                    if(n2 < n3)
                    {
                        segundo = n2;
                        else
                        {
                            terceiro = n3;
                        }
                    }
                }
                else
                {
                    
                }
            }

            if (n1 < n2 && n1 < n3)
            {
                primeiro = n1;
                if (n2 < n3)
                {
                    segundo = n2;
                    terceiro = n3;
                }
                else
                {
                    segundo = n3;
                    terceiro = n2;
                }
            }
            else if (n2 < n1 && n2 < n3)
            {
                primeiro = n2;
                if (n1 < n3)
                {
                    segundo = n1;
                    terceiro = n3;
                }
                else
                {
                    segundo = n3;
                    terceiro = n1;
                }
            }
            else if (n3 < n1 && n3 < n2)
            {
                primeiro = n3;
                if (n1 < n2)
                {
                    segundo = n1;
                    terceiro = n2;
                }
                else
                {
                    segundo = n2;
                    terceiro = n3;
                }
            }
            else
            {
                primeiro = n1;
                segundo = n2;
                terceiro = n3;
            }
            Console.WriteLine(primeiro.ToString());
            Console.WriteLine(segundo.ToString());
            Console.WriteLine(terceiro.ToString());
            Console.WriteLine();
            Console.WriteLine(n1.ToString());
            Console.WriteLine(n2.ToString());
            Console.WriteLine(n3.ToString());
        }
    }
}
