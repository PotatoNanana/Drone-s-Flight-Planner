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
    public partial class Form_farm_act : Form
    {
        public Form_farm_act()
        {
            InitializeComponent();

        }
        
        public Form_farm_act(string id_farm)
        {
            this.id_farm = id_farm;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        private string id_farm;

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DG_Farm_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            textBox_actID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
            textBox_actName.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void But_add_act_Click(object sender, EventArgs e)
        { 
            // pass to add act
            Form_Add_farm_act form_Add_Farm_Act = new Form_Add_farm_act();
            form_Add_Farm_Act.ShowDialog();
        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();

            //string a = "yyyy-MM-dd";
            string dateNow = String.Format("{0:yyyy-MM-dd}", DateTime.Now);

            String query = "SELECT * FROM schedule_action WHERE farm_id = '" + id_farm + "' AND action_date < '"+ dateNow+"' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void Form_farm_act_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightSchedule.FlightSchedule' table. You can move, or remove it, as needed.
            this.flightScheduleTableAdapter.Fill(this.flightSchedule.FlightSchedule);
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet1.schedule_action' table. You can move, or remove it, as needed.
            //this.schedule_actionTableAdapter.Fill(this.droneFlightPlannerDataSet1.schedule_action);

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // delete
            if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string query = "DELETE FROM FlightSchedule where action_id = '" + textBox_actID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("DELETE Record From DB Success!!");
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // pass to edit act
            Form_Edit_farm_act form_edit_farm_act = new Form_Edit_farm_act(id_farm);
            form_edit_farm_act.ShowDialog();

        }
    }
}
