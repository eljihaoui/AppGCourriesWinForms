﻿using AppGCourries.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;

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

        public static List<DepartViewModel> getListDeparts()
        {
            List<DepartViewModel> list = new List<DepartViewModel>();
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                list = db.Depart.Select(
                    p => new DepartViewModel
                    {
                        ID = p.idDepart,
                        Categorie = p.Categorie.LibCateg,
                        Annee = p.Annee,
                        NumOrdre = p.NumOrdre,
                        DateOrdre = p.DateOrdre,
                        Sujet = p.Sujet,
                        Remarques = p.Remarques
                    }
                    ).ToList();
            }
            return list;
        }

        public static byte[] GetBinaryFromFile(string file)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
            }
            return bytes;
        }

    }
}
