using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFormes
{
    public class Cercle : Forme
    {
        public Cercle(Point origine, int rayon) : base(origine)
        {
            Origine = origine;
            Rayon = rayon;
        }

        
        public int Rayon { get; set; }

        public override double Perimetre()
        {
            return Math.PI * Rayon * 2;
        }

        public override double Aire()
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
