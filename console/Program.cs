using System;
using System.Diagnostics;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ListaLigada();

            Debug.Assert(lista.ehvazia() == true);
            lista.add("Arara");
            lista.add("Belefante");
            lista.add("Mamaco");
            Debug.Assert(lista.ehvazia() == false);
            Console.WriteLine("Deu Bom!");
	    }
    }
    class Nodo {
        public Nodo proximo {get; set;}
        public string info{get; set;}
        public Nodo(string info){
            this.info = info;
        }
    }

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
            for(int i = 0; lista[i] != null; i++){
                lista[i] = new Nodo(palavra);
            }
        }
        
        public int posicao(string palavra) {
            
            return 0;
        }
        
        
    }
}
