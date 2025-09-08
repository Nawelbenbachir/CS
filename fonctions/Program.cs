Console.WriteLine("Fonctions");

// //Modèle abstrait d'une fonction
// // typDeRetour NomDeLaFonction(Paramètres)
// // {
// //     Instructions...
// //     return valeurDeRetour
// // }

// int Additionne(int nbEntier1, int nbEntier2) // Déclaration de la fonction
// {
//     return nbEntier1 + nbEntier2;
// }
// int total = Additionne(2, 3); // Appel de la fonction
// Console.WriteLine(total);

//Ecrire une fonction qui calcule le carré d'un nombre 

int NombreAuCarre(int nombre)
{
    return nombre * nombre;
}
Console.WriteLine(NombreAuCarre(2));
//Ecrire une fonction qui affiche "Bonjour" dans la console 

void AfficheBonjour()
{
    Console.WriteLine("Bonjour");
}

//Ecrire une fonction qui retourne le plus grand de deux entiers

int PlusGrandNombre(int nombre1, int nombre2)
{
    if (nombre1 > nombre2)
    {
        return nombre1;
    }
    else 
    {
        return nombre2;
    }
  
}

Console.WriteLine("Entrer un nombre entier");
int nombre1 = Convert.ToInt32(Console.ReadLine());
int nombre2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PlusGrandNombre(nombre1,nombre2));



