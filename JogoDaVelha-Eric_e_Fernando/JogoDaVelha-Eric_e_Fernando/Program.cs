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



            Imprimir_logo(matriz);
            Console.ReadKey();
        }

        static void Imprimir_logo(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]);
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
                        Imprimir_logo(matriz, inteira);
                    }
                    else
                        if ((jogada == inteira[i, j]) && (matriz == null) && (jogador == 2))
                        {
                            matriz[i, j] = "X";
                            Imprimir_logo(matriz, inteira);
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
