using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_WSIiZ
{
    class Kostka
    {
        int wielkosc;

        public Kostka(int oczka)
        {
            wielkosc = oczka;
        }

        public int rzut()
        {
            int wynik;

            wynik = wielkosc;
            return wynik;
        }

    }
}
