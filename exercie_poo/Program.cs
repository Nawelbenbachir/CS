class Program
{
    public static void Main(string[] args)
    {
        Compte Compte1 = new Compte();
        //Cast explicite
        Compte1.Solde = (decimal)1570.52;
        //Cast par postfixe
        //Compte1.Solde = 1570.52m;

        Compte1.Afficher();
    }
}
