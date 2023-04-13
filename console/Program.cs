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
            lista.add("Baleia");
            lista.add("Tubaraum");
            Debug.Assert(lista.ehvazia() == false);
            Debug.Assert(lista.tamanho() == 5);
            Debug.Assert(lista.posicao("Mamaco") == 2);
            Debug.Assert(lista.posicao("Arara") == 0);
            Debug.Assert(lista.posicao("Jade") == -1);
            Debug.Assert(lista.Get(2) == "Mamaco");
            lista.remove("Baleia");
            lista.remove("Belefante");
            Debug.Assert(lista.tamanho() == 3);
            Debug.Assert(lista.posicao("Baleia") == -1);
            lista.add("Baleia", 3);
            lista.add("Jade", 4);

            Console.WriteLine("lista" + lista);
            Console.WriteLine("Deu Bom!");
	    }
    }
}
