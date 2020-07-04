using TabuleiroNamespace;

namespace XadrezNamespace
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna +1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha +2, Posicao.Coluna +1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);

            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    break;
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
            return "C";
        }
    }
}
