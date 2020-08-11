using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGCourries.Models;

namespace AppGCourries
{
    public partial class ListArrivee : UserControl
    {
        public ListArrivee()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                dataGridArrivee.DataSource = db.Arrivee.Select(
                    p => new
                    {
                        ID = p.idArrivee,
                        p.Annee,
                        p.NumOrdre,
                        Entite = p.Entites.LibEntite,
                        Categorie = p.Categorie.LibCateg,
                        p.DateOrdre,
                        p.DateCourrier,
                        p.NumCourrier,
                        p.Sujet
                    }).ToList();
            }
            dataGridArrivee.AutoResizeColumns();
            dataGridArrivee.AllowUserToResizeColumns = true;
            dataGridArrivee.AllowUserToOrderColumns = true;
            dataGridArrivee.Columns["ID"].Visible = false;
        }
        private void ListArrivee_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmArriveeAdd frm = new frmArriveeAdd(this);
            frm.ShowDialog();
        }
    }
}
