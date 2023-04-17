using console;
using System;
using Xunit;

namespace testeunitario
{
    public class ListaLigadaTest
    {
        [Fact]
        public void Remove_DeveRemoverComListaVazia()
        {
            var lista = new ListaLigada();
            lista.remove("Arara");

            Assert.Equal(0, lista.tamanho());
            Assert.Equal(-1, lista.posicao("Arara"));
        }

        [Fact]
        public void Remove_DeveRemoverComUmItem()
        {
            var lista = new ListaLigada();
            lista.add("Arara");

            lista.remove("Arara");

            Assert.Equal(0, lista.tamanho());
            Assert.Equal(-1, lista.posicao("Arara"));
        }

        [Fact]
        public void Remove_DeveRemoverOPrimeiro()
        {
            var lista = new ListaLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            lista.remove("Arara");

            Assert.Equal(4, lista.tamanho());
            Assert.Equal(-1, lista.posicao("Arara"));
        }


        [Fact]
        public void Remove_DeveRemover()
        {
            var lista = new ListaLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            lista.remove("Baleia");
            lista.remove("Belefante");

            Assert.Equal(3, lista.tamanho());
            Assert.Equal(-1, lista.posicao("Baleia"));
            Assert.Equal(-1, lista.posicao("Belefante"));

        }

        [Fact]
        public void Add_DeveAdicionarNaPosicao()
        {
            //arrange
            var lista = new ListaLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            // act
            lista.add("Baleia", 3);
            lista.add("Jade", 4);

            // assert
            Assert.Equal(4, lista.posicao("Jade"));
            Assert.Equal(3, lista.posicao("Baleia"));
        }
    }
}
