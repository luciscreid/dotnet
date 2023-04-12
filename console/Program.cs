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
            Console.WriteLine("Deu Bom!");
	    }
    }
}
