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

        internal void remove(string v)
        {
            throw new NotImplementedException();
        }

        internal string Get(int v)
        {
            throw new NotImplementedException();
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
            
            return 0;
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
