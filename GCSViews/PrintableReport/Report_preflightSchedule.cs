using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.PrintableReport
{
    public partial class Report_preflightSchedule : Form
    {
        public Report_preflightSchedule()
        {
            this.Controls.Add(this.reportViewer1);
            InitializeComponent();
        }

        private void Report_preflightSchedule_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
