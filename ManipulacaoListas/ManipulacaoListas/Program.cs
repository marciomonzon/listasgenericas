using System;
using System.Collections.Generic;

namespace ManipulacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minhaLista = new List<int>();
            List<int> minhaLista2 = new List<int>();

            // adicionar ==> add
            minhaLista.Add(1);
            minhaLista.Add(2);
            minhaLista.Add(3);
            minhaLista.Add(4);

            Console.WriteLine(minhaLista.Capacity);
            Console.WriteLine(minhaLista.Count);

            minhaLista2.Add(5);
            minhaLista2.Add(5);
            minhaLista2.Add(6);
            minhaLista2.Add(7);
            minhaLista2.Add(8);

            foreach (int item in minhaLista)
            {
                Console.WriteLine(item);
            }

            // adiciona na ultima posição
            minhaLista.AddRange(minhaLista2);

            for (int i = 0; i < minhaLista.Count; i++)
            {
                Console.WriteLine(minhaLista[i]);
            }

            // ordena lista em ordem crescente
            minhaLista.Sort();

            minhaLista.Contains(8); // retorna true or false

            minhaLista.Insert(2, 10); // insere em um determinado indice

            minhaLista.InsertRange(3, minhaLista2); // insere uma collection em um determinado indice

            minhaLista.Remove(8); // remove algo especifico informado

            minhaLista.Clear(); // remove os elementos

            Console.ReadKey();
        }
    }
}
