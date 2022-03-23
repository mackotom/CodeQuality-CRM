namespace CRM.Models
{
    public interface IContact
    {
        Adresse adresse { get; set; }
        int id { get; set; }
        string mail { get; set; }
        string mobile { get; set; }
        string nom { get; set; }
        string prenom { get; set; }
        string raison_social { get; set; }
    }
}