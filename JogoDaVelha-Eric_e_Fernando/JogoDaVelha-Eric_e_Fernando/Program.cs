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
            string[,] posicoes = new string[3, 3];
            for (int i = 0; i < posicoes.GetLength(0); i++)
            {
                for (int j = 0; j < posicoes.GetLength(1); j++)
                {
                    Console.WriteLine("[" + i + "," + j + "]");
                    Console.ReadLine();
                }
            }
            for (int i = 0; i < posicoes.GetLength(0); i++)
            {
                for (int j = 0; j < posicoes.GetLength(1); j++)
                {
                    Console.Write(posicoes[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
