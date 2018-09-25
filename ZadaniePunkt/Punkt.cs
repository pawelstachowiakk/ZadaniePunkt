using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Punkt
    {

        public  int X { get; protected set; }// właściwość 1
        

        public int Y { get; protected set; }// właściwość 2

        public Punkt()
        {

        }

        public Punkt(int wspx, int wspy) //konstruktor
        {
            X = wspx;
            Y = wspy;
        }

        public void Prawo(int ileP) //metoda 1
        {
            X += ileP;

        }

        public void Lewo(int ileL) //metoda 2
        {
            X -= ileL;

        }

        public void Gora(int ileG) //metoda 3
        {
            Y += ileG;

        }

        public void Dol(int ileD) //metoda 4
        {
            Y -= ileD;

        }


        public void Wyswietl()
        {

            Console.WriteLine("Współrzędna X: {0}",X);
            Console.WriteLine("Współrzędna Y: {0}",Y);
        }

    }

    class Punkt3D : Punkt
    {

        public int Z { get; private set; }

        public void Przod(int ileP)
        {
            Z += ileP;

        }

        public void Tyl(int ileT)
        {
            Z -= ileT;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

    }


}
