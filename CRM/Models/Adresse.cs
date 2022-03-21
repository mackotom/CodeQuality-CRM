using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Adresse : Model
    {

        public string premiere_ligne;

        public string seconde_ligne;

        public string ville;

        public string code_postal;

        public string pays;


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
