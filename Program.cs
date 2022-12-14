using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Preta), new Posicao(0, 2));

            tab.colocarPeca(new Torre(tab, tabuleiro.Enums.Cor.Branca), new Posicao(3, 5));
            tab.colocarPeca(new Rei(tab, tabuleiro.Enums.Cor.Branca), new Posicao(5,5));

            Tela.imprimirTabuleiro(tab);
        }
    }
}
