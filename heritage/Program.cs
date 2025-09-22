public class Heritage
{
    public static void Main(string[] args)
    {
        //instanciation d'un Utilisateur
        // Utilisateur Util1 = new Utilisateur();
        // Util1.Nom = "Benbachir";
        // Util1.Prenom = "Nawel";
        // Util1.Afficher();

        Utilisateur Util1 = new Utilisateur("Nawel", "Benbachir");
        Util1.Afficher();

        //client est une instance (un objet) de la classe Client
        // Client Client1 = new Client();
        // Client1.Nom = "Dupont";
        // Client1.Prenom = "Jacques";
        // Client1.Adresse = "Place Jean Jaurès 84740 Velleron";
        // Client1.Afficher();

        Client Client1 = new Client("Jacques", "Dupont", "Place Jean Jaurès 84740 Velleron");
        Client1.Afficher();


        Employe Employe1 = new Employe();
        Employe1.Nom = "Durand";
        Employe1.Prenom = "Jerome";
        Employe1.Poste = "Secrétaire";
        Employe1.Afficher();
    }
}
