using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFormes
{
    public abstract class Forme
    {
        public Forme(Point origine)
        {
            Origine = origine;
        }

        public Point Origine { get; set; }

        public abstract double Perimetre();

        public abstract double Aire();
    }
}
