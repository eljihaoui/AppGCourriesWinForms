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
using AppGCourries.Reports;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using AppGCourries.Shared;

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
            //-------------------------------------
            DataGridViewImageColumn btnPrint = new DataGridViewImageColumn();
            btnPrint.Name = "btnPrint";
            btnPrint.HeaderText = "";
            btnPrint.Image = Properties.Resources.print0;
            dataGridArrivee.Columns.Add(btnPrint);
            //--------------------------------------------
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
            if (ColName == "btnPrint")
            {
                using (DBGCourriesContext db = new DBGCourriesContext())
                {
                    List<ArriveeViewModel> lst = new List<ArriveeViewModel>();
                    lst = db.Arrivee.Select(

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
                        ).Where(x => x.idArrivee == idArriveeCur).ToList();

                    List <ArriveeDetailViewModel> listSupReport = new List<ArriveeDetailViewModel>();
                    listSupReport = db.Arrivee.FirstOrDefault(a => a.idArrivee == idArriveeCur).ArriveeDocs.Select(
                        p=>new ArriveeDetailViewModel
                        {
                            idArrivee=p.idArrivee,
                            idArriveeDocs=p.idArriveeDocs,
                            typeDoc=p.TypeDocArrivee,
                            filename = p.FileName,
                            sizeFile= Math.Round((p.ContenuFileArrivee.Length/1024f),2) + " KB"
                        }
                        ).ToList();


                    rptFicheCourrier fiche = new rptFicheCourrier();
                    fiche.SetDataSource(lst);
                    fiche.Subreports["FicheCourrierDetails.rpt"].SetDataSource(listSupReport);
                    frmPrintReport frm = new frmPrintReport();
                    frm.linkReport(fiche);
                    frm.ShowDialog();

                }

            }

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
            if (ColName != "btnEdit" && ColName != "btnDelete" && ColName != "btnPrint")
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

            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                List<ArriveeViewModel> list = new List<ArriveeViewModel>();
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
                if (!String.IsNullOrEmpty(this.txtCritere.Text))
                {
                    list = list.Where(x => x.Sujet.ToLower().Contains(this.txtCritere.Text.ToLower())).ToList();
                }
                if (useDate.Checked)
                {
                    list = list.Where(x => x.DateOrdre >= this.txtDateDeb.Value.Date && x.DateOrdre <= this.txtDateFin.Value.Date).ToList();
                }
                RptListeArrivee rpt = new RptListeArrivee();
                rpt.SetDataSource(list);
                frmPrintReport frmPrint = new frmPrintReport();
                frmPrint.linkReport(rpt);
                frmPrint.ShowDialog();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();
            Excel._Worksheet  excelWorkSheet= excelWorkBook.Sheets[1];
            excelWorkSheet.Name = "Liste des courries Arrivées";
            int nbCol;
            PropertyInfo[] colonnes = typeof(ArriveeViewModel).GetProperties();
            nbCol = colonnes.Length;

            // Remplir les colonnes du fichier EXcel 
            for (int i = 0; i < nbCol; i++)
            {
                excelWorkSheet.Cells[1, i + 1] = colonnes[i].Name;
            }

            // remplir les lignes de la feuille Excel
            List<ArriveeViewModel> list = SahredData.getListArrivess();
            ArriveeViewModel arvm = new ArriveeViewModel();
            for (int i = 0; i < list.Count; i++)
            {
                arvm = list.ElementAt(i);
                for (int j = 0; j < nbCol; j++)
                {
                    excelWorkSheet.Cells[i + 2, j + 1] = arvm.GetType().GetProperty(colonnes[j].Name).GetValue(arvm, null);

                }
            }
            SaveFileDialog savef = new SaveFileDialog();
            savef.FileName = "Liste des Courries Arrivées";
            savef.Filter = "Fichier Excel |*.xlsx";
            if (savef.ShowDialog() == DialogResult.OK)
            {
                excelWorkBook.SaveAs(savef.FileName);
            }
            excelWorkBook.Close();
            excelApp.Quit();
        }
    }
}
