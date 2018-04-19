using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Notify_drone_part : Form
    {
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        private string droneId;

        public Form_Notify_drone_part()
        {
            InitializeComponent();
        }

        public Form_Notify_drone_part(string droneId)
        {
            this.droneId = droneId;
            InitializeComponent();
        }

        private void Form_Notify_drone_part_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partDroneNotify.DeviceList' table. You can move, or remove it, as needed.
            this.deviceListTableAdapter.Fill(this.partDroneNotify.DeviceList);

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();
            
            String query = "SELECT device_id,device_name,device_position,device_alarm FROM DeviceList WHERE drone_id = '" + droneId + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Noti.DataSource = dt;
            con.Close();
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Notify_drone_part_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessDialogKey(e.KeyData);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
