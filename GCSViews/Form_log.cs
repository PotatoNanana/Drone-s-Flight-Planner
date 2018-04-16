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
    public partial class Form_log : Form
    {
        private string file;

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        public Form_log()
        {
            InitializeComponent();
        }

        public Form_log(string file)
        {
            InitializeComponent();
            this.file = file;
        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        public String droneId;

        private void But_save_Click(object sender, EventArgs e) // 
        {
            con.Open();

            // edit flight log
            String query = "INSERT INTO FlightLog (log_no,action_no,farm_no,drone_id,pattern_name,pattern_mask) " + "VALUES('" + textBox_logNo.Text + "','" +textBox_actNo.Text + "','" + textBox_farmID.Text + "','" + textBox_droneID.Text +"','" + file + "','" +textBox_patternMask.Text+"' )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            // update status activity in flight_schedule
            String query2 = "UPDATE FlightSchedule SET action_finish = 'y' ";

            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save To DB Success!!");

            //notify drone tools
            droneId = textBox_droneID.Text;
            
            //go to form notify drone part 
            Form_Notify_drone_part form_notify_drone_part = new Form_Notify_drone_part(droneId);
            form_notify_drone_part.ShowDialog();

            this.Close();
        }

        private void textBox_patternName_TextChanged(object sender, EventArgs e)
        {
            textBox_patternName.Text = file;
        }
    }
}
