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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBGCourriesContext db = new DBGCourriesContext();
            dataGridView1.DataSource = db.Categorie.Select(
                p => new
                {
                    ID = p.idCateg,
                    Catégorie=p.LibCateg
                }).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBGCourriesContext db = new DBGCourriesContext();
            Categorie c = new Categorie();
            c.idCateg = 10;
            c.LibCateg = "top top secret";
            db.Categorie.Add(c);
            db.SaveChanges();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            DBGCourriesContext db = new DBGCourriesContext();
            Categorie c = db.Categorie.FirstOrDefault(x => x.idCateg == 1);
            c.LibCateg = "blblblblbl";
            db.SaveChanges();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            DBGCourriesContext db = new DBGCourriesContext();
            Categorie c = db.Categorie.FirstOrDefault(x => x.idCateg == 10);
            db.Categorie.Remove(c);
            db.SaveChanges();
        }
    }
}
