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
            throw new NotImplementedException();
        }

        public void add(string palavra, int posicao)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int posicao(string palavra)
        {
            throw new NotImplementedException();
        }

        public void remove(string palavra)
        {
            throw new NotImplementedException();
        }

        public int tamanho()
        {
            throw new NotImplementedException();
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
