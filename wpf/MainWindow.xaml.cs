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
        private int tamanho = 10;
        private bool jaFoi = false;
        private RoboVerde roboVerde = new RoboVerde(1, 1);
        private RoboVermelho roboVermelho = new RoboVermelho(1, 1);
        private RoboLoteria roboLoteria = new RoboLoteria(1, 1);
        private RoboSemCaminho roboSemCaminho = new maze.RoboSemCaminho(1, 1);
        

        public MainWindow()
        {
            InitializeComponent();
            GerarPassosRoboLoteria();

            CompositionTarget.Rendering += Draw;
        }
        public int[][] MatrizDoArquivo()
        {
            var preto = Brushes.Black;
            var branco = Brushes.White;
            var linhas = File.ReadAllLines("./labirinto1.txt");

            Console.WriteLine(linhas);

            console.Text = string.Join('\n', linhas);


            var dimensao = linhas[0].Split(" ");
            var altura = int.Parse(dimensao[1]);
            var largura = int.Parse(dimensao[2]);

            int[][] matrizDoArquivo = new int[altura][];
            for (int y = 0; y < altura; y++)
            {
                var linhaAtual = linhas[y + 3];
                matrizDoArquivo[y] = new int[largura];
                for (int x = 0; x < largura; x++)
                {
                    if (linhaAtual[x] == '*')
                    {
                        matrizDoArquivo[y][x] = 1;
                    }
                    else
                    {
                        matrizDoArquivo[y][x] = 0;
                    }

                }
            }

            //for (int i = 0; i < matrizDoArquivo.Length; i++)
            //{
            //    for (int j = 0; j < matrizDoArquivo[i].Length; j++)
            //    {
            //        var posicaoLado = tamanho * j;
            //        var posicaoCima = tamanho * i;
            //        if (matrizDoArquivo[i][j] == 1)
            //        {
            //            var quadrado = CriaQuadrado(tamanho, preto);
            //            Canvas.SetLeft(quadrado, posicaoLado);
            //            Canvas.SetTop(quadrado, posicaoCima);
            //            quadrinho.Children.Add(quadrado);
            //        }
            //        else
            //        {
            //            var quadrado = CriaQuadrado(tamanho, branco);
            //            Canvas.SetLeft(quadrado, posicaoLado);
            //            Canvas.SetTop(quadrado, posicaoCima);
            //            quadrinho.Children.Add(quadrado);
            //        }
            //    }
            //}
            return matrizDoArquivo;
        }


        private void GerarPassosRoboLoteria()
        {
            var labirinto = new Labirinto(MatrizDoArquivo(), 15, 44);

            roboSemCaminho.Passos = roboSemCaminho.GeraPassos(labirinto);
        }
        

        private void Draw(object sender, EventArgs e)
        {
            var tempoSalvo = TimeSpan.FromTicks(time.Ticks);
            var tempoAtual = TimeSpan.FromTicks(DateTime.Now.Ticks);

            if (tempoAtual.Subtract(tempoSalvo).Milliseconds > 300 || time == default)
            {
                ExecutaAcao();
                time = DateTime.Now;
            }
        }

        private void ExecutaAcao()
        {
            //ImprimeAntigo();
            //    if (roboVerde.PassosRoboVerde.Length == roboVerde.IndicePassoAtualRoboVerde)
            //        MessageBox.Show("Congrats bro!!");
            //    else
            //    {
            //        var passoAtualRoboVerde = roboVerde.[roboVerde.IndicePassoAtualRoboVerde++];


            //        ImprimeMatriz(tamanho, roboVerde.MatrizRoboVerde);
            //        ImprimeQuadrado(passoAtualRoboVerde.X, passoAtualRoboVerde.Y, Brushes.Green);
            //    }

            if (roboSemCaminho.Passos.Length == roboSemCaminho.IndicePassoAtual)
                MessageBox.Show("Congrats bro!!");
            else
            {
                var passoAtual = roboSemCaminho.Passos[roboSemCaminho.IndicePassoAtual++];


                ImprimeMatriz(tamanho, MatrizDoArquivo());
                ImprimeImagen(passoAtual.X, passoAtual.Y);
            }
        }

        private void ImprimeQuadrado(int x, int y, SolidColorBrush cor)
        {
            var quadrado = CriaQuadrado(tamanho, cor);
            Canvas.SetLeft(quadrado, x * tamanho);
            Canvas.SetTop(quadrado, y * tamanho);
            quadrinho.Children.Add(quadrado);
        }

        private void ImprimeImagen(int x, int y)
        {
            var imagem = CriaImagem(@"C:\projetos-cris\estrutura-de-dados\wpf\imagens\C3PO.jpg", tamanho);
            Canvas.SetLeft(imagem, x * tamanho);
            Canvas.SetTop(imagem, y * tamanho);
            quadrinho.Children.Add(imagem);
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
                        var imagem = CriaImagem(@"C:\projetos-cris\estrutura-de-dados\wpf\imagens\brick.jpg", tamanho);
                        Canvas.SetLeft(imagem, posicaoLado);
                        Canvas.SetTop(imagem, posicaoCima);
                        quadrinho.Children.Add(imagem);

                    }
                    else
                    {
                        var imagem = CriaImagem(@"C:\projetos-cris\estrutura-de-dados\wpf\imagens\sand.jpg", tamanho);
                        Canvas.SetLeft(imagem, posicaoLado);
                        Canvas.SetTop(imagem, posicaoCima);
                        quadrinho.Children.Add(imagem);
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

        private static Image CriaImagem(string srcImage, int tamanho)
        {
            var imagem = new Image();

            imagem.Source = new BitmapImage(new Uri(srcImage));

            imagem.Height = tamanho;
            imagem.Width = tamanho;

            return imagem;
        }
    }
}
