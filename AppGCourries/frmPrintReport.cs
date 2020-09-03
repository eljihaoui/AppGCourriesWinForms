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
    public partial class frmPrintReport : Form
    {

        public frmPrintReport()
        {
            InitializeComponent();
        }

        public void linkReport(CrystalDecisions.CrystalReports.Engine.ReportDocument rpt)
        {
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.RefreshReport();
        }

 
    }
}
