using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

        }
    }
}