﻿using System;
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

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        var posicaoLado = tamanho * j;
            //        var posicaoCima = tamanho * i;
            //        if (matriz[i][j] == 1)
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
            var linhas = File.ReadAllLines("./labirinto.txt");

            Console.WriteLine(linhas);

            console.Text = string.Join('\n', linhas);


            var dimensao = linhas[0].Split(" ");
            var altura = int.Parse(dimensao[1]);
            var largura = int.Parse(dimensao[2]);

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

            for (int i = 0; i < matrizLab.Length; i++)
            {
                for (int j = 0; j < matrizLab[i].Length; j++)
                {
                    var posicaoLado = tamanho * j;
                    var posicaoCima = tamanho * i;
                    if (matrizLab[i][j] == 1)
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
