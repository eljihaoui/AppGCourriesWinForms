using AppGCourries.Models;
using AppGCourries.Shared;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppGCourries.Courries_Departs
{
    public partial class EditDepart : Form
    {
        private readonly ListDeparts frmListDeparts;
        private readonly int idDepart;
        public EditDepart()
        {
            InitializeComponent();
        }
        public EditDepart(ListDeparts frmListDepartsREF)
        {
            InitializeComponent();
            this.frmListDeparts = frmListDepartsREF;
        }
        public EditDepart(int id, ListDeparts frmListDepartsREF)
        {
            InitializeComponent();
            this.idDepart = id;
            this.frmListDeparts = frmListDepartsREF;
        }
        private void EditDepart_Load(object sender, EventArgs e)
        {
            if (this.idDepart != 0)
            {
                txtTitre.Text = "Edition Courrier Départ N° :" + this.idDepart;
                using (DBGCourriesContext db = new DBGCourriesContext())
                {
                    txtCateg.DataSource = db.Categorie.ToList();
                    txtCateg.DisplayMember = "LibCateg";
                    txtCateg.ValueMember = "idCateg";

                    txtEntite.DataSource = db.Entites.ToList();
                    txtEntite.DisplayMember = "LibEntite";
                    txtEntite.ValueMember = "idEntite";

                    Depart dep = db.Depart.FirstOrDefault(x => x.idDepart == this.idDepart);
                    txtDateOrdre.Value = dep.DateOrdre.Date;
                    txtSujet.Text = dep.Sujet;
                    txtRemarque.Text = dep.Remarques;
                    txtCateg.SelectedItem = dep.Categorie;

                    foreach (Entites entite in dep.Entites)
                    {
                        for (int i = 0; i < txtEntite.Items.Count; i++)
                        {
                            if (entite.idEntite == ((Entites)txtEntite.Items[i]).idEntite)
                            {
                                txtEntite.SetItemChecked(i, true);
                            }
                        }

                    }

                    // charger les fichiers de ce courrier départ 
                    loadDepartDocs();
                    dgvDepartDocs.Columns["idDepart"].Visible = false;
                    dgvDepartDocs.Columns["idDocDepart"].Visible = false;
                    dgvDepartDocs.ColumnHeadersVisible = false;
                    dgvDepartDocs.RowHeadersVisible = false;

                    DataGridViewImageColumn btnDowload = new DataGridViewImageColumn();
                    btnDowload.Name = "btnDowload";
                    btnDowload.HeaderText = "";
                    btnDowload.Image = Properties.Resources.download3;
                    dgvDepartDocs.Columns.Add(btnDowload);


                    DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                    btnDelete.Name = "btnDelete";
                    btnDelete.HeaderText = "";
                    btnDelete.Image = Properties.Resources.delete1;
                    dgvDepartDocs.Columns.Add(btnDelete);

                    dgvDepartDocs.Columns["btnDowload"].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
                    dgvDepartDocs.Columns["btnDelete"].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
                    dgvDepartDocs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                }
            }
        }

        private void loadDepartDocs()
        {
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                dgvDepartDocs.DataSource = db.Depart.FirstOrDefault(x => x.idDepart == this.idDepart).DepartDocs.Select(
                              p => new
                              {
                                  p.idDepart,
                                  p.idDocDepart,
                                  p.TypeDocDepart,
                                  p.FileName,
                                  size = Math.Round(((p.ContenuFileDepart.Length) / 1024f), 2) + " KB"
                              }).ToList();
            }
        }
        private void tnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void dgvDepartDocs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvDepartDocs.Columns[e.ColumnIndex].Name;
            if (ColName != "btnDowload" && ColName != "btnDelete")
            {
                dgvDepartDocs.Cursor = Cursors.Default;
            }
            else
            {
                dgvDepartDocs.Cursor = Cursors.Hand;
            }
        }

        private void dgvDepartDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvDepartDocs.Columns[e.ColumnIndex].Name;
            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show(
                    "Voulez Vous supprimer ce fichier",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );

                if (dr == DialogResult.Yes)
                {
                    using (DBGCourriesContext db = new DBGCourriesContext())
                    {
                        int idDepDocs = Convert.ToInt32(dgvDepartDocs.Rows[e.RowIndex].Cells["idDocDepart"].Value);
                        DepartDocs depDocs = db.DepartDocs.FirstOrDefault(x => x.idDocDepart == idDepDocs);
                        db.DepartDocs.Remove(depDocs);
                        db.SaveChanges();
                        // charger les pièces jointes de ce courrier
                        loadDepartDocs();
                    }
                }
            }

            if (ColName == "btnDowload")
            {
                int idDepDocs = Convert.ToInt32(dgvDepartDocs.Rows[e.RowIndex].Cells["idDocDepart"].Value);
                using (DBGCourriesContext db = new DBGCourriesContext())
                {
                    DepartDocs depDocs = db.DepartDocs.FirstOrDefault(x => x.idDocDepart == idDepDocs);
                    byte[] fileContent = depDocs.ContenuFileDepart;
                    string fileName = depDocs.FileName;
                    Stream strm;
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "All Files (*.*)|*.*";
                    saveFile.FileName = fileName;
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        if ((strm = saveFile.OpenFile()) != null)
                        {
                            strm.Write(fileContent, 0, fileContent.Length);
                            strm.Close();
                        }
                    }
                }
            }


        }

        private void btnUploadMoreFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " Documents Files |*.docx;*.xlsx;*.pdf|"
                        + "Images |*.png;*.jpg;*.gif|"
                        + "All files |*.*";
            ofd.Multiselect = true;
            ofd.Title = "Sélectionner les fichiers à importer ....";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (DBGCourriesContext db = new DBGCourriesContext())
                {
                    FileInfo finfo;
                    DepartDocs DepDocs;
                    foreach (string file in ofd.FileNames)
                    {
                        finfo = new FileInfo(file);
                        DepDocs = new DepartDocs();
                        DepDocs.idDepart = this.idDepart;
                        DepDocs.TypeDocDepart = finfo.Extension;
                        DepDocs.FileName = finfo.Name;
                        DepDocs.ContenuFileDepart = SharedData.GetBinaryFromFile(finfo.FullName);
                        db.DepartDocs.Add(DepDocs);
                        db.SaveChanges();
                    }
                    // charger les pièces jointes de ce courrier
                    loadDepartDocs();
                }
            }
        }
    }
}
