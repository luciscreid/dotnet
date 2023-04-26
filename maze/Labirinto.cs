
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class Labirinto
    {
        private int[][] matriz;
       
        public Labirinto(int[][] matriz, int altura, int largura)
        {
            this.matriz = matriz;
            this.Altura = altura;
            this.Largura = largura;
        }

        public int Altura { get; private set; }

        public int Largura { get; private set; }

        internal bool TaFora(int x, int y)
        {
            if (x >= Largura
                     || x <= -1
                     || y >= Altura
                     || y <= -1)
            {
                return true;
            }
            return false;
        }

        public bool EhParede(int x, int y)
        {
            if (TaFora(x, y))
            {
                return false;
            }
            else if (matriz[y][x] == 1)
            {
                return true;
            }
            return false;
        }
        public bool EhCaminho(int x, int y)
        {
            if (TaFora(x, y))
            {
                return false;
            }
            else if (matriz[y][x] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
