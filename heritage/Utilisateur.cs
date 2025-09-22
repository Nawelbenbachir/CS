public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public void Afficher()
    {
    Console.WriteLine($" {Nom}, {Prenom}");

    }

}