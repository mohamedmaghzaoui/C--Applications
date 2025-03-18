using System;
using System.Collections.Generic;

class Contact
{
    public string Nom { get; set; }
    public string Numero { get; set; }
}

class Program
{
    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu :");
            Console.WriteLine("1. Ajouter un contact");
            Console.WriteLine("2. Afficher tous les contacts");
            Console.WriteLine("3. Rechercher un contact par nom");
            Console.WriteLine("4. Supprimer un contact par nom");
            Console.WriteLine("5. Quitter");
            Console.Write("Choisissez une option : ");
            
            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    AjouterContact();
                    break;
                case "2":
                    AfficherContacts();
                    break;
                case "3":
                    RechercherContact();
                    break;
                case "4":
                    SupprimerContact();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Option invalide. Veuillez réessayer.");
                    break;
            }
        }
    }

    static void AjouterContact()
    {
        Console.Write("Nom : ");
        string nom = Console.ReadLine();
        Console.Write("Numéro : ");
        string numero = Console.ReadLine();
        
        contacts.Add(new Contact { Nom = nom, Numero = numero });
        Console.WriteLine("Contact ajouté avec succès !");
    }

    static void AfficherContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Aucun contact trouvé.");
            return;
        }
        
        Console.WriteLine("\nListe des contacts :");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Nom: {contact.Nom}, Numéro: {contact.Numero}");
        }
    }

    static void RechercherContact()
    {
        Console.Write("Entrez le nom du contact à rechercher : ");
        string nom = Console.ReadLine();
        
        var resultats = contacts.FindAll(c => c.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase));
        
        if (resultats.Count == 0)
        {
            Console.WriteLine("Aucun contact trouvé avec ce nom.");
            return;
        }
        
        foreach (var contact in resultats)
        {
            Console.WriteLine($"Nom: {contact.Nom}, Numéro: {contact.Numero}");
        }
    }

    static void SupprimerContact()
    {
        Console.Write("Entrez le nom du contact à supprimer : ");
        string nom = Console.ReadLine();
        
        contacts.RemoveAll(c => c.Nom.Equals(nom, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Contact supprimé avec succès (si existant) !");
    }
}