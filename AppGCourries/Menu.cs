using AppGCourries.Courries_Arrivees;
using AppGCourries.Courries_Departs;
using System;
using System.Windows.Forms;

namespace AppGCourries
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            btnArrivees_Click(sender, e);
        }

        private void btnArrivees_Click(object sender, EventArgs e)
        {
            ListArrivee frmList = new ListArrivee();
            frmList.Dock = DockStyle.Fill;
            pContent.Controls.Clear();
            pContent.Controls.Add(frmList);
           
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            ListDeparts frmList = new ListDeparts();
            frmList.Dock = DockStyle.Fill;
            pContent.Controls.Clear();
            pContent.Controls.Add(frmList);
        }
    }
}
