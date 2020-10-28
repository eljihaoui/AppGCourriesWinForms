using AppGCourries.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppGCourries.Courries_Arrivees
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
            using (DBGCourriesContext db = new DBGCourriesContext())
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
        private void loadDataArriveesDocs()
        {
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                dgvArriveeDocs.DataSource = db.Arrivee.FirstOrDefault(x=>x.idArrivee==this.idArrivee).ArriveeDocs.Select(
                              p => new
                              {
                                  p.idArrivee,
                                  p.idArriveeDocs,
                                  p.TypeDocArrivee,
                                  p.FileName,
                                  size = Math.Round(((p.ContenuFileArrivee.Length) / 1024f), 2) + " KB"
                              }).ToList();
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
                    // charger les pièces jointes de ce courrier
                    loadDataArriveesDocs();

                    dgvArriveeDocs.Columns["idArrivee"].Visible = false;
                    dgvArriveeDocs.Columns["idArriveeDocs"].Visible = false;
                    dgvArriveeDocs.ColumnHeadersVisible = false;
                    dgvArriveeDocs.RowHeadersVisible = false;
                    DataGridViewImageColumn btnDowload = new DataGridViewImageColumn();
                    btnDowload.Name = "btnDowload";
                    btnDowload.HeaderText = "";
                    btnDowload.Image = Properties.Resources.download3;
                    dgvArriveeDocs.Columns.Add(btnDowload);

                    DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                    btnDelete.Name = "btnDelete";
                    btnDelete.HeaderText = "";
                    btnDelete.Image = Properties.Resources.delete1;
                    dgvArriveeDocs.Columns.Add(btnDelete);
                    dgvArriveeDocs.Columns["btnDowload"].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
                    dgvArriveeDocs.Columns["btnDelete"].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
                    dgvArriveeDocs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }
            }

        }

        private void dgvArriveeDocs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvArriveeDocs.Columns[e.ColumnIndex].Name;
            if (ColName != "btnDowload" && ColName != "btnDelete")
            {
                dgvArriveeDocs.Cursor = Cursors.Default;
            }
            else
            {
                dgvArriveeDocs.Cursor = Cursors.Hand;
            }
        }

        private void dgvArriveeDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dgvArriveeDocs.Columns[e.ColumnIndex].Name;
            if (ColName == "btnDelete")
            {
                DialogResult dr = MessageBox.Show(
                    "Voulez Vous supprimer ce fichier ",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    );
                if (dr == DialogResult.Yes)
                {
                    using (DBGCourriesContext db = new DBGCourriesContext())
                    {
                        int idArrDocs = Convert.ToInt32(dgvArriveeDocs.Rows[e.RowIndex].Cells["idArriveeDocs"].Value);
                        ArriveeDocs ardocs = db.ArriveeDocs.FirstOrDefault(x => x.idArriveeDocs == idArrDocs);
                        db.ArriveeDocs.Remove(ardocs);
                        db.SaveChanges();
                        // charger les pièces jointes de ce courrier
                        loadDataArriveesDocs();

                    }
                }
            }

            if (ColName == "btnDowload")
            {
                int idArrDocs = Convert.ToInt32(dgvArriveeDocs.Rows[e.RowIndex].Cells["idArriveeDocs"].Value);
                using(DBGCourriesContext db = new DBGCourriesContext())
                {
                    ArriveeDocs ardocs = db.ArriveeDocs.FirstOrDefault(x => x.idArriveeDocs == idArrDocs);
                    byte[] fileContent = ardocs.ContenuFileArrivee;
                    string fileName = ardocs.FileName;
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
        // Convert file to binary data
        public byte[] GetBinaryFromFile(string file)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
            }
            return bytes;
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
                using(DBGCourriesContext db= new DBGCourriesContext())
                {
                    FileInfo finfo;
                    ArriveeDocs arDocs;
                    foreach (string file in ofd.FileNames)
                    {
                        finfo = new FileInfo(file);
                        arDocs = new ArriveeDocs();
                        arDocs.idArrivee = this.idArrivee;
                        arDocs.TypeDocArrivee = finfo.Extension;
                        arDocs.FileName = finfo.Name;
                        arDocs.ContenuFileArrivee = GetBinaryFromFile(finfo.FullName);
                        db.ArriveeDocs.Add(arDocs);
                        db.SaveChanges();
                    }
                    // charger les pièces jointes de ce courrier
                    loadDataArriveesDocs();
                }
            }
        }
    }
}
