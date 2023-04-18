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
        public void Add_DeveAdicionarNaListaVaziaPosicaoInvalida()
        {
            //arrange
            var lista = new ListaLigada();

            // act
            lista.add("Baleia", -2);

            // assert
            Assert.Equal(0, lista.posicao("Baleia"));
        }

        [Fact]
        public void Add_DeveAdicionarNaListaVaziaPosicaoErrada()
        {
            //arrange
            var lista = new ListaLigada();

            // act
            lista.add("Arara", 5);

            // assert
            Assert.Equal(0, lista.posicao("Arara"));
        }

        [Fact]
        public void Add_DeveAdicionarNaListaVazia()
        {
            //arrange
            var lista = new ListaLigada();
            
            // act
            lista.add("Baleia", 0);

            // assert
            Assert.Equal(0, lista.posicao("Baleia"));
        }

        [Fact]
        public void Add_DeveAdicionarNaPosicao()
        {
            //arrange
            var lista = new ListaLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Tubaraum");
            lista.add("Jade");

            // act
            lista.add("Baleia", 3);

            // assert
            Assert.Equal(3, lista.posicao("Baleia"));
        }
    }
}
