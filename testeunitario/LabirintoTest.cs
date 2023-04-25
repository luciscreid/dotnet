using maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testeunitario
{
    public class LabirintoTest
    {
        [Fact]
        public void Labirinto()
        {
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

            var lab = new Labirinto(matriz, 9, 7);

            Assert.NotNull(lab);
            Assert.NotEqual(default, lab.Altura);
            Assert.NotEqual(default, lab.Largura);
        }

        [Fact]
        public void Labirinto_EhParede()
        {
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

            var lab = new Labirinto(matriz, 9, 7);

            Assert.NotNull(lab);
            Assert.True(lab.EhParede(new Posicao(0,0)));
            Assert.False(lab.EhParede(new Posicao(1, 1)));
        }

        [Fact]
        public void Labirinto_EhParedeExtremos()
        {
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

            var lab = new Labirinto(matriz, 9, 7);

            Assert.NotNull(lab);
            Assert.False(lab.EhParede(new Posicao(20, 30)));
            Assert.False(lab.EhParede(new Posicao(-1, -1)));
        }

        [Fact]
        public void Labirinto_EhCaminho()
        {
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

            var lab = new Labirinto(matriz, 9, 7);

            Assert.NotNull(lab);
            Assert.True(lab.EhCaminho(new Posicao(1,1)));
            Assert.False(lab.EhCaminho(new Posicao(0, 0)));
        }

        [Fact]
        public void Labirinto_EhCaminhoExtremos()
        {
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

            var lab = new Labirinto(matriz, 9, 7);

            Assert.NotNull(lab);
            Assert.False(lab.EhCaminho(new Posicao(-1, -1)));
            Assert.False(lab.EhCaminho(new Posicao(20, 30)));

        }
    }
}
