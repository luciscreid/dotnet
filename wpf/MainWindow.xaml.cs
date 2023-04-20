using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var tamanho = 20;
            var preto = Brushes.Black;
            var branco = Brushes.White;
            //var quadrado = CriaQuadrado(tamanho, preto);
            //var quadradodolado = CriaQuadrado(tamanho, preto);

            var matriz = new int[][]
            {
                new int[] {1,1,1,1,1,1,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,1,1,1,1,1,1},
            };

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    var posicaoLado = tamanho * j;
                    var posicaoCima = tamanho * i;
                    if (matriz[i][j] == 1)
                    {
                        var quadrado = CriaQuadrado(tamanho, preto);
                        Canvas.SetLeft(quadrado, posicaoLado);
                        Canvas.SetTop(quadrado, posicaoCima);
                        quadrinho.Children.Add(quadrado);

                    }
                    else
                    {
                        var quadrado = CriaQuadrado(tamanho, branco);
                        Canvas.SetLeft(quadrado, posicaoLado);
                        Canvas.SetTop(quadrado, posicaoCima);
                        quadrinho.Children.Add(quadrado);
                    }
                }
            }


            //Canvas.SetLeft(quadradodolado, 20);
            //Canvas.SetTop(quadradodolado, 20);


            //quadrinho.Children.Add(quadrado);
            //quadrinho.Children.Add(quadradodolado);
        }

        private static Rectangle CriaQuadrado(int tamanho, SolidColorBrush cor)
        {
            var quadrado = new Rectangle();

            quadrado.Width = tamanho;
            quadrado.Height = tamanho;
            quadrado.Fill = cor;
            return quadrado;
        }
    }
}
