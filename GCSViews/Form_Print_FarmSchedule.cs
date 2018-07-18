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
            rptOrders1.SetDataSource(_list);
            rptOrders1.SetParameterValue("pFarm_id", _farm.Farm_id);
            rptOrders1.SetParameterValue("pFarmName", _farm.Farm_name);
            rptOrders1.SetParameterValue("pFarm_host", _farm.Farm_host);
            rptOrders1.SetParameterValue("pFarm_address", _farm.Farm_address);
            rptOrders1.SetParameterValue("pFarm_road", _farm.Farm_road);
            rptOrders1.SetParameterValue("pFarm_subDistrict", _farm.Farm_subDistrict);
            rptOrders1.SetParameterValue("pFarm_district", _farm.Farm_district);
            rptOrders1.SetParameterValue("pFarm_province", _farm.Farm_province);
            rptOrders1.SetParameterValue("pFarm_postal", _farm.Farm_postal);            
            crystalReportViewer.ReportSource = ;
            crystalReportViewer.Refresh();
        }
    }
}
