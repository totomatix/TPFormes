using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFormes
{
    public class Rectangle : Forme
    {
        public Rectangle(Point origine,int largeur, int longueur) : base(origine)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public int Largeur { get; set; }

        public int Longueur { get; set; }

        public override double Aire()
        {
            return Longueur * Largeur;
        }

        public override double Perimetre()
        {
            return (Longueur + Largeur) * 2;
        }

        public override string? ToString()
        {
            return "Rectangle :\n" +
                $"\tOrigine: {Origine}\n" +
                $"\tLargeur: {Largeur}\n" +
                $"\tLongueur: {Longueur}\n" +
                $"\tPerimetre: {Perimetre()}\n" +
                $"\tAire: {Aire()}";
        }
    }
}
