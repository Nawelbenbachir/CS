class Titulaire
{
    private int _id;
    public int Id
    {

        get { return _id; }

        set { _id = value; }
    }

    private string _nom = "";
    public string Nom
    {
        get { return _nom; }

        set { _nom = value; }
    }

    private string _prenom = "";
    public string Prenom
    {

        get { return _prenom; }

        set { _prenom = value; }
    }



    private string _adresse = "";
    public string Adresse
    {

        get { return _adresse; }

        set { _adresse = value; }
    }

    private string _codepostal = "";
    public string CodePostal
    {

        get { return _codepostal; }

        set { _codepostal = value; }
    }

    private string _ville = "";
    public string Ville
    {

        get { return _ville; }

        set { _ville = value; }
    }

    private string _tel = "";
    public string Tel
    {

        get { return _tel; }

        set { _tel = value; }
    }

    private string _email = "";
    public string Email
    {

        get { return _email; }

        set { _email = value; }
    }

    public Titulaire(string nom, string prenom, string adresse, string codepostal, string ville, string tel, string email)
    {
        //Id=id;
        Nom = nom;
        Prenom=prenom;
        Adresse=adresse;
        CodePostal=codepostal;
        Ville=ville;
        Tel=tel;
        Email=email;
    }
   
    public void Afficher()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nom: {Nom}");
        Console.WriteLine($"Prénom: {Prenom}");
        Console.WriteLine($"Adresse: {Adresse}");
        Console.WriteLine($"Code Postal: {CodePostal}");
        Console.WriteLine($"Ville: {Ville}");
        Console.WriteLine($"Téléphone: {Tel}");
        Console.WriteLine($"Email: {Email}");
    }
    
}