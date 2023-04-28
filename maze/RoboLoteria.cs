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

        public Passo[] GeraPassos(Labirinto labirinto, int maxPassos = 500)
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
                Random numAleatorio = new Random();
                int valorInteiro = numAleatorio.Next(1, 5);
                if (valorInteiro == 1)
                {
                    y++;
                    if (labirinto.EhParede(x, y))
                    {
                        y--;
                    }
                    }
                else if (valorInteiro == 2)
                {
                    y--;
                    if (labirinto.EhParede(x, y))
                    {
                        y++;
                    }
                }
                else if (valorInteiro == 3)
                {
                    x++;
                    if (labirinto.EhParede(x, y))
                    {
                        x--;
                    }
                }
                else if (valorInteiro == 4)
                {
                    x--;
                    if (labirinto.EhParede(x, y))
                    {
                        x++;
                    }
                }

                listaDePassos.Add(new Passo(x, y));
                if (maxPassos < listaDePassos.Count)
                    break;
            }
            return listaDePassos.ToArray();
        }
    }
}




















































































































//if (labirinto.EhParede(x, y))
//{
//    if (valorInteiro == 1)
//    {
//        y--;
//    }
//    else if (valorInteiro == 2)
//    {
//        y++;
//    }
//    else if (valorInteiro == 3)
//    {
//        x--;
//    }
//    else if (valorInteiro == 4)
//    {
//        x++;
//    }
//}