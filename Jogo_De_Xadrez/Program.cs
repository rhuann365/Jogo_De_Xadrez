﻿using System;
using Tabuleiro;


namespace jogo_de_xadrez {
    class Tela {
        static void Main(string[] args) {

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadLine();

        }
    }
}
