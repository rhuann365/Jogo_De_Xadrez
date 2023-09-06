using System;
using System.Net.Http.Headers;
using Tabuleiro;

namespace Jogo_De_Xadrez.Tabuleiro {
    class Tela { 
           
        public static void imprimirTabuleiro(Tabuleiro tabuleiro) {

            for (int i = 0; i < tabuleiro.linhas; i++) {
                for (int j = 0; j < tabuleiro.colunas; j++) {
                    if (tabuleiro.peca(i,j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tabuleiro.peca(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}