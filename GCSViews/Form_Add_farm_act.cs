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
    public partial class Form_Add_farm_act : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;
        private string id_farm;

        public Form_Add_farm_act()
        {
            InitializeComponent();           
        }

        public Form_Add_farm_act(string id_farm)
        {
            this.id_farm = id_farm;
            InitializeComponent();
        }

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
            
            String query = "INSERT INTO FlightSchedule (action_no,farm_id,drone_id,action_name,action_capacity,action_cost,action_datetime) " + "VALUES('" + textBox_actID.Text + "','" + id_farm + "','" + textBox_droneID.Text + "','" + textBox_actName.Text + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "','" + dateTimePicker.Value.ToString(format) + "')";
            
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show("Save To DB Success!!");

            this.Close();
        }

        private void Form_Add_farm_act_Load(object sender, EventArgs e)
        {

        }

        private void textBox_farmID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_droneID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
