using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGCourries.Models
{
    public class ArriveeViewModel
    {
        public int idArrivee { get; set; }
        public string Categ { get; set; }
        public string Entite { get; set; }
        public int Annee { get; set; }
        public int NumOrdre { get; set; }
        public DateTime DateOrdre { get; set; }
        public string NumCourrier { get; set; }
        public DateTime DateCourrier { get; set; }
        public string Sujet { get; set; }
        public string Remarques { get; set; }
    }
}
