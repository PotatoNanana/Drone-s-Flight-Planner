using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.DataReport;
using Dapper;
using System.Configuration;

namespace MissionPlanner.GCSViews.Print_Form
{
    public partial class Form_Print_farm_act : Form
    {      
        Farm _obj;
        List<Farm_act> _list;

        public Form_Print_farm_act(Farm obj, List<Farm_act> list)
        {
            InitializeComponent();
            _obj = obj;
            _list = list;           
        }
        
        private void Form_Print_farm_act_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Init data source
            FarmBidingSource.DataSource = _list;
            //Set parameter for your report
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("param_farm_id",_obj.Farm_id),
                new Microsoft.Reporting.WinForms.ReportParameter("param_farm_name",_obj.Farm_name),
                new Microsoft.Reporting.WinForms.ReportParameter("param_farm_host",_obj.Farm_host),
                new Microsoft.Reporting.WinForms.ReportParameter("param_farm_location",_obj.Farm_location),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
