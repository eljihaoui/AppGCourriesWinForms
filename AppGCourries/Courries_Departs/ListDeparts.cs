using System;
using System.Collections.Generic;
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
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            AddNewDepart frm = new AddNewDepart(this);
            frm.ShowDialog();
        }
    }
}
