﻿using System;
using tabuleiro;
using xadrez;

namespace JogoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
