using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace testapp
{
    public partial class CrystalReportViewerForm : Form
    {
        public CrystalReportViewerForm()
        {
            InitializeComponent();
            ConfigureReportViewer();
        }
        public void ConfigureReportViewer()
        {
            CrystalReportViewer crystalReportViewer1 = new CrystalReportViewer();

            // Setting properties for the CrystalReportViewer
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None; // Hide Tool Panel
            crystalReportViewer1.DisplayToolbar = true; // Show toolbar
            crystalReportViewer1.DisplayStatusBar = false; // Hide status bar if not needed
            crystalReportViewer1.Zoom(1); // Default zoom (1 = 100%)
            crystalReportViewer1.Dock = DockStyle.Fill; // Make the viewer fill the form
        }

        private void CrystalReportViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReportViewerForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
