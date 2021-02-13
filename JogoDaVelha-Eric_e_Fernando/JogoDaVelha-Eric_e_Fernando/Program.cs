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
        static void verificarPosicoes()
        {

        }
        static int verificaStatus()
        {
            if (true)
            {
                return 0;
            }
            else if (1 < 2)
            {
                return 1;
            }
            else
            {
                if (2 < 3)
                {
                    return 2;
                }
            }

        }
    }
}
