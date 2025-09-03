
Console.WriteLine("Exercice 1");

int age = 48;
string prenom = "Nawel";
double taille = 1.65;
Console.WriteLine("Age:" + age + ",Prénom:" + prenom + ",Taille:" + taille);

Console.WriteLine("Exercice 2");

Console.WriteLine("Saisir un nombre:");
string snombre = Console.ReadLine();
int nombre = Convert.ToInt32(snombre);
Console.WriteLine("Le nombre multiplié par 2 est:" + nombre * 2);

Console.WriteLine("Exercice 3");
int a = 24;
int b = 5;
Console.WriteLine("Somme:" + (a + b) + " Différence:" + (a - b) + " Produit:" + (a * b) + " Quotient:" + (a/b));

Console.WriteLine("Exercice 4");
Console.WriteLine("Saisir un nombre:");

if ( Convert.ToInt32(Console.ReadLine()) % 2 == 0)
    Console.WriteLine("Le nombre est pair");
else
{
    Console.WriteLine("Le nombre est impair");
}

Console.WriteLine("Exercice 5");

Console.WriteLine("Quel est ton âge ?");
if (Convert.ToInt32(Console.ReadLine()) >= 18)
    Console.WriteLine("Tu est majeur");
else
{
    Console.WriteLine("Tu es mineur");
}

Console.WriteLine("Exercice 6");

Console.WriteLine("Entrer le premier nombre");
int nb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrer le deuxième nombre");
int nb2 = Convert.ToInt32(Console.ReadLine());
if (nb1 > nb2)
    Console.WriteLine(nb1 + " est le plus grand");
else if (nb1<nb2)
    Console.WriteLine(nb2 + " est le plus grand");
else 
    Console.WriteLine(nb1 + " = " + nb2);

Console.WriteLine("Exercice 7");

Console.WriteLine("Entrez un chiffre entre 1 et 7:");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        Console.WriteLine("Lundi");
        break;
    case 2:
        Console.WriteLine("Mardi");
        break;
    case 3:
        Console.WriteLine("Mercredi");
        break;
    case 4:
        Console.WriteLine("Jeudi");
        break;
    case 5:
        Console.WriteLine("Vendredi");
        break;
    case 6:
        Console.WriteLine("Samedi");
        break;
    case 7:
        Console.WriteLine("Dimanche");
        break;
    default:
        Console.WriteLine("Le chiffre est hors de l'intervalle");
        break;
}

Console.WriteLine("Exercice 8");

Console.WriteLine("Entrez le premier nombre: ");
double nombre1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez le deuxième nombre: ");
double nombre2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez l'opérateur: ");
string op = Console.ReadLine();

switch (op)
{
    case "+":
        Console.WriteLine("Résultat= " + (nombre1 + nombre2));
        break;
    case "-":
        Console.WriteLine("Résultat= " + (nombre1 - nombre2));
        break;
    case "*":
        Console.WriteLine("Résultat= " + (nombre1 * nombre2));
        break;
    case "/":
        if (nombre2 != 0)
            Console.WriteLine("Résultat= " + (nombre1 / nombre2));
        
        else if (nombre1 != 0)
            Console.WriteLine("Résultat= " + (nombre2 / nombre1));
        
        else
            Console.WriteLine("Division impossible");
        break;
    
}

Console.WriteLine("Exercice 9");

Console.WriteLine("Entrer la note");
double note = Convert.ToInt32(Console.ReadLine());

switch (note)
{
    case double x when x >= 0 && x <= 9:
        Console.WriteLine("Insuffisant");
        break;
    case double x when x >= 10 && x <= 13:
        Console.WriteLine("Moyen");
        break;
    case double x when x >= 14 && x <= 16:
        Console.WriteLine("Bien");
        break;
    case double x when x >= 17 && x <= 20:
        Console.WriteLine("Excellent");
        break;
    
}

Console.WriteLine("Exercice 10");

Console.WriteLine("1.Dire Bonjour");
Console.WriteLine("2.Dire au Revoir");
Console.WriteLine("3.Quitter");
Console.WriteLine("Choisir une option");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("Bonjour !");
        break;
    case "2":
        Console.WriteLine("Au revoir !");
        break;
    case "3":
        break;
    default:
        Console.WriteLine("L'option n'existe pas");
        break;

}
      
