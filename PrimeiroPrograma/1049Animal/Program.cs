using System;

namespace _1049Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipoAnimal = Console.ReadLine();
            string classeAnimal = Console.ReadLine();
            string alimentacaoAnimal = Console.ReadLine();

            string animalEscolhido;

            if (tipoAnimal == "vertebrado")
            {
                if (classeAnimal == "ave")
                {
                    if (alimentacaoAnimal == "carnivoro")
                    {
                        animalEscolhido = "aguia";
                    }
                    else
                    {
                        animalEscolhido = "pomba";
                    }
                }
                else
                {
                    if (alimentacaoAnimal == "onivoro")
                    {
                        animalEscolhido = "homem";
                    }
                    else
                    {
                        animalEscolhido = "vaca";
                    }
                }
            }
            else
            {
                if (classeAnimal == "inseto")
                {
                    if (alimentacaoAnimal == "hematofago")
                    {
                        animalEscolhido = "pulga";
                    }
                    else
                    {
                        animalEscolhido = "lagarta";
                    }
                }
                else
                {
                    if (alimentacaoAnimal == "hematofago")
                    {
                        animalEscolhido = "sanguessuga";
                    }
                    else
                    {
                        animalEscolhido = "minhoca";
                    }
                }
            }
            Console.WriteLine(animalEscolhido);
        }
    }
}
