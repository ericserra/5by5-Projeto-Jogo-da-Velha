using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha_Eric_e_Fernando
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];
            int[,] Mapa = new int[3, 3];
            Console.WriteLine("Escolha uma das posições para começar a jogar\nTurno 1");
            Imprimir_jogo(matriz, Mapa);
            Console.ReadKey();
            
        }

        static void Imprimir_jogo(string[,] matriz, int[,] Mapa)
        {
            Console.WriteLine("Escolha uma das posições baseadas no mapa para fazer sua jogada!\n");
            int contador = 1;
            for (int i = 0; i < Mapa.GetLength(0); i++)
            {
                for (int j = 0; j < Mapa.GetLength(1); j++)
                {
                    Mapa[i, j] = contador;
                    contador++;
                    Console.Write("[" + Mapa[i, j] + "]");
                    if (j != Mapa.GetLength(1) - 1)
                    {
                        Console.Write("" + "\t|" + "");
                    }
                }
                if (i != Mapa.GetLength(0) - 1)
                {
                    Console.WriteLine("\n------------------------");
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]);
                    if (j != matriz.GetLength(1) - 1)
                    {
                        Console.Write("\t|");
                    }
                }
                if (i != matriz.GetLength(0) - 1)
                {
                    Console.WriteLine("\n------------------------");
                }
            }
        }
        static void verificarPosicoes(int[,] inteira, string[,] matriz, ref int jogada, int jogador )
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; i++)
                {
                    if ((jogada == inteira[i, j])&&(matriz==null)&&(jogador == 1))
                    {
                        matriz[i, j] = "X";
                        Imprimir_jogo(matriz, inteira);
                    }
                    else
                        if ((jogada == inteira[i, j]) && (matriz == null) && (jogador == 2))
                        {
                            matriz[i, j] = "X";
                            Imprimir_jogo(matriz, inteira);
                        }
                        else
                        {
                            Console.WriteLine("Posição invalida jogue novamente");
                            jogada = int.Parse(Console.ReadLine());
                            verificarPosicoes(inteira, matriz, ref jogada, jogador);
                        }



                }



            }
        }
        static void verificaStatus(int[,] numeros, int[] jogador1, int[] jogador2)
        {
            for(int i = 0; i < 2; i++)
                { 
                   

                }

        }

    }
}
