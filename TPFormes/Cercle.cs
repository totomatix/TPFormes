using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFormes
{
    public class Cercle
    {
        public Cercle(Point origine, int rayon)
        {
            Origine = origine;
            Rayon = rayon;
        }

        public Point Origine { get; set; }
        public int Rayon { get; set; }

        public double Perimetre()
        {
            return Math.PI * Rayon * 2;
        }

        public double Aire()
        {
            return Math.PI * Rayon * Rayon;
        }

        public override string? ToString()
        {
            return "Cercle :\n" +
                $"\tOrigine: {Origine}\n" +
                $"\tRayon: {Rayon}\n" +
                $"\tPerimetre: {Perimetre()}\n" +
                $"\tAire: {Aire()}";
        }
    }
}
