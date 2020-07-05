using TabuleiroNamespace;

namespace XadrezNamespace
{
    class Dama : Peca
    {
        public Dama(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha, pos.Coluna - 1); // faz ir a esquerda
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha, pos.Coluna + 1); // faz ir a direita
            }

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha - 1, pos.Coluna); // faz subir a linha
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha + 1, pos.Coluna); // faz descer a linha
            }

            //NO
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //SE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //SO
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;

                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "D";
        }
    }
}
