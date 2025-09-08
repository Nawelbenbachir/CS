// Exercice 1

for (int i = 0; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}

//Exercice 2

Console.WriteLine("Entrer un nombre entier");
int nombre = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + " x " + nombre + " = " + i * nombre);
}

//Exercice 3
int somme = 0;
int nb = 1;

while (nb!= 0)
{
    Console.WriteLine("Entrer un nombre entier");
    nb = Convert.ToInt32(Console.ReadLine());
    somme = somme + nb ;
    
}
Console.WriteLine(somme);

//Exercice 4

Random aleatoire = new Random();
int entier = aleatoire.Next(1, 100);
int test;
do
{
    Console.WriteLine("Entrez un nombre entre 1 et 100");
    test = Convert.ToInt32(Console.ReadLine());
    if (test > entier)
    {
        Console.WriteLine("Trop grand");
    }
    else if (test< entier)
    {
        Console.WriteLine("Trop petit");
    }
} while (test != entier);
Console.WriteLine("Vous avez trouvé");

//Exercice 5

string[] prenoms = { "ALice", "Bob", "Charlie", "Diana" };
foreach (string i in prenoms)
{
    Console.WriteLine(i);
}

//Exercice 6

int[] nombres = { 3, 7, 2, 9, 4 };
int somme = 0;
foreach (int i in nombres)
{
    somme = somme + i;
}
Console.WriteLine(somme);