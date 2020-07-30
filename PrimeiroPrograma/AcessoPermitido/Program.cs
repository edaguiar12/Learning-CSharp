using System;

namespace AcessoPermitido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha...");
            string senha = Console.ReadLine();
            while (senha != "2002")
            {
                Console.WriteLine("Senha Invalida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
