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
    public partial class Form_Edit_farm_act : Form
    {
        public Form_Edit_farm_act()
        {
            InitializeComponent();
            
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_save_Click(object sender, EventArgs e)
        {
            con.Open();

            string format = "yyyy-MM-dd";

            String query = "UPDATE schedule_action SET farm_id = '" + textBox_farmID.Text + "',action_no = '" + textBox_actID.Text + "',action_name = '" + textBox_actName.Text + "',action_capacity = '" + textBox_cap.Text + "',action_cost = '" + textBox_cost.Text + "',action_date = '" + dateTimePicker.Value.ToString(format) + "',drone_id = '" + textBox_droneID.Text + "') ";
            
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Edit To DB Success!!");

            this.Close();
        }
    }
}
