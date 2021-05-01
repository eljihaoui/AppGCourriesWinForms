using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using AppGCourries.Models;
using AppGCourries.Shared;

namespace AppGCourries.Courries_Departs
{
    public partial class ListDeparts : UserControl
    {
        public ListDeparts()
        {
            InitializeComponent();
        }

        public void LoadListDepart()
        {
            List<DepartViewModel> list = SharedData.getListDeparts();
            dgvDeparts.DataSource = list;
            dgvDeparts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDeparts.AllowUserToOrderColumns = true;
            dgvDeparts.AllowUserToResizeColumns = true;
        }
        private void ListDeparts_Load(object sender, EventArgs e)
        {
            LoadListDepart();
            DataGridViewImageColumn btnDEL = new DataGridViewImageColumn();
            btnDEL.Name = "btnDel";
            btnDEL.HeaderText = "";
            btnDEL.Image = Properties.Resources.delete1;
            dgvDeparts.Columns.Add(btnDEL);
            dgvDeparts.RowTemplate.Height = 30;

            DataGridViewImageColumn btnEdit = new DataGridViewImageColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "";
            btnEdit.Image = Properties.Resources.edit2;
            dgvDeparts.Columns.Add(btnEdit);
            dgvDeparts.RowTemplate.Height = 30;

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            AddNewDepart frm = new AddNewDepart(this);
            frm.ShowDialog();
        }

        private void dgvDeparts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgvDeparts.Columns[e.ColumnIndex].Name;
            if (colName == "btnDel" || colName == "btnEdit")
            {
                dgvDeparts.Cursor = Cursors.Hand;
            }
            else
            {
                dgvDeparts.Cursor = Cursors.Default;
            }


        }

        private void dgvDeparts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgvDeparts.Columns[e.ColumnIndex].Name;  
            int idDepart = Convert.ToInt32(dgvDeparts.Rows[e.RowIndex].Cells["ID"].Value);

            if (colName == "btnDel")
            {
                DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer ce courrier ?",
                    "Confirmation de Suppression",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    using (DBGCourriesContext db = new DBGCourriesContext())
                    {
                        Depart depart = db.Depart.FirstOrDefault(d => d.idDepart == idDepart);
                        depart.Entites.Clear();// supprimer toutes les entités liées au courrier depart (table destiner)

                        List<DepartDocs> docsToDelete = db.DepartDocs.Where(d => d.idDepart == idDepart).ToList();
                        db.DepartDocs.RemoveRange(docsToDelete);

                        db.Depart.Remove(depart);
                        db.SaveChanges();
                        LoadListDepart();
                    }
                }
            }

            if (colName == "btnEdit")
            {
                EditDepart frmEdit = new EditDepart(idDepart, this);
                frmEdit.ShowDialog();
            }
        }
    }
}
