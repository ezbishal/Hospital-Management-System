using CRUD;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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

namespace HMS
{
    public partial class Report : Sample1
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Application.StartupPath + "\\Reports\\" + "PrescriptionReport.rpt");

            ParameterFields myParam = new ParameterFields();
            ParameterField name = new ParameterField();
            ParameterDiscreteValue valName = new ParameterDiscreteValue();
            name.ParameterFieldName = "@appID";
            valName.Value = Payment.apptID;
            name.CurrentValues.Add(valName);
            myParam.Add(name);

            crystalReportViewer1.ParameterFieldInfo = myParam;
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Refresh();
        }
    }
}
