using System;

namespace _1046TempodeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dadosRecebidos = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(dadosRecebidos[0]);
            int horaFinal = int.Parse(dadosRecebidos[1]);
            int qtdHoras = 0;
            if (horaInicial  > horaFinal)
            {
                qtdHoras = (24 - horaInicial) + horaFinal;
            }
            else if (horaInicial == horaFinal)
            {
                qtdHoras = 24;
            }
            else
            {
                qtdHoras = horaFinal - horaInicial;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", qtdHoras);

        }
    }
}
