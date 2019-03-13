using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            // wczytanie rozmiaru tablicy
            Console.WriteLine("Podaj rozmiar tablicy:");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] tab = new int[rozmiar];

            // wczytanie elementow tablicy
            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element tablicy:");
                tab[i] = int.Parse(Console.ReadLine());
            }

            // wypisanie rozmiaru tablicy oraz podanych przez uzytkownika elementow tablicy
            Console.WriteLine("Wejscie:");
            Console.WriteLine(rozmiar);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }
            Console.WriteLine();
            
            // odwracanie tablicy
            Console.WriteLine("Wyjscie:");
            for (int i = tab.Length; i > 0; i--)
            {
                Console.Write(tab[i-1]);  
            }
            Console.ReadLine();
        }
    }
}
