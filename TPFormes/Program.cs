
using TPFormes;

// étape 1
Console.WriteLine("Etape 1:");
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

// étape 2
Console.WriteLine("Etape 2:");

List<Cercle> cercles = new List<Cercle>();
cercles.Add(new Cercle(P0, 5));
cercles.Add(new Cercle(P1, 78));
cercles.Add(new Cercle(P2, 2));
foreach (Cercle cercle in cercles)
{
    Console.WriteLine(cercle);
}

//etape 3
Console.WriteLine("Etape 3:");

List<Forme> formes = new List<Forme>();
formes.Add(new Cercle(P0, 5));
formes.Add(new Cercle(P1, 78));
formes.Add(new Cercle(P2, 2));
formes.Add(new Rectangle(P2, 3, 9));
formes.Add(new Rectangle(P1, 13, 49));

foreach (Forme forme in formes)
{
    Console.WriteLine(forme);
}