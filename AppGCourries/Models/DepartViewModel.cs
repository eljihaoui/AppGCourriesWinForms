using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGCourries.Models
{
    public class DepartViewModel
    {
        public int ID { get; set; }
        public int Annee { get; set; }
        public int NumOrdre { get; set; }
        public DateTime DateOrdre { get; set; }
        public  string Sujet { get; set; }
        public string Categorie { get; set; }
        public string Remarques { get; set; }
    }
}
