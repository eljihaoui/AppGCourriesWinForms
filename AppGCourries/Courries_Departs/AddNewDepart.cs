﻿using AppGCourries.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppGCourries.Courries_Departs
{
    public partial class AddNewDepart : Form
    {
        private readonly ListDeparts frmListDeparts;
        public AddNewDepart()
        {
            InitializeComponent();
        }
        public AddNewDepart(ListDeparts frmListDepartsREF)
        {
            InitializeComponent();
            this.frmListDeparts = frmListDepartsREF;
        }

        private void AddNewDepart_Load(object sender, EventArgs e)
        {
            using(DBGCourriesContext db =new DBGCourriesContext())
            {
                txtCateg.DataSource = db.Categorie.ToList();
                txtCateg.DisplayMember = "LibCateg";
                txtCateg.ValueMember = "idCateg";

                txtEntite.DataSource = db.Entites.ToList();
                txtEntite.DisplayMember = "LibEntite";
                txtEntite.ValueMember = "idEntite";

            }
        }

        private void tnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                Depart dep = new Depart();
                int nextNumOrdreDepart = db.Depart.Any() ? db.Depart.Max(x => x.NumOrdre) + 1 : 1;
                dep.NumOrdre = nextNumOrdreDepart;
                dep.Sujet = txtSujet.Text;
                dep.Remarques = txtRemarque.Text;
                dep.DateOrdre = txtDateOrdre.Value.Date;
                dep.Annee = txtDateOrdre.Value.Date.Year;
                dep.idCateg = Convert.ToInt32(txtCateg.SelectedValue);
                dep.idUser = 1;
                db.Depart.Add(dep);
                foreach (Entites entite in txtEntite.CheckedItems)
                {
                    //attach instance to context
                    db.Entites.Attach(entite);
                    dep.Entites.Add(entite);
                }
                db.SaveChanges();
                this.Close();
                frmListDeparts.LoadListDepart();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}