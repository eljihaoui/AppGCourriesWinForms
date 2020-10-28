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
using AppGCourries.Shared;
using System.Web.UI.WebControls;

namespace AppGCourries.Courries_Departs
{
    public partial class ListDeparts : UserControl
    {
        public ListDeparts()
        {
            InitializeComponent();
        }

        private void ListDeparts_Load(object sender, EventArgs e)
        {
            List<DepartViewModel> list = SharedData.getListDeparts();
            dgvDeparts.DataSource = list;
            dgvDeparts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDeparts.AllowUserToOrderColumns = true;
            dgvDeparts.AllowUserToResizeColumns = true;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            AddNewDepart frm = new AddNewDepart();
            frm.ShowDialog();
        }
    }
}
