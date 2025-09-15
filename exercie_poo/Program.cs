class Program
{
    public static void Main(string[] args)
    {
        Compte Compte1 = new Compte();
        //Cast explicite
        Compte1.Solde = (decimal)1570.52;
        //Cast par postfixe
        //Compte1.Solde = 1570.52m;
        Titulaire Titulaire1 = new Titulaire("Doe", "John", "10 rue de la Paix", "75000", "Paris", "0123456789", "johndoe@gmail.com");

        Compte1.Afficher();
        Titulaire1.Afficher();
    }
}
