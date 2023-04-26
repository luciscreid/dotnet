using maze;
using System;
using System.Collections.Generic;
using System.IO;
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
        private DateTime time;
        private int xRobo;
        private int yRobo;
        private int tamanho = 20;
        private bool jaFoi = false;
        private Passo[] passosRoboVerde;
        private int indicePassoAtualRoboVerde = 0;
        private int[][] matrizRoboVerde = new int[][]
            {
                new int[] {1,1,1,1,1,1,1},
                new int[] {1,0,0,0,0,0,0},
                new int[] {1,1,1,1,1,1,1},
            };

        public MainWindow()
        {
            InitializeComponent();
            RoboVerde();

            CompositionTarget.Rendering += Draw;
        }

        private void RoboVerde()
        {
            var labirinto = new Labirinto(matrizRoboVerde, 3, 7);
            var robo = new RoboVerde(1, 1);

            passosRoboVerde = robo.GeraPassos(labirinto);
        }

        private void Draw(object sender, EventArgs e)
        {
            var tempoSalvo = TimeSpan.FromTicks(time.Ticks);
            var tempoAtual = TimeSpan.FromTicks(DateTime.Now.Ticks);

            if (tempoAtual.Subtract(tempoSalvo).Seconds > 1 || time == default)
            {
                ExecutaAcao();
                time = DateTime.Now;
            }
        }

        private void ExecutaAcao()
        {
            //ImprimeAntigo();
            if (passosRoboVerde.Length == indicePassoAtualRoboVerde)
                MessageBox.Show("Congrats bro!!");
            else
            {
                var passoAtualRoboVerde = passosRoboVerde[indicePassoAtualRoboVerde++];


                ImprimeMatriz(tamanho, matrizRoboVerde);
                ImprimeQuadrado(passoAtualRoboVerde.X, passoAtualRoboVerde.Y, Brushes.Green);
            }
        }

        private void ImprimeQuadrado(int x, int y, SolidColorBrush cor)
        {
            var quadrado = CriaQuadrado(tamanho, cor);
            Canvas.SetLeft(quadrado, x * tamanho);
            Canvas.SetTop(quadrado, y * tamanho);
            quadrinho.Children.Add(quadrado);
        }

        private void ImprimeMatriz(int tamanho, int[][] matrizLab)
        {
            for (int i = 0; i < matrizLab.Length; i++)
            {
                for (int j = 0; j < matrizLab[i].Length; j++)
                {
                    var posicaoLado = tamanho * j;
                    var posicaoCima = tamanho * i;
                    if (matrizLab[i][j] == 1)
                    {
                        var quadrado = CriaQuadrado(tamanho, Brushes.Black);
                        Canvas.SetLeft(quadrado, posicaoLado);
                        Canvas.SetTop(quadrado, posicaoCima);
                        quadrinho.Children.Add(quadrado);

                    }
                    else
                    {
                        var quadrado = CriaQuadrado(tamanho, Brushes.White);
                        Canvas.SetLeft(quadrado, posicaoLado);
                        Canvas.SetTop(quadrado, posicaoCima);
                        quadrinho.Children.Add(quadrado);
                    }
                }
            }
        }

        private static int[][] ImportaMatrizDoArquivo(string[] linhas, int altura, int largura)
        {
            int[][] matrizLab = new int[altura][];
            for (int y = 0; y < altura; y++)
            {
                var linhaAtual = linhas[y + 3];
                matrizLab[y] = new int[largura];
                for (int x = 0; x < largura; x++)
                {
                    if (linhaAtual[x] == '*')
                    {
                        matrizLab[y][x] = 1;
                    }
                    else
                    {
                        matrizLab[y][x] = 0;
                    }

                }
            }

            return matrizLab;
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
