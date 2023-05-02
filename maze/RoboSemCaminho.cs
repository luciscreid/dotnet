using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class RoboSemCaminho : IRobo
    {

        public Passo[] Passos { get; set; }
        public int IndicePassoAtual { get; set; } = 0;

        private Posicao _posicaoInicial;

        public RoboSemCaminho(int x, int y)
        {
            _posicaoInicial = new Posicao(x, y);
        }
        public Passo[] GeraPassos(Labirinto labirinto, int maxPassos = 100)
        {
            var x = _posicaoInicial.X;
            var y = _posicaoInicial.Y;
            var listaDePassos = new List<Passo>();


            if (labirinto.TaFora(x, y) == true)
            {
                return listaDePassos.ToArray();
            }
            while (!labirinto.TaFora(x, y))
            {
                x++;
                if (labirinto.EhParede(x, y))
                    x--;
                y++;
                if (labirinto.EhParede(x, y))
                    y--;
                
                listaDePassos.Add(new Passo(x, y));
                if (maxPassos < listaDePassos.Count)
                    break;
            }
            return listaDePassos.ToArray();
        }
    }
}
