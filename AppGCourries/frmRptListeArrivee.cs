using AppGCourries.Models;
using AppGCourries.Reports;
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
    public partial class frmRptListeArrivee : Form
    {
        public frmRptListeArrivee()
        {
            InitializeComponent();
        }

        private void frmRptListeArrivee_Load(object sender, EventArgs e)
        {
            using (DBGCourriesContext db = new DBGCourriesContext())
            {
                List<ArriveeViewModel> list = new List<ArriveeViewModel>();
                list = db.Arrivee.Select(
                    p => new ArriveeViewModel
                    {
                        idArrivee= p.idArrivee,
                        Categ = p.Categorie.LibCateg,
                        Entite=p.Entites.LibEntite,
                        Annee= p.Annee,
                        NumCourrier=p.NumCourrier,
                        DateOrdre=p.DateOrdre,
                        NumOrdre=p.NumOrdre,
                        DateCourrier=(DateTime)p.DateCourrier,
                        Sujet=p.Sujet,
                        Remarques=p.Remarques
                    }
                    ).ToList();
                RptListeArrivee rpt = new RptListeArrivee();
                rpt.SetDataSource(list);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
        }
    }
}
