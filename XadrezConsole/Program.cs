
using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 2));

                Tela.ImprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {

            }
            
        }

        
    }
}
