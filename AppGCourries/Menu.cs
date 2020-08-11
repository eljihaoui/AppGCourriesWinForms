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
    }
}
