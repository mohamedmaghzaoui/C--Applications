using System;
using System.Collections.Generic;

class Contact
{
    // private values 
    private string _name;
    private string _phoneNumber;
    private string _email;

    // getters setters for name
    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    // // getters setters for phone
    public string GetPhoneNumber() => _phoneNumber;
    public void SetPhoneNumber(string phoneNumber) => _phoneNumber = phoneNumber;

    // // getters setters for Emaill
    public string GetEmail() => _email;
    public void SetEmail(string email) => _email = email;
}

class Program
{
    //inetialise contact list
    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. ajouter un contact");
            Console.WriteLine("2. supprimer un contact");
            Console.WriteLine("3. modifier un contact");
            Console.WriteLine("4. rechercher un seul contact par nom");
            Console.WriteLine("5. Afficher tous les contacts");
            Console.WriteLine("6. exit");
            Console.Write("Choisissez une option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": AddContact(); 
                break;
                case "2": RemoveContact(); 
                break;
                case "3": EditContact(); 
                break;
                case "4": SearchContact(); 
                break;
                case "5": DisplayContacts();
                 break;
                case "6": 
                return;
                default: Console.WriteLine("Option invalide"); break;
            }
        }
    }

//realisé par Ramla Argui
    static void AddContact()
    {
        Console.Write("Nom: ");
        string name = Console.ReadLine();
        Console.Write("Numéro de téléphone: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        // set values
        var contact = new Contact();
        contact.SetName(name);
        contact.SetPhoneNumber(phone);
        contact.SetEmail(email);

        contacts.Add(contact);
        Console.WriteLine("contact ajouté");
    }

//realisé par Mohamed Maghzaoui
//find contact by name
    static Contact FindContact(string name)
    {
        foreach (var contact in contacts)
        {
            if (contact.GetName() == name)  // Use getter method
            {
                return contact;
            }
        }
        return null;
    }

//realisé par Imrane mbetil
    static void RemoveContact()
    {
        Console.Write("Nom du contact à supprimer: ");
        string name = Console.ReadLine();
        var contact = FindContact(name);
        if (contact != null)
        {
            contacts.Remove(contact);
            Console.WriteLine("Contact supprimé");
        }
        else
        {
            Console.WriteLine("contact non trouvé");
        }
    }

//realisé par Mohamed Maghzaoui
    static void EditContact()
    {
        Console.Write("Nom du contact pour modifier: ");
        string name = Console.ReadLine();
        var contact = FindContact(name);
        if (contact != null)
        {
            Console.Write("Nouveau numéro de téléphone : ");
            string phone = Console.ReadLine();
            if (phone!=null)
            {
                contact.SetPhoneNumber(phone);
            }  

            Console.Write("Nouvel email: ");
            string email = Console.ReadLine();
            if (email!=null)
            {
                contact.SetEmail(email);
                
            } // Use setter method

            Console.WriteLine("Contact modifié");
        }
        else
        {
            Console.WriteLine("Contact pas trouvé");
        }
    }

//realisé par Piere
    static void SearchContact()
    {
        Console.Write("nom du contact à rechercher: ");
        string name = Console.ReadLine();
        var contact = FindContact(name);

        if (contact != null)
        {
            Console.WriteLine($"Nom: {contact.GetName()}, Téléphone: {contact.GetPhoneNumber()}, Email: {contact.GetEmail()}");
        }
        else
        {
            Console.WriteLine("Contact n'existe pas.");
        }
    }

//realisé par Mohamed Maghzaoui
    static void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Aucun contact.");
            return;
        }
        Console.WriteLine("Contacts:");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"Nom: {contact.GetName()}, Téléphone: {contact.GetPhoneNumber()}, Email: {contact.GetEmail()}");
        }
    }
}
