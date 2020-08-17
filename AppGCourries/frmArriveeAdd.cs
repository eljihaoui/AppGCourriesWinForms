using AppGCourries.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        // Convert file to binary data
        public byte[] GetBinaryFromFile(string file)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file,FileMode.Open,FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
            }
            return bytes;
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

                ArriveeDocs arDocs = new ArriveeDocs();
                arDocs.idArrivee = ar.idArrivee;
                foreach (ListViewItem item in txtPJointes.Items)
                {
                    FileInfo f = new FileInfo(item.SubItems[0].Text);//non du fichier 
                    arDocs.TypeDocArrivee = f.Extension;
                    arDocs.FileName = item.SubItems[0].Text;
                    arDocs.ContenuFileArrivee = GetBinaryFromFile(item.SubItems[1].Text);
                    db.ArriveeDocs.Add(arDocs);
                    db.SaveChanges();
                }
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Documents Files |*.docx;*.xlsx;*.pdf|"
                         + "Images |*.png;*.jpg;*.gif|"
                         + "All files |*.*";
            ofd.Multiselect = true;
            ofd.Title = "Sélectionner les fichiers à importer ....";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPJointes.Columns.Add("Fichier");
                txtPJointes.Columns.Add("Chemin Complet");
                foreach (string fichier in ofd.FileNames)
                {
                    FileInfo f = new FileInfo(fichier);
                    ListViewItem item = new ListViewItem(f.Name);
                    item.SubItems.Add(f.FullName);
                    txtPJointes.Items.Add(item);
                }
                txtPJointes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }

        }
    }
}
