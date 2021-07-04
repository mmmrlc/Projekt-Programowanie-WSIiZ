using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie_WSIiZ
{
    public class Kostka
    {
        int wielkosc;
        /// <summary>
        /// Utworzenie instancji obiektu Kostka.
        /// </summary>
        /// <param name="oczka">Jest to wielkosc utworzonej kosci.</param>
        public Kostka(int oczka)
        {
            wielkosc = oczka;
        }
        /// <summary>
        /// Metoda ta generuje losową liczbę odpowiadającej wielkości kości.
        /// </summary>
        /// <returns>Zwraca wynik rzutu.</returns>
        public int rzut()
        {
            int wynik;
            Random rand = new Random();
            
            wynik = rand.Next(1,wielkosc+1);                
            return wynik;
        }
        /// <summary>
        /// Metoda pobiera wielkość kości.
        /// </summary>
        /// <returns>Metoda zwraca wartość kości.</returns>
        public int getWielkosc()
        {
            return wielkosc;
        }
    }
}
