using System;
using System.Diagnostics;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matriz = new int[3][];

            matriz[0] = new int[3];
            matriz[0][0] = 0;
            matriz[0][1] = 1;
            matriz[0][2] = 2;

            matriz[0] = new int[3] { 0, 1, 2 };
            matriz[1] = new int[3] { 3, 4, 5 };
            matriz[2] = new int[3] { 6, 7, 8 };

            Console.Write($"{matriz[0][0]}, {matriz[0][1]}, {matriz[0][2]}\n");
            Console.Write($"{matriz[1][0]}, {matriz[1][1]}, {matriz[1][2]}\n");
            Console.Write($"{matriz[2][0]}, {matriz[2][1]}, {matriz[2][2]}\n");

            int[][] matrizMaior = new int[10][];

            
            
            for (int y = 0; y < matrizMaior.Length; y++)
            {
                matrizMaior[y] = new int[10];
                for (int x = 0; x < matrizMaior.Length; x++)
                {
                    matrizMaior[y][x] = y + x;
                    Console.Write($"V:{matrizMaior[y][x]},Y:{y},X:{x}  ");
                    
                }
                Console.WriteLine();
            }
            
            
            Console.WriteLine("Deu bom!!");



        }
    }
}
