namespace console
{
    public interface ILista
    {
        void add(string palavra);
        void add(string palavra, int posicao);
        bool ehvazia();
        string Get(int posicao);
        int posicao(string palavra);
        void remove(string palavra);
        int tamanho();
    }
}