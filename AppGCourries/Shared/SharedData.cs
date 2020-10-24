using AppGCourries.Models;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGCourries.Shared
{
    public class SharedData
    {
        public static List<ArriveeViewModel> getListCourriesArrivees()
        {
            List<ArriveeViewModel> list = new List<ArriveeViewModel>();
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                list = db.Arrivee.Select(
                    p => new ArriveeViewModel
                    {
                        idArrivee = p.idArrivee,
                        Categ = p.Categorie.LibCateg,
                        Entite = p.Entites.LibEntite,
                        Annee = p.Annee,
                        NumCourrier = p.NumCourrier,
                        DateOrdre = p.DateOrdre,
                        NumOrdre = p.NumOrdre,
                        DateCourrier = (DateTime)p.DateCourrier,
                        Sujet = p.Sujet,
                        Remarques = p.Remarques
                    }
                    ).ToList();
            }
            return list;
        }
    }
}
