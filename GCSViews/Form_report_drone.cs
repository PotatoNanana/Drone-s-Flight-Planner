using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Report_Drone : Form
    {
        public Form_Report_Drone()
        {
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Report_Drone_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet9.DeviceList' table. You can move, or remove it, as needed.
            this.deviceListTableAdapter.Fill(this.droneFlightPlannerDataSet9.DeviceList);
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet8.Drone' table. You can move, or remove it, as needed.
            this.droneTableAdapter.Fill(this.droneFlightPlannerDataSet8.Drone);

        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "SELECT drone_id,drone_name FROM Drone WHERE drone_name = '"+comboBox_droneName.Text+"' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Noti.DataSource = dt;
            con.Close();
        }
    }
}
