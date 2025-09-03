Console.WriteLine("Exercice 2");
//If-Else
int note = 17;
if (note >= 10)
{
    Console.WriteLine("Réussi");
}
else
{
    Console.WriteLine("Raté");
}
//Si une seule instruction dans le bloc, {} pas indispensable

//if/else if/else
if (note >= 15)
    Console.WriteLine("Très bien");
else if (note >= 10)
    Console.WriteLine("Bien");
else if (note >= 5)
    Console.WriteLine("Passable");
else
    Console.WriteLine("Mauvais");

//switch
switch (note)
{
    case >= 15:
        Console.WriteLine("Très bien");
        Console.WriteLine("Bravo");
        break;
    case >= 10:
        Console.WriteLine("Bien");
        break;
    case >= 5:
        Console.WriteLine("Passable");
        break;
    default:
        Console.WriteLine("Mauvais");
        break;
}

//Exercice

//Déclarer deux variables pour les âges de Pierre et Paul
//Afficher lequel des deux est le plus âgé avec des if puis avec un switch

int agePierre = 35;

int agePaul = 28;


if (agePierre > agePaul)
    Console.Write("Pierre est le plus âgé (boucle if)");
else
{
    Console.Write("Paul est le plus âgé (boucle if)");
}

switch (agePierre)
{
    case > agePaul:
        Console.Write("Pierre est le plus âgé (boucle switch)");
        break;
    default:
        Console.Write("Paul est le plus âgé (boucle switch)");
        break;
}