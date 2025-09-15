
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
    public Titulaire? Titulaire { get; set; }
    
    public void Afficher()
    {
        Console.WriteLine($"Solde:{this.Solde}");
        Console.WriteLine($"Titulaire: {Titulaire?.Prenom} {Titulaire?.Nom}");
    }
    }


