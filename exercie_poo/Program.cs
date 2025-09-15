class Program
{
    public static void Main(string[] args)
    {
        Compte Compte1 = new Compte("Doe", "John", "10 rue de la Paix", "75000", "Paris", "0123456789", "johndoe@gmail.com", 1000);
        //Cast explicite

        //Cast par postfixe
        //Compte1.Solde = 1570.52m;
        //Titulaire Titulaire1 = new Titulaire();

        Compte1.Afficher();
        Compte1.Crediter(500);
        Compte1.Afficher();
        Compte1.Debiter(200);
        Compte1.Afficher();
    }
}
