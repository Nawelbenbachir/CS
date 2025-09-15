//Définition d'une classe Ville
    //Classe "normale"
    class Ville
    {
        //Constructeur par défaut (optionnel, car implicite et vide si non défini) appelé par le mot clé new
        //Le constructeur est la seule méthode n'ayant pas de valeur de retour (void ...)
        //Signature : public + NomDeLaClasse
        public Ville(string nom, string codePostal)
        {
            Nom = nom;
            _codePostal= codePostal;
        }

        public Ville()
        {
            Nom = "";
            CodePostal = "";
        }

        public Ville(string nom)
        {
            Nom = nom;
            CodePostal = "";
        }
        //Données de la classe : Propriétés / Attributs
        //Classe : Type de variable complexe

        //? après le type permet à la propriété Nom et Code Postal nullable
        //Accesseurs get (lecture)/set (écriture)

        //Assignation de la valeur à la variable Nom automatiquement (pas de vérification possible)
        public string Nom { get; set; }
        private string _codePostal="";
        public string CodePostal
    {
        get { return _codePostal; }
        set { _codePostal = value; }
    }

        //variable servant à faire des vérification sur la valeur de la variable Population
        private int _population = 1000;
        //assignation de la valeur à la variable Population manuellement 
        public int Population
        {
            //Getter
            get
            {
                return _population;
            }
            //Setter
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La population ne peut pas être négative");
                }
                else if (value > 1000000)
                {
                    throw new ArgumentException("La population est trop grande");
                }
                _population = value;
            }
        }
        public static string? Region = "PACA";

        //Comportement de la classe : Méthodes (fonctions)
        public void Afficher()
        {
            Console.WriteLine($"{this.CodePostal} {this.Nom} {Region}");
            Test();
        }
        //Méthode privée (private) utilisable uniquement dans la classe
        //Par défaut, les méthodes et données de la classe sont privées
        private void Test()
        {
            Console.WriteLine("Test");
        }

        public static void Bonjour()
        {
            Console.WriteLine("Bonjour");
        }
    }
