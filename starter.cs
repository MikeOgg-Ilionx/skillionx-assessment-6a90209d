using System;
using System.Collections.Generic;

public class Contact
{
    public string Naam { get; set; }
    public string Telefoonnummer { get; set; }
}

public class ContactenBeheer
{
    private List<Contact> contacten = new List<Contact>();

    public void VoegContactToe(string naam, string telefoonnummer)
    {
        // Implementeer hier de logica om een nieuw contact toe te voegen
    }

    public void ToonAlleContacten()
    {
        // Implementeer hier de logica om alle contacten te tonen
    }

    public void VerwijderContact(string naam)
    {
        // Implementeer hier de logica om een contact te verwijderen op basis van naam
    }

    public static void Main(string[] args)
    {
        ContactenBeheer beheer = new ContactenBeheer();
        // Hier kan de hoofdlogica van de applicatie komen om de gebruiker te interageren
        Console.WriteLine("Welkom bij de Contacten Applicatie!");
        // Voorbeeld: beheer.VoegContactToe("Jan Jansen", "0612345678");
        // Voorbeeld: beheer.ToonAlleContacten();
    }
    // dit is een test
}