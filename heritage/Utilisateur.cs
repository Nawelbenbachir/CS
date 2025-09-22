public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    //Constructeur par défaut de la classe Utilisateur
    //permet d'initialiser les propriétés de l'objet pour qu'elles ne soient pas nulles
    //même nom que la classe, pas de type de retour
    public Utilisateur()
    {
        Nom = "";
        Prenom = "";
    }
    public Utilisateur(string prenom, string nom)
    {
        Nom = nom;
        Prenom = prenom;
    }
    public void Afficher()
    {
        Console.WriteLine($"Utilisateur : {Nom} {Prenom}");

    }

}
//Classe hérité Administrateur 
public class Administrateur : Utilisateur
{
}

//Classe héritée Client
public class Client : Utilisateur
{
    public string Adresse { get; set; }
    public Client()
    {
        Adresse = "";
    }
    public Client(string prenom, string nom, string adresse): base(prenom,nom)
    {
        //inutile grâce à :base qui permet d'appeler le constructeur de la classe parent 
        //base() pour appeler le constructeur vide (par défaut si non précisé)
        Prenom = prenom;
        Nom = nom;
        Adresse =adresse;
    }
    //Surcharge de la méthode Afficher qui devient alors prioritaire à celle de la classe Utilisateur
    //On ajoute new pour indiquer que c'est cette nouvelle méthode qu'il faut utiliser
    public new void Afficher()
    {
        Console.WriteLine($"Client : {Nom} {Prenom} {Adresse}");
    }
}

public class Employe : Utilisateur
{
    public string Poste { get; set; }
    public Employe()
    {
        Poste = "";
    }

     public new void Afficher()
    {
        Console.WriteLine($"Employé : {Nom} {Prenom} {Poste}");
    }
}
