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
            for(int i = 0; lista[i] != null; i++){
                lista[i] = new Nodo(palavra);
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
