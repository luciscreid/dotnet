using System;
using System.Diagnostics;

namespace console
{
    class ListaLigada
    {
        private Nodo primeiro;

        public bool ehvazia() {
            bool ehvazia = false;
            if(primeiro == null){
                ehvazia = true;
            }
            return ehvazia;
        }


        public void add(string palavra){
            if (primeiro == null)
            {
                primeiro = new Nodo(palavra);
            } else {
                Nodo nodoAtual = primeiro;
                while (nodoAtual.proximo != null)
                {
                    nodoAtual = nodoAtual.proximo;
                }
                nodoAtual.proximo = new Nodo(palavra);
            }
        }
        public int tamanho()
        {
            int tamanho = 0;
            if (primeiro == null)
            {
                return tamanho = 0;
            }
            else
            {
                tamanho = 1;
                Nodo nodoAtual = primeiro;
                while (nodoAtual.proximo != null)
                {
                    nodoAtual = nodoAtual.proximo;
                    tamanho++;
                }
            }
            return tamanho;
        }
        public int posicao(string palavra) {
            int i = 0;
            Nodo nodoAtual = primeiro;
            while (nodoAtual != null)
            {
                if (nodoAtual.info == palavra)
                {
                    return i;
                }
                nodoAtual = nodoAtual.proximo;
                i++;
            }
            return -1;
        }

        internal string Get(int posicao)
        {
            Nodo nodoAtual = primeiro;
            if (nodoAtual != null)
            {
                for (int i = 0; i < posicao; i++)
                {
                    nodoAtual = nodoAtual.proximo;
                }
                return nodoAtual.info;
            }             
            return "nao deu";
        }

        internal void remove(string palavra)
        {
            Nodo nodoAtual = primeiro;
            if (nodoAtual != null)
            {
                while (nodoAtual.info != palavra)
                {
                    nodoAtual = nodoAtual.proximo;
                }
                nodoAtual = nodoAtual.proximo;
            }
        }

        internal void add(string palaravra, int posicao)
        {
            throw new NotImplementedException();
        }
    }

    class Nodo
    {
        public Nodo proximo { get; set; }
        public string info { get; set; }
        public Nodo(string info)
        {
            this.info = info;
        }
    }
}
