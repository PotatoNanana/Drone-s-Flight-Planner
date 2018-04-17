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
            FlightPlanner FP = new FlightPlanner();
            // FlightPlanner.id_farm = ID_farm;
            // FlightPlanner.id_drone = ID_drone;
            string ID_farm = FlightPlanner.id_farm;       
            string ID_drone = FlightPlanner.id_drone;

            con.Open();

            // edit flight log
            String query = "INSERT INTO FlightLog (log_no,action_no,farm_no,drone_id,pattern_name,pattern_mask) " + "VALUES('" + textBox_logNo.Text + "','" +textBox_actNo.Text + "','" + ID_farm + "','" + ID_drone +"','" + file + "','" +textBox_patternMask.Text+"' )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            // update status activity in flight_schedule
            String query2 = "UPDATE FlightSchedule SET action_finish = 'y' ";

            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save To DB Success!!");

            //notify drone tools
            droneId = ID_drone;
            
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
