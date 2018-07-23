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
    public partial class Form_Print_FarmSchedule : Form
    {
        List<FarmActPast> _list;
        Farm _farm;

        public Form_Print_FarmSchedule(Farm farm , List<FarmActPast> list)
        {
            InitializeComponent();
            _farm = farm;
            _list = list;
        }

        private void Form_Print_FarmSchedule_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            //Init crystal report
            rptOrders3.SetDataSource(_list);
            rptOrders3.SetParameterValue("pFarm_id", _farm.Farm_id);
            rptOrders3.SetParameterValue("pFarmName", _farm.Farm_name);
            rptOrders3.SetParameterValue("pFarm_host", _farm.Farm_host);
            rptOrders3.SetParameterValue("pFarm_address", _farm.Farm_address);
            rptOrders3.SetParameterValue("pFarm_road", _farm.Farm_road);
            rptOrders3.SetParameterValue("pFarm_subDistrict", _farm.Farm_subDistrict);
            rptOrders3.SetParameterValue("pFarm_district", _farm.Farm_district);
            rptOrders3.SetParameterValue("pFarm_province", _farm.Farm_province);
            rptOrders3.SetParameterValue("pFarm_postal", _farm.Farm_postal);
            //rptOrders1.SetParameterValue("p", );
            crystalReportViewer.ReportSource = rptOrders3;
            crystalReportViewer.Refresh();
        }
    }
}
