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
using System.IO;

namespace MissionPlanner.GCSViews
{
    public partial class Form_farm_Schedule : Form
    {
        public Form_farm_Schedule()
        {
            InitializeComponent();            
        }

        public Form_farm_Schedule(string id_farm)
        {
            this.id_farm = id_farm;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();        
        SqlCommand cmd;
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
            textBox_actID.Text = DG_Farm.SelectedRows[0].Cells[2].Value.ToString();
            textBox_actName.Text = DG_Farm.SelectedRows[0].Cells[3].Value.ToString();
            textBox_droneID.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
            textBox_cap.Text = DG_Farm.SelectedRows[0].Cells[4].Value.ToString();
            textBox_cost.Text = DG_Farm.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void But_add_act_Click(object sender, EventArgs e)
        {             
            try
            {
                
               // String query = "INSERT INTO Farm (farm_id,farm_name,farm_location,farm_host,farm_pic) " + "VALUES('" + textBox_farmID.Text + "','" + textBox_farmName.Text + "','" + textBox_farmLocation.Text + "','" + textBox_farmHost.Text + "',@img)";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                string format = "yyyy-MM-dd";
                String query = "INSERT INTO FlightSchedule (action_no,farm_id,drone_id,action_name,action_capacity,action_cost,action_datetime) " + "VALUES('" + textBox_actID.Text + "','" + id_farm + "','" + textBox_droneID.Text + "','" + textBox_actName.Text + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "','" + monthCalendar1.Value.ToString(format) + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกข้อมูลสำเร็จ !!");
              
                //show data to DataGridView
                con.Open();
                String query2 = "SELECT * FROM ";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                SDA2.Fill(dt);
                DG_Farm.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        private void button_delete_Click(object sender, EventArgs e)
        {
            // delete Schedule
            if (MessageBox.Show("ต้องการลบกิจกรรมนี้ใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                String query = "DELETE FROM FlightSchedule where action_no = '" + textBox_actID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ลบข้อมูลลกิจกรรมสำเร็จ !!");

                //string a = "yyyy-MM-dd";

                // show data to data Grid view
                String query2 = "SELECT * FROM FlightSchedule WHERE farm_id = '" + id_farm + "' AND action_finish = 'n' ";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                SDA2.Fill(dt);
                DG_Farm.DataSource = dt;
                con.Close();
            }
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {            
            try
            {
                // String query = "INSERT INTO Farm (farm_id,farm_name,farm_location,farm_host,farm_pic) " + "VALUES('" + textBox_farmID.Text + "','" + textBox_farmName.Text + "','" + textBox_farmLocation.Text + "','" + textBox_farmHost.Text + "',@img)";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                string format = "yyyy-MM-dd";
                String query = "UPDATE FlightSchedule SET farm_id = '" + id_farm + "',drone_id = '" + textBox_droneID.Text + "',action_no = '" + textBox_actID.Text + "',action_datetime = '" + monthCalendar1.Value.ToString(format) + "',action_name = '" + textBox_actName.Text + "',action_capacity = '" + textBox_cap.Text + "',action_cost = '" + textBox_cost.Text + "') ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();                
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ !!");

                //show data to DataGridView
                con.Open();
                String query2 = "SELECT * FROM ";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                SDA2.Fill(dt);
                DG_Farm.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            // serch record
        }

        private void Form_farm_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightSchedule2.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter.Fill(this.flightSchedule2.FlightSchedule);
            // TODO: This line of code loads data into the 'flightSchedule1.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter1.Fill(this.flightSchedule1.FlightSchedule);
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet3.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter.Fill(this.droneFlightPlannerDataSet3.FlightSchedule);
            // TODO: This line of code loads data into the 'schedule_act.schedule_action' table. You can move, or remove it, as needed.
            //this.schedule_actionTableAdapter.Fill(this.schedule_act.schedule_action);

        }

        private void textBox_actName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_actID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_farm_Schedule_KeyDown(object sender, KeyEventArgs e)
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

        private void panelFarm_schedule_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            con.Open();

            //string a = "yyyy-MM-dd";

            String query2 = "SELECT * FROM FlightSchedule WHERE farm_id = '" + id_farm + "' AND action_finish = 'n' ";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            SDA2.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }
    }
}
