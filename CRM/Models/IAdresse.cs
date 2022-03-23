namespace CRM.Models
{
    public interface IAdresse
    {
        string code_postal { get; set; }
        string pays { get; set; }
        string premiere_ligne { get; set; }
        string seconde_ligne { get; set; }
        string ville { get; set; }
    }
}