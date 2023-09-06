using System;
using Tabuleiro;

namespace Jogo_De_Xadrez.Tabuleiro {
    class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
