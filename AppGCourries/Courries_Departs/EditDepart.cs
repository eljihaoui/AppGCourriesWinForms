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
        public EditDepart(int id , ListDeparts frmListDepartsREF)
        {
            InitializeComponent();
            this.idDepart = id;
            this.frmListDeparts = frmListDepartsREF;
        }
        private void EditDepart_Load(object sender, EventArgs e)
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
            txtTitre.Text = "Edition Courrier Départ N° :" + this.idDepart;

        }

        private void tnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //using (DBGCourriesContext db = new DBGCourriesContext())
            //{
            //    Depart dep = new Depart();
            //    int nextNumOrdreDepart = db.Depart.Any() ? db.Depart.Max(x => x.NumOrdre) + 1 : 1;
            //    dep.NumOrdre = nextNumOrdreDepart;
            //    dep.Sujet = txtSujet.Text;
            //    dep.Remarques = txtRemarque.Text;
            //    dep.DateOrdre = txtDateOrdre.Value.Date;
            //    dep.Annee = txtDateOrdre.Value.Date.Year;
            //    dep.idCateg = Convert.ToInt32(txtCateg.SelectedValue);
            //    dep.idUser = 1;
            //    db.Depart.Add(dep);
            //    foreach (Entites entite in txtEntite.CheckedItems)
            //    {
            //        //attach instance to context
            //        db.Entites.Attach(entite);
            //        dep.Entites.Add(entite);
            //    }
            //    db.SaveChanges();

            //    DepartDocs depDocs = new DepartDocs();
            //    depDocs.idDepart = dep.idDepart;
            //    foreach (ListViewItem item in txtPJointes.Items)
            //    {
            //        FileInfo f = new FileInfo(item.SubItems[0].Text);//non du fichier 
            //        depDocs.TypeDocDepart = f.Extension;
            //        depDocs.FileName = item.SubItems[0].Text;
            //        depDocs.ContenuFileDepart = SharedData.GetBinaryFromFile(item.SubItems[1].Text);
            //        db.DepartDocs.Add(depDocs);
            //        db.SaveChanges();
            //    }
  
            //    this.Close();
            //    frmListDeparts.LoadListDepart();
            //}
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Documents Files |*.docx;*.xlsx;*.pdf|"
            //             + "Images |*.png;*.jpg;*.gif|"
            //             + "All files |*.*";
            //ofd.Multiselect = true;
            //ofd.Title = "Sélectionner les fichiers à importer ....";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    txtPJointes.Columns.Add("Fichier");
            //    txtPJointes.Columns.Add("Chemin Complet");
            //    foreach (string fichier in ofd.FileNames)
            //    {
            //        FileInfo f = new FileInfo(fichier);
            //        ListViewItem item = new ListViewItem(f.Name);
            //        item.SubItems.Add(f.FullName);
            //        txtPJointes.Items.Add(item);
            //    }
            //    txtPJointes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //}
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
