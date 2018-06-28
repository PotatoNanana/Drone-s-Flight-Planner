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
    public partial class Form_Print_farm_act : Form
    {
        public Form_Print_farm_act(DataReport.Farm_act obj, List<DataReport.Farm> list)
        {
            InitializeComponent();
        }

        private void Form_Print_farm_act_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Init data source
            afterFlightBindingSource.DataSource = _list;
            //Set parameter for your report
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderID",_orders.OrderID.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderDate",_orders.OrderDate.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("pContactName",_orders.ContactName),
                new Microsoft.Reporting.WinForms.ReportParameter("pPostalCode",_orders.PostalCode),
                new Microsoft.Reporting.WinForms.ReportParameter("pAddress",_orders.Address),
                new Microsoft.Reporting.WinForms.ReportParameter("pCity",_orders.City),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhone",_orders.Phone)
            };
            this.Report.LocalReport.SetParameters(p);
            this.reportViewer.RefreshReport();
        }
    }
}
