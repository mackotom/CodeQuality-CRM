using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Adresse : Model, IAdresse
    {

        public string premiere_ligne { get; set; }

        public string seconde_ligne { get; set; }

        public string ville { get; set; }

        public string code_postal { get; set; }

        public string pays { get; set; }


        public Adresse(string premiere_ligne, string seconde_ligne, string ville, string code_postal, string pays)
        {
            this.premiere_ligne = premiere_ligne;
            this.seconde_ligne = seconde_ligne;
            this.ville = ville;
            this.code_postal = code_postal;
            this.pays = pays;
        }


    }
}
