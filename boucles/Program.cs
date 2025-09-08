

//for quand on connaît à l'avance le nombre d'itérations

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("boucle for terminée");

//while quand on ne connaît pas à l'avance le nombre d'itération

int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++; 
}
Console.WriteLine("boucle while terminée");

//do...while, variante de while qui exécute au moins une fois le code de la boucle 
int k = 0;
do
{
    Console.WriteLine(k);
    k++;

} while (k < 10);
Console.WriteLine("boucle do...While termineé");

//foreach, pour itérer sur les collections (tableaux, listes, dictionnaires, etc...)

//création d'un tableau
int[] entiers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int element in entiers)
{
    Console.WriteLine(element);
}
Console.WriteLine("boucle foreach entiers terminée");

string[] chaines = { "Bonjour", "Hello World", "Comment ça va" };
foreach (string element in chaines)
{
    Console.WriteLine(elemnt);
}
Console.WriteLine("boucle foreach chaines terminée");



