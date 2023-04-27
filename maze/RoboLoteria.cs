using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    public class RoboLoteria : IRobo
    {
        public Passo[] Passos { get; set; }
        public int IndicePassoAtual { get; set; } = 0;

        private Posicao _posicaoInicial;

        public RoboLoteria(int x, int y)
        {
            _posicaoInicial = new Posicao(x, y);
        }

        public Passo[] GeraPassos(Labirinto labirinto, int maxPassos = 100)
        {
            Random numAleatorio = new Random();
            var x = _posicaoInicial.X;
            var y = _posicaoInicial.Y;
            var listaDePassos = new List<Passo>();

            int valorInteiro = numAleatorio.Next(1, 4);
            if (labirinto.TaFora(x, y) == true)
            {
                return listaDePassos.ToArray();
            } else 
                do
                {
                    if (labirinto.EhCaminho(x, y) == true)
                    {
                        if (valorInteiro == 1)
                        {
                            y++;
                        }
                        else if (valorInteiro == 2)
                        {
                            y--;
                        }
                        else if (valorInteiro == 3)
                        {
                            x++;
                        }
                        else if (valorInteiro == 4)
                        {
                            x--;
                        }
                        listaDePassos.Add(new Passo(x, y));
                    }
                    return listaDePassos.ToArray();
                } while (!labirinto.TaFora(x, y));

        }
    }
}
