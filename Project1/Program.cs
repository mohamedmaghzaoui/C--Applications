using System;
using System.Collections.Generic;
using System.Linq;

class Contact
{
    //contact variables
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

class Program
{
    // contacts list
    static List<Contact> contacts = new List<Contact>();
    
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Ajouter un contact");
            Console.WriteLine("2. Supprimer un contact");
            Console.WriteLine("3. Modifier un contact");
            Console.WriteLine("4. Rechercher un contact par nom");
            Console.WriteLine("5. Afficher tous les contacts");
            Console.WriteLine("6. Quitter");
            Console.Write("Choisissez une option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": AddContact(); break;
                case "2": RemoveContact(); break;
                case "3": EditContact(); break;
                case "4": SearchContact(); break;
                case "5": DisplayContacts(); break;
                case "6": return;
                default: Console.WriteLine("Option invalide, veuillez réessayer."); break;
            }
        }
    }
    static void AddContact()
    {
        Console.Write("Nom: ");
        string name = Console.ReadLine();
        Console.Write("Numéro de téléphone: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        contacts.Add(new Contact { Name = name, PhoneNumber = phone, Email = email });
        Console.WriteLine("Contact ajouté avec succès !");
    }

    static void RemoveContact()
    {
        Console.Write("Entrez le nom du contact à supprimer: ");
        string name = Console.ReadLine();
        var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine("Contact supprimé avec succès !");
        }
        else
        {
            Console.WriteLine("Contact non trouvé.");
        }
    }

    static void EditContact()
    {
        Console.Write("Entrez le nom du contact à modifier: ");
        string name = Console.ReadLine();
        var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contact != null)
        {
            Console.Write("Nouveau numéro de téléphone (laisser vide pour garder l'ancien): ");
            string phone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(phone)) contact.PhoneNumber = phone;

            Console.Write("Nouvel email (laisser vide pour garder l'ancien): ");
            string email = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(email)) contact.Email = email;

            Console.WriteLine("Contact mis à jour avec succès !");
        }
        else
        {
            Console.WriteLine("Contact non trouvé.");
        }
    }

    static void SearchContact()
    {
        Console.Write("Entrez le nom du contact à rechercher: ");
        string name = Console.ReadLine();
        var results = contacts.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        if (results.Count > 0)
        {
            Console.WriteLine("Contacts trouvés:");
            foreach (var contact in results)
            {
                Console.WriteLine($"Nom: {contact.Name}, Téléphone: {contact.PhoneNumber}, Email: {contact.Email}");
            }
        }
        else
        {
            Console.WriteLine("Aucun contact trouvé.");
        }
    }

    static void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Aucun contact enregistré.");
            return;
        }
        Console.WriteLine("Liste des contacts:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Nom: {contact.Name}, Téléphone: {contact.PhoneNumber}, Email: {contact.Email}");
        }
    }
}