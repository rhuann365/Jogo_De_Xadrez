﻿using System;
using Tabuleiro;

namespace Jogo_De_Xadrez.Tabuleiro {
     class Peca {

        public Posicao posicao {  get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) {

            this.posicao = posicao;
            this.tab = tabuleiro;
            this.cor = cor;
            this.qteMovimentos = 0;
        }



    }
}
