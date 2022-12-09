﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas=linhas;
            Colunas=colunas;
            pecas = new Peca[Linhas,Colunas];
        }

        //Método p/ acesso a matriz Peça
        public Peca peca(int linha,int coluna)
        {
            return pecas[linha,coluna];
        }

        public void colocarPeca(Peca p,Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;    
        }
    }
}
