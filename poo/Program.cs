namespace ExempleObjet
{
   class Program
    {
        //Point d'entrée du projet :  méthode statique appelée Main qui retourne void 
        //équivalent à dotnet new console avec 3 args (console, -o, proj)
        //static permet d'utiliser la méthode sans instancier la classe
        static void Main(string[] args)
        {
            Console.WriteLine("Début");
            //On crée (instancie) une variable de type Objet (une instance) à partir de la classe Ville (Modèle)
            Ville Avignon = new Ville();
            //A partir d'ici, on peut utiliser l'objet maVille
            Avignon.Nom = "Avignon"; //Affectation du nom 
            Avignon.CodePostal = "84000"; //Affectation du code postal
            //Utilisation de la méthode public Afficher de l'objet maVille
            Avignon.Afficher();

            //On crée (instancie) une variable de type Objet (une instance) à partir de la classe Ville (Modèle)
            Ville Marseille = new Ville(codePostal: "13000", nom: "Marseille");
            //Ville Marseille = new Ville("Marseille", "13000");
            //A partir d'ici, on peut utiliser l'objet maVille
            //Utilisation de la méthode public Afficher de l'objet maVille
            Marseille.Afficher();

            Ville Paris = new Ville("Paris");
            Paris.CodePostal = "75000";
            Paris.Population = 2000000;
            Paris.Afficher();
            //Appel de la méthode statique
            Ville.Bonjour();

            Console.WriteLine(Ville.Region);
        }
        
    }
 
}
