//Généralités
//C# est sensible à la casse/case sensitive (console <> Console)
// ; à la fin de chaque instruction
//. pour les décimales 

//Déclaration d'une variable 
//Type, Nom, (=Valeur)

//Type string : Chaîne de carctères
string message = "Hello World!";
Console.WriteLine(message);

//Type int: Entier (32 bits, 2 147 483 647 valeurs possibles)
int nombre = 42;
Console.WriteLine(nombre);
//Variante uint : unsigned int (4 294 967 295 valeurs possibes)

//Type double : Nombre à virgule flottante (64 bits, 15-16 chiffres significatifs)
double prix = 19.99;
Console.WriteLine(prix);

//Type char : Caractère (16 bits)
char lettre = 'A';
Console.WriteLine(lettre);

//Type bool : Booleen (true ou false)
bool estVrai = true;
Console.WriteLine(estVrai);

//Type var : le type est déterminé par la valeur (+ rapide à compiler donc + efficace mais moins clair)

var nom = "Nawel";
//nom = 23; impossible car type fixé en string
Console.WriteLine(nom);

//Variable par référence dans le cas d'une chaîne de caractère et par valeur dans les autres cas 
