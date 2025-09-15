
class Compte
{
    //Variable interne pour stocker le solde
    private decimal _solde = 0;
    //Propriété publique pour manipuler le solde
    public decimal Solde
    {
        //Getter
        get { return _solde; }
        //Setter
        set { _solde = value; }
    }
    private Titulaire _titulaire;
    public Titulaire Titulaire
    {
        get { return _titulaire; }
        set { _titulaire = value; }
    }
    //Constructeur paramétré
    public Compte(string nom, string prenom, string adresse, string codepostal, string ville, string tel, string email, decimal solde)
    {
        _solde = solde;
        _titulaire = new Titulaire(nom, prenom, adresse, codepostal, ville, tel, email);
    }

    //constructeur par défaut
    public Compte()
    {
        _solde = 0;
        _titulaire = new Titulaire("", "", "", "", "", "", "");
    }
    public void Crediter(decimal montant)
    {
        if (montant < 0)
        {
            throw new ArgumentException("Le montant doit être positif");
        }
        _solde += montant;
        Console.WriteLine($"Crédit de {montant} effectué. Nouveau solde: {_solde}");
    }

    public void Debiter(decimal montant)
    {
        if (montant < 0)
        {
            throw new ArgumentException("Le montant doit être positif");
        }
        if (montant > _solde)
        {
            throw new InvalidOperationException("Fonds insuffisants");
        }
        _solde -= montant;
        Console.WriteLine($"Débit de {montant} effectué. Nouveau solde: {_solde}");
    }
    public void Afficher()
    {
        Console.WriteLine("---Informations du compte---");
        Console.WriteLine($"Solde:{this.Solde}");
        Titulaire.Afficher();
    }

}
   


