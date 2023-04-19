using console;
using System;
using Xunit;

namespace testeunitario
{
    public class ListaDuplamenteLigadaTest
    {
        [Fact]
        public void EhVazia_True()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            bool ehVazia = lista.ehvazia();

            // assert
            Assert.True(ehVazia);
        }

        [Fact]
        public void EhVazia_False()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            lista.add("Baleia");
            bool ehVazia = lista.ehvazia();

            // assert
            Assert.False(ehVazia);
        }

        [Fact]
        public void Add_DeveAdicionar()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            lista.add("Baleia");

            // assert
            Assert.Equal(0, lista.posicao("Baleia"));
            Assert.Equal(1, lista.tamanho());
        }

        [Fact]
        public void Add_DeveAdicionarVarios()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            // assert
            Assert.Equal(5, lista.tamanho());
        }

        [Fact]
        public void Posicao_DeveRetrnarValor()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            // act
            int posicao = lista.posicao("Arara");

            // assert
            Assert.Equal(0, posicao);
        }

        [Fact]
        public void Posicao_DeveRetrnarValorInvalido()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            // act
            int posicao = lista.posicao("");

            // assert
            Assert.Equal(-1, posicao);
        }

        [Fact]
        public void Posicao_DeveRetrnarNull()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            int posicao = lista.posicao("Arara");

            // assert
            Assert.Equal(-1, posicao);
        }

        [Fact]
        public void Get_DeveRetrnarValorInvalido()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            // act
            var Get = lista.Get(3);

            // assert
            Assert.Equal("Baleia", Get);
        }

        [Fact]
        public void Get_DeveRetrnarValor()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            // act
            var Get = lista.Get(10);

            // assert
            Assert.Null(Get);
        }

        [Fact]
        public void Get_DeveRetrnarNull()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            var Get = lista.Get(0);

            // assert
            Assert.Null(Get);
        }

        [Fact]
        public void Tamanho_DeveRetornarVazio()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            int tamanho = lista.tamanho();

            // assert
            Assert.Equal(0, tamanho);
        }

        [Fact]
        public void Tamanho_DeveRetornarCheio()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            lista.add("Baleia");
            lista.add("Tubaraum");

            int tamanho = lista.tamanho();

            // assert
            Assert.Equal(5, tamanho);
        }

        [Fact]
        public void Remove_DeveRemoverComListaVazia()
        {
            var lista = new ListaDuplamenteLigada();
            lista.remove("Arara");

            Assert.Equal(0, lista.tamanho());
            Assert.Equal(-1, lista.posicao("Arara"));
        }

        [Fact]
        public void Remove_DeveRemoverComUmItem()
        {
            var lista = new ListaDuplamenteLigada();
            lista.add("Arara");

            lista.remove("Arara");

            Assert.Equal(0, lista.tamanho());
            Assert.Equal(-1, lista.posicao("Arara"));
        }

        [Fact]
        public void Remove_DeveRemoverOPrimeiro()
        {
            var lista = new ListaDuplamenteLigada();
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
            var lista = new ListaDuplamenteLigada();
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
            var lista = new ListaDuplamenteLigada();

            // act
            lista.add("Baleia", -2);

            // assert
            Assert.Equal(0, lista.posicao("Baleia"));
        }

        [Fact]
        public void Add_DeveAdicionarNaListaVaziaPosicaoErrada()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();

            // act
            lista.add("Arara", 5);

            // assert
            Assert.Equal(0, lista.posicao("Arara"));
        }

        [Fact]
        public void Add_DeveAdicionarNaListaVazia()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();
            
            // act
            lista.add("Baleia", 0);

            // assert
            Assert.Equal(0, lista.posicao("Baleia"));
        }

        [Fact]
        public void Add_DeveAdicionarNaPosicao()
        {
            //arrange
            var lista = new ListaDuplamenteLigada();
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
