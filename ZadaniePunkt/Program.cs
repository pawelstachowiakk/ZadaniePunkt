using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Program
    {
        static void Main(string[] args)
        {
KlasaBazowa bazowa = new KlasaBazowa();
KlasaPochodna pochodna = new KlasaPochodna();
KlasaBazowa pochodnaJakoBazowa = new KlasaPochodna();
object pochodnaJakoObject = new KlasaPochodna();
object bazowaJakoObject = bazowa;
KlasaPochodna kl = pochodnaJakoBazowa;
            KlasaPochodna kl = (KlasaPochodna)pochodnaJakoBazowa;



            Console.ReadLine();


        }
    }
}
