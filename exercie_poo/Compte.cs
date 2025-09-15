
    class Compte
    {
        //Variable interne pour stocker le solde
        private decimal _solde=0;
        //Propriété publique pour manipuler le solde
        public decimal Solde
        {
            //Getter
            get { return _solde; }
            //Setter
            set { _solde = value; }
        }
    private Titulaire _titulaire;
    public Titulaire Titulaire {
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
    public void Afficher()
    {
        Console.WriteLine($"Solde:{this.Solde}");
        Console.WriteLine($"Titulaire: {Titulaire?.Prenom} {Titulaire?.Nom}");
    }
    }


