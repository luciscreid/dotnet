using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class RoboVermelho : IRobo
    {
        public Passo[] Passos { get; set; }
        public int IndicePassoAtual { get; set; } = 0;
        public int[][] Matriz { get; } = new int[][]
        {
            new int[] { 1, 1, 1, 1, 1, 1, 1 },
            new int[] { 1, 0, 0, 0, 0, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 0, 1 },
        };
        private Posicao _posicaoInicial;

        public RoboVermelho(int x, int y)
        {
            _posicaoInicial = new Posicao(x, y);
        }

        public Passo[] GeraPassos(Labirinto labirinto, int maxPassos = 100)
        {
            var x = _posicaoInicial.X;
            var y = _posicaoInicial.Y;
            var listaDePassos = new List<Passo>();

            if (labirinto.TaFora(x, y))
            {
                return listaDePassos.ToArray();
            }
            while (labirinto.TaFora(x, y) == false)
            {
                if (labirinto.EhParede(x, y) == true)
                {
                    x--;
                    y++;
                }
                
                listaDePassos.Add(new Passo(x, y));

                x++;
            }


            return listaDePassos.ToArray();
        }
    }
}
