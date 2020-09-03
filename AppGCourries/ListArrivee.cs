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

                var list = db.Arrivee.Select(
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

                if (!String.IsNullOrEmpty(txtCritere.Text))
                {
                    list = list.Where(x => x.Sujet.ToLower().Contains(txtCritere.Text.ToLower())).ToList();
                }

                if (useDate.Checked)
                {
                    list = list.Where
                        (x => x.DateOrdre >= txtDateDeb.Value.Date && x.DateOrdre <= txtDateFin.Value.Date).ToList();
                }
                dataGridArrivee.DataSource = list;
            }
            dataGridArrivee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridArrivee.AllowUserToResizeColumns = true;
            dataGridArrivee.AllowUserToOrderColumns = true;
            dataGridArrivee.Columns["ID"].Visible = false;
        }
        private void ListArrivee_Load(object sender, EventArgs e)
        {
            loadData();
            DataGridViewImageColumn btnEdit = new DataGridViewImageColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Image = Properties.Resources.edit2;
            dataGridArrivee.Columns.Add(btnEdit);
            //-----------------------------------------
            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "";
            btnDelete.Image = Properties.Resources.delete1;
            dataGridArrivee.Columns.Add(btnDelete);
            //-----------------------------------------
            dataGridArrivee.RowTemplate.Height = 30;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmArriveeAdd frm = new frmArriveeAdd(this);
            frm.ShowDialog();
        }


        private void dataGridArrivee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridArrivee.Rows[index];
                row.Selected = true;
            }
        }





        private void dataGridArrivee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridArrivee.Rows[index];
                row.Selected = true;
                int idArrivee = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                frmArriveeEdit frmEdit = new frmArriveeEdit(idArrivee, this);
                frmEdit.ShowDialog();

            }
        }



        private void dataGridArrivee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridArrivee.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dataGridArrivee.Rows[e.RowIndex];
            row.Selected = true;
            int idArriveeCur = Convert.ToInt32(row.Cells["ID"].Value);
            string sujet = row.Cells["Sujet"].Value.ToString();
            if (ColName == "btnEdit")
            {
                dataGridArrivee_CellContentDoubleClick(sender, e);
            }

            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show("Voulez Vous vraiment supprimer ce courrier " + sujet,
                    "Confirmation de suppression ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    using (DBGCourriesContext db = new DBGCourriesContext())
                    {
                        Arrivee ar = db.Arrivee.FirstOrDefault(x => x.idArrivee == idArriveeCur);
                        db.Arrivee.Remove(ar);
                        db.SaveChanges();
                        loadData();
                    }
                }
            }
        }

        private void dataGridArrivee_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridArrivee.Columns[e.ColumnIndex].Name;
            if (ColName != "btnEdit" && ColName != "btnDelete")
            {
                dataGridArrivee.Cursor = Cursors.Default;
            }
            else
            {
                dataGridArrivee.Cursor = Cursors.Hand;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnPrintListArrivee_Click(object sender, EventArgs e)
        {
            frmRptListeArrivee frm = new frmRptListeArrivee(txtCritere.Text,
                useDate.Checked, txtDateDeb.Value.Date, txtDateFin.Value.Date);
            frm.ShowDialog();
        }
    }
}
