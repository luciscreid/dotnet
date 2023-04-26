using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class RoboVerde : IRobo
    {
        private Posicao _posicaoInicial;

        public RoboVerde(int x, int y)
        {
            _posicaoInicial = new Posicao(x, y);
        }

        public Passo[] GeraPassos(Labirinto labirinto, int maxPassos = 50)
        {
            var x = _posicaoInicial.X;
            var y = _posicaoInicial.Y;
            var listaDePassos = new List<Passo>();

            if (labirinto.TaFora(x, y))
                return listaDePassos.ToArray();

            do
            {
                if (maxPassos < listaDePassos.Count)
                    break;

                listaDePassos.Add(new Passo(x, y));

                x++;
            } while (!labirinto.TaFora(x, y));

            return listaDePassos.ToArray();
        }
    }
}
