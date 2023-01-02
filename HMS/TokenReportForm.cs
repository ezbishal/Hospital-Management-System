using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD;
using CrystalDecisions.CrystalReports.Engine;

namespace HMS
{
    public partial class TokenReportForm : Sample1
    {
        public TokenReportForm()
        {
            InitializeComponent();
        }

        private void TokenReportForm_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            Hashtable ht = new Hashtable();
            if (PatientRegistration.gridClick == 1)
            {
                ht.Add("@day", PatientRegistration.d);
                ht.Add("@month", PatientRegistration.m);
                ht.Add("@year", PatientRegistration.y);
                ht.Add("@hours", PatientRegistration.hours);
                ht.Add("@min", PatientRegistration.minutes);

                crud.showReport("st_getTokenNoWRTDateTime", rd, "TokenReport.rpt", ht, crystalReportViewer1);
            }
            else
            {
                ht.Add("@day", PatientRegistration.d);
                ht.Add("@month", PatientRegistration.m);
                ht.Add("@year", PatientRegistration.y);
                crud.showReport("st_getLastTokenNo", rd, "TokenReport.rpt", ht, crystalReportViewer1);

            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void TokenReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }
    }
}
