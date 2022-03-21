// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using CRM.Models;

namespace CRM
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            // Prospect
            Adresse adresse = new Adresse("5 rue Jouillard", "", "Grenoble", "38100", "France");
            Prospect prospect = new Prospect("Doe", "Jhon", "0637706123", "mail@example.com", "0000", adresse);

            // Client
            Client client = new Client("Doe", "Client", "0637706128", "mail@example.com", "0000", adresse);

        }
    }
}