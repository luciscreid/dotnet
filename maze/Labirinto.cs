
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
            if (x > Largura
                     || x <= -1
                     || y > Altura
                     || y <= -1)
            {
                return true;
            }
            return false;
        }

        public bool EhParede(Posicao posicao)
        {
            if (posicao.X > Altura
                     || posicao.X <= -1
                     || posicao.Y > Largura
                     || posicao.Y <= -1
                     || matriz[posicao.Y][posicao.X] == 0)
            {
                return false;
            }
            else if (matriz[posicao.Y][posicao.X] == 1)
            {
                return true;
            }
            return false;
        }
        public bool EhCaminho(Posicao posicao)
        {
            if (posicao.X > Altura
                     || posicao.X <= -1
                     || posicao.Y > Largura
                     || posicao.Y <= -1
                     || matriz[posicao.Y][posicao.X] == 1)
            {
                return false;
            }
            else if (matriz[posicao.Y][posicao.X] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
