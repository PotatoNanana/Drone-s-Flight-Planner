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

namespace MissionPlanner.GCSViews
{
    public partial class Form_Edit_act : Form
    {
        public Form_Edit_act()
        {
            InitializeComponent();
        }

        public Form_Edit_act(string id_act)
        {
            this.id_act = id_act;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;
        private string id_act;

        private void But_update_Click(object sender, EventArgs e)
        {
            //edit
            con.Open();

            string format = "yyyy-MM-dd";

            String query = "UPDATE FlightSchedule SET action_no = '" + textBox_actID.Text + "',farm_id = '" + textBox_farmID.Text + "',drone_id = '" + textBox_droneID.Text + "',action_name = '" + textBox_actName.Text + "',action_capacity = '" + textBox_cap.Text + "',action_cost = '" + textBox_cost.Text + "',action_datetime = '" + dateTimePicker.Value.ToString(format) + "' ";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Save To DB Success!!");

            this.Close();
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
