using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public class ListaDuplamenteLigada : ILista
    {
        private Nodo primeiro;

        public void add(string palavra)
        {
            if (primeiro == null)
            {
                primeiro = new Nodo(palavra);
            }
            else
            {
                Nodo nodoAtual = primeiro;
                while (nodoAtual.proximo != null)
                {
                    nodoAtual = nodoAtual.proximo;
                }

                Nodo novo = new Nodo(palavra);
                nodoAtual.proximo = novo;
                novo.anterior = nodoAtual;
            }
        }

        public void add(string palavra, int posicao)
        {
            Nodo novo = new Nodo(palavra);
            if (primeiro == null)
            {
                primeiro = novo;
            }
            else
            {
                var nodoAtual = primeiro;
                int i = 0;
                while (i < posicao-1)
                {
                    nodoAtual = nodoAtual.proximo;
                    i++;
                }
                var temp = nodoAtual;
                nodoAtual.proximo = novo;
                nodoAtual.proximo.anterior = temp;

                //nodoAtual.anterior = nodoAtual.proximo.anterior;
                           
                //var temp = nodoAtual;
                //nodoAtual = novo;
                //nodoAtual.anterior.proximo = nodoAtual;
                //nodoAtual.proximo = temp;
            }
        }

        public bool ehvazia()
        {
            bool ehvazia = false;
            if (primeiro == null)
            {
                ehvazia = true;
            }
            return ehvazia;
        }

        public string Get(int posicao)
        {
            var Nodo = GetNodo(posicao);

            return Nodo?.info;

            //if (Nodo == null)
            //{
            //    return null;
            //}
            //else return Nodo.info;
        }

        private Nodo GetNodo(int posicao)
        {
            Nodo nodoAtual = primeiro;
            if (posicao > tamanho())
            {
                return null;
            }
            else if (nodoAtual != null)
            {
                for (int i = 0; i < posicao; i++)
                {
                    nodoAtual = nodoAtual.proximo;
                }
                return nodoAtual;
            }
            return null;
        }

        public int posicao(string palavra)
        {
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
                while (nodoAtual.proximo != null)
                {
                    if (nodoAtual.info == palavra)
                    {
                        break;
                    }

                    nodoAtual = nodoAtual.proximo;
                }
                var temp = nodoAtual.proximo;
                nodoAtual = nodoAtual.anterior;
                nodoAtual.proximo = temp;

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

        class Nodo
        {
            public Nodo proximo { get; set; }
            public Nodo anterior { get; set; }
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
}
