using System;
using System.Diagnostics;

namespace console
{
    public class ListaLigada
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

        public string Get(int posicao)
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

        public void remove(string palavra)
        {
            if (primeiro != null)
            {
                if (primeiro.info == palavra)
                {
                    primeiro = primeiro.proximo;
                    return;
                }
            }

            Nodo nodoAtual = primeiro;
            if (nodoAtual != null)
            {
                Nodo nodoAnterior = nodoAtual;
                while (nodoAtual.proximo != null)
                {
                    if (nodoAtual.info == palavra)
                    {
                        break;
                    }

                    nodoAnterior = nodoAtual;
                    nodoAtual = nodoAtual.proximo;
                }
                Nodo temp = nodoAtual.proximo;
                nodoAtual = nodoAnterior;
                nodoAtual.proximo = temp;

            }
        }

        public void add(string palavra, int posicao)
        {
            int i = 0;
            Nodo nodoAtual = primeiro;
            while (i < posicao)
            {
                nodoAtual = nodoAtual.proximo;
                
                i++;
            }
            nodoAtual = new Nodo(palavra);
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

        public override string ToString()
        {
            return $"Valor do nodo: {info}";
        }
    }
}
