using TabuleiroNamespace;
using System;
using System.Drawing;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
