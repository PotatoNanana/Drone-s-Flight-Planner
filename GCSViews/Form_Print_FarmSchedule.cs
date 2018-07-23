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
        List<FarmSchedule> _list;
        Farm _farm;

        public Form_Print_FarmSchedule(Farm farm, List<FarmSchedule> list)
        {
            InitializeComponent();
            _farm = farm;
            _list = list;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Init crystal report
            rptOrders2.SetDataSource(_list);
            rptOrders2.SetParameterValue("pFarm_id", _farm.Farm_id);
            rptOrders2.SetParameterValue("pFarmName", _farm.Farm_name);
            rptOrders2.SetParameterValue("pFarm_host", _farm.Farm_host);
            rptOrders2.SetParameterValue("pFarm_address", _farm.Farm_address);
            rptOrders2.SetParameterValue("pFarm_road", _farm.Farm_road);
            rptOrders2.SetParameterValue("pFarm_subDistrict", _farm.Farm_subDistrict);
            rptOrders2.SetParameterValue("pFarm_district", _farm.Farm_district);
            rptOrders2.SetParameterValue("pFarm_province", _farm.Farm_province);
            rptOrders2.SetParameterValue("pFarm_postal", _farm.Farm_postal);            
            crystalReportViewer.ReportSource = rptOrders2;
            crystalReportViewer.Refresh();
        }
    }
}
