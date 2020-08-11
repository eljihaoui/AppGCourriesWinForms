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
    public partial class frmArriveeAdd : Form
    {
        private ListArrivee frmList; 
        public frmArriveeAdd()
        {
            InitializeComponent();
        }

        public frmArriveeAdd(ListArrivee frm)
        {
            InitializeComponent();
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
                int nextNumOrdre = db.Arrivee.Any() ? db.Arrivee.Max(x => x.NumOrdre) + 1 : 1;
                Arrivee ar = new Arrivee();
                ar.NumOrdre = nextNumOrdre;
                ar.NumCourrier = txtNumCourrier.Text;
                ar.Sujet = txtSujet.Text;
                ar.Remarques = txtRemarque.Text;
                ar.DateCourrier = txtDateCourrier.Value.Date;
                ar.DateOrdre = txtDateOrdre.Value.Date;
                ar.Annee = txtDateOrdre.Value.Date.Year;
                ar.idCateg = Convert.ToInt32(txtCateg.SelectedValue);
                ar.idEntite = Convert.ToInt32(txtEntite.SelectedValue);
                ar.idUser = 1;
                db.Arrivee.Add(ar);
                db.SaveChanges();
                this.Close();
                frmList.loadData();


            }
        }

        private void frmArriveeAdd_Load(object sender, EventArgs e)
        {
            using( DBGCourriesContext db = new DBGCourriesContext()) {

                txtCateg.DataSource = db.Categorie.ToList();
                txtCateg.ValueMember = "idCateg";
                txtCateg.DisplayMember = "LibCateg";

                txtEntite.DataSource = db.Entites.ToList();
                txtEntite.ValueMember = "idEntite";
                txtEntite.DisplayMember = "LibEntite";

            }
        }
    }
}
