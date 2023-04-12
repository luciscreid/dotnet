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
