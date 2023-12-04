using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFormes
{
    public abstract class Forme : IComparable
    {
        public Forme(Point origine)
        {
            Origine = origine;
        }

        public Point Origine { get; set; }

        public abstract double Perimetre();

        public abstract double Aire();

        public int CompareTo(object? obj)
        {
            if (obj is Forme f) // si l'objet est une form
            {
                return Convert.ToInt32(this.Aire() - f.Aire());
            }
            else // si l'objet n'est pas une form
            {
                return 100;
            }
        }
    }
}
