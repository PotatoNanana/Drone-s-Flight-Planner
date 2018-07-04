using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.Print_Form
{
    public partial class Form_Print_drone_part : Form
    {
        Drone _obj;
        List<DronePart> _list;

        public Form_Print_farm_act(Drone obj, List<DronePart> list)
        {
            InitializeComponent();
            _obj = obj;
            _list = list;
        }

        private void Form_Print_drone_part_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Init data source
            drone.DataSource = _list;
            //Set parameter for your report
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("param_drone_id",_obj.drone_id),
                new Microsoft.Reporting.WinForms.ReportParameter("param_drone_name",_obj.drone_name),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }            
        
        
    }
}
