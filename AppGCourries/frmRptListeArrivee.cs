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
        private readonly string Critere;
        private readonly bool UseDate;
        private readonly DateTime DateDebut, DateFin;
        public frmRptListeArrivee()
        {
            InitializeComponent();
        }

        public frmRptListeArrivee(string critere, bool useDate, DateTime dateDebut, DateTime dateFin)
        {
            InitializeComponent();
            this.Critere = critere;
            this.UseDate = useDate;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
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
                if (!String.IsNullOrEmpty(this.Critere))
                {
                    list = list.Where(x => x.Sujet.ToLower().Contains(this.Critere.ToLower())).ToList();
                }
                if (UseDate)
                {
                    list = list.Where(x => x.DateOrdre>=this.DateDebut && x.DateOrdre<=this.DateFin).ToList();
                }
                RptListeArrivee rpt = new RptListeArrivee();
                rpt.SetDataSource(list);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
        }
    }
}
