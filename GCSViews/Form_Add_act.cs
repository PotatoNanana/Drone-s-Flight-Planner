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
    public partial class Form_Add_act : Form
    {
        public Form_Add_act()
        {
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        private void But_save_Click(object sender, EventArgs e)
        {
            con.Open();

            string format = "yyyy-MM-dd";

            String query = "INSERT INTO FlightSchedule (action_no,farm_id,drone_id,action_name,action_capacity,action_cost,action_datetime) " + "VALUES('" + textBox_actID.Text + "','" + textBox_farmID.Text + "','" + textBox_droneID.Text + "','" + textBox_actName.Text + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "','" + dateTimePicker.Value.ToString(format) + "')";

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

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Add_act_KeyDown(object sender, KeyEventArgs e)
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
