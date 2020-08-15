using AppGCourries.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGCourries
{
    public partial class frmArriveeEdit : Form
    {
        private ListArrivee frmList;
        private int idArrivee;
        public frmArriveeEdit()
        {
            InitializeComponent();
        }

        public frmArriveeEdit(ListArrivee frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        public frmArriveeEdit(int id, ListArrivee frm)
        {
            InitializeComponent();
            this.idArrivee = id;
            this.frmList = frm;
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           using(DBGCourriesContext db = new DBGCourriesContext())
            {
                if (this.idArrivee != 0)
                {
                Arrivee ar = db.Arrivee.FirstOrDefault(x => x.idArrivee == this.idArrivee);
                ar.NumCourrier = txtNumCourrier.Text;
                ar.Sujet = txtSujet.Text;
                ar.Remarques = txtRemarque.Text;
                ar.DateCourrier = txtDateCourrier.Value.Date;
                ar.DateOrdre = txtDateOrdre.Value.Date;
                ar.Annee = txtDateOrdre.Value.Date.Year;
                ar.idCateg = Convert.ToInt32(txtCateg.SelectedValue);
                ar.idEntite = Convert.ToInt32(txtEntite.SelectedValue);
                ar.idUser = 1;
                db.SaveChanges();

                this.Close();
                frmList.loadData();
                }
   


            }
        }

        private void frmArriveeEdit_Load(object sender, EventArgs e)
        {
                using (DBGCourriesContext db = new DBGCourriesContext())
                {

                    txtCateg.DataSource = db.Categorie.ToList();
                    txtCateg.ValueMember = "idCateg";
                    txtCateg.DisplayMember = "LibCateg";
                    txtEntite.DataSource = db.Entites.ToList();
                    txtEntite.ValueMember = "idEntite";
                    txtEntite.DisplayMember = "LibEntite";
                    if (this.idArrivee != 0)
                    {
                        Arrivee arr = db.Arrivee.FirstOrDefault(x => x.idArrivee == this.idArrivee);
                        txtDateOrdre.Value = arr.DateOrdre.Date;
                        txtNumCourrier.Text = arr.NumCourrier;
                        txtDateCourrier.Value = arr.DateCourrier.Value.Date;
                        txtSujet.Text = arr.Sujet;
                        txtRemarque.Text = arr.Remarques;
                        txtCateg.SelectedItem = arr.Categorie;
                        txtEntite.SelectedItem = arr.Entites;
                        txtTitre.Text = "Edtion Courrier N° : " + arr.NumOrdre;
                    }
                }
            
        }
    }
}
