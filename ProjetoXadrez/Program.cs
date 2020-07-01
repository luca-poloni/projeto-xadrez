using System;
using TabuleiroNamespace;
using XadrezNamespace;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                //tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(0, 0));
                //tabuleiro.ColocarPeca(new Torre(Cor.Preta, tabuleiro), new Posicao(1, 9));
                //tabuleiro.ColocarPeca(new Rei(Cor.Preta, tabuleiro), new Posicao(2, 4));

                //Tela.ImprimirTabuleiro(tabuleiro);

                PosicaoXadrez pos = new PosicaoXadrez('c',7);
                Console.WriteLine(pos.ToPosicao());
                Console.WriteLine(pos);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
