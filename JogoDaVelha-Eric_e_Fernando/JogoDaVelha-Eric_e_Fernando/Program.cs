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
            int[,] matrizInteira = new int[3, 3];
            matriz[0, 0] = "1";
            matriz[0, 1] = "2";
            matriz[0, 2] = "3";
            matriz[1, 0] = "4";
            matriz[1, 1] = "5";
            matriz[1, 2] = "6";
            matriz[2, 0] = "7";
            matriz[2, 1] = "8";
            matriz[2, 2] = "9";
            Console.WriteLine("Escolha uma das posições para começar a jogar\n");
            Imprimir_logo(matriz, matrizInteira);
            Console.ReadKey();
            
        }

        static void Imprimir_logo(string[,] matriz, int[,] matrizInteira)
        {
            
            Console.WriteLine("_"+matriz[0,0]+"_||_"+matriz[0,1]+"_||_"+matriz[0,2]+"_");
            Console.WriteLine("_"+matriz[1,0]+"_||_"+matriz[1,1]+"_||_"+matriz[1,2]+"_");
            Console.WriteLine("_"+matriz[2,0]+"_||_"+matriz[2,1]+"_||_"+matriz[2,2]+"_");
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
