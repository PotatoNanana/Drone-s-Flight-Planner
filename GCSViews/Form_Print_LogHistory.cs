using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Print_LogHistory : Form
    {
        List<TranAct> _list;
        Drone _drone;

        public Form_Print_LogHistory(Drone drone, List<TranAct> list)
        {
            InitializeComponent();
            _drone = drone;
            _list = list;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Init crystal report
            rptOrders1.SetDataSource(_list);
            rptOrders1.SetParameterValue("pDroneId", _drone.Drone_id);
            rptOrders1.SetParameterValue("pDroneName", _drone.Drone_name);
            crystalReportViewer.ReportSource = ;
            crystalReportViewer.Refresh();
        }
    }
}
