
using TPFormes;

// test du centre du repère
Point P0 = new Point();
Console.WriteLine(P0);

// test création d'un point quelconque
Point P1= new Point(-8,5);
Console.WriteLine(P1);

// test de equals
// création d'un 3eme point egale à P0
Point P2 = new Point();
Console.WriteLine(P2.Equals(P0)); // doit écrire true
Console.WriteLine(P2.Equals(P1)); // doit écrire false