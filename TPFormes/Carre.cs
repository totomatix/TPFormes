using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFormes
{
    public class Carre : Rectangle
    {
        public Carre(Point origine, int longueur) : base(origine, longueur, longueur)
        {
        }

        public override string? ToString()
        {
            return "Carré :\n" +
                $"\tOrigine: {Origine}\n" +
                $"\tLongueur: {Longueur}\n" +
                $"\tPerimetre: {Perimetre()}\n" +
                $"\tAire: {Aire()}";
        }
    }
}
