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
    public partial class Form_Print_PartMaintain : Form
    {
        List<PartMaintain> _list;
        DronePart _dronePart;

        public Form_Print_PartMaintain(DronePart dronePart, List<PartMaintain> list)
        {
            InitializeComponent();
            _dronePart = dronePart;
            _list = list;
        }

        private void Form_Print_PartMaintain_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //Init crystal report
            rptOrders.SetDataSource(_list);
            rptOrders.SetParameterValue("pDevice_id", _dronePart.Device_id );
            rptOrders.SetParameterValue("pDevice_name", _dronePart.Device_name);
            rptOrders.SetParameterValue("pDevice_position", _dronePart.Device_position);
            rptOrders.SetParameterValue("pDevice_price", _dronePart.Device_price);
            rptOrders.SetParameterValue("pDevice_buyDate", _dronePart.Device_buyDate.ToString("yyyy-MM-dd"));
            rptOrders.SetParameterValue("pDevice_expDate", _dronePart.Device_expDate.ToString("yyyy-MM-dd"));
            rptOrders.SetParameterValue("pDevice_startDate", _dronePart.Device_startDate.ToString("yyyy-MM-dd"));
            rptOrders.SetParameterValue("pDevice_responder", _dronePart.Device_responder);
            rptOrders.SetParameterValue("pDevice_alarm", _dronePart.Device_alarm);
            rptOrders.SetParameterValue("pVender_name", _dronePart.Vender_name);
            rptOrders.SetParameterValue("pVender_add", _dronePart.Vender_add);
            rptOrders.SetParameterValue("pVender_phone", _dronePart.Vender_phone);
            rptOrders.SetParameterValue("pDrone_id", _dronePart.Drone_id);
            //rptOrders1.SetParameterValue("p", );
            crystalReportViewer.ReportSource = rptOrders;
            crystalReportViewer.Refresh();
        }
    }
}
