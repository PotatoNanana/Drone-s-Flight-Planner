using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Log;
using MissionPlanner.Utilities;
using MissionPlanner.Plugin;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_maintenance_pre : MyUserControl
    {
        //SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        public Menu_maintenance_pre()
        {
            InitializeComponent();
            MyView = new MainSwitcher(this);            
        }

        public Menu_maintenance_pre(string id_part)
        {
            this.id_part = id_part;
            InitializeComponent();
            MyView = new MainSwitcher(this);
        }

        Controls.MainSwitcher MyView;
        private string id_part;

        public static event EventHandler Goto_Drone_Clicked;

        protected virtual void OnGotoDroneClicked(EventArgs e)
        {
            Goto_Drone_Clicked?.Invoke(this, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMaintenance_pre_Paint(object sender, PaintEventArgs e)
        {
            //show data to dataGridView
            con.Open();
            String query = "SELECT maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_venderPhone,maintain_venderAdd,maintain_lenght,maintain_responder,maintain_date FROM Maintainance WHRER device_id = id_part";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                byte[] img = null;
                String query = "SELECT * FROM Maintainance WHERE device_id = '" + id_part + "'";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_mainID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
                    textBox_mainAct.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
                    dateTimePicker.Value = Convert.ToDateTime(DG_Farm.SelectedRows[0].Cells[2].Value);
                    textBox_price.Text = DG_Farm.SelectedRows[0].Cells[3].Value.ToString();
                    textBox_time.Text = DG_Farm.SelectedRows[0].Cells[4].Value.ToString();
                    textBox_respond.Text = DG_Farm.SelectedRows[0].Cells[5].Value.ToString();
                    textBox_venName.Text = DG_Farm.SelectedRows[0].Cells[6].Value.ToString();
                    textBox_venAdd.Text = DG_Farm.SelectedRows[0].Cells[7].Value.ToString();
                    textBox_venPhone.Text = DG_Farm.SelectedRows[0].Cells[8].Value.ToString();
                }
                else MessageBox.Show("ไม่มีข้อมูลในฐานข้อมูล");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_pre_Click(object sender, EventArgs e)
        {
            try
            {
                string format = "yyyy-MM-dd";

                String query = "INSERT INTO Maintainance (device_id,maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_venderPhone,maintain_venderAdd,maintain_lenght,maintain_responder,maintain_date) "
                                           + "VALUES('" + id_part + "','" + textBox_mainID.Text + "','" + textBox_mainAct.Text + "','" + textBox_price.Text + "','" + textBox_venName.Text + "','" + textBox_venPhone.Text + "','" + textBox_venAdd.Text + "','" + textBox_time.Text + "','" + textBox_respond.Text + "','" + dateTimePicker.Value.ToString(format) + "')";

                if (con.State != ConnectionState.Open)
                { con.Open(); }
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกข้อมูลการบำรุงรักษาส่วนประกอบโดรนเสร็จเรียบร้อย !!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //show data to dataGridView
            con.Open();
            String query2 = "SELECT * FROM Maintainance WHERE device_id = '" + id_part + "'";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            DG_Farm.DataSource = dt2;
            con.Close();
        }
        
        private void but_backto_pre_Click(object sender, EventArgs e)
        {
            OnGotoDroneClicked(e); 
        }

        private void button_edit_Click(object sender, EventArgs e)
        {            
            try
            {
                string format = "yyyy-MM-dd";

                String query = "INSERT INTO Maintainance SET device_id = '" + id_part + "',maintain_id = '" + textBox_mainID.Text + "', maintain_activity = '" + textBox_mainAct.Text + "', maintain_price = '" + textBox_price.Text + "', maintain_venderName = '" + textBox_venName.Text + "', maintain_vendorPhone = '" + textBox_venPhone.Text + "', maintain_venderAdd = '" + textBox_venAdd.Text + "', maintain_length = '" + textBox_time.Text + "', maintain_responder = '" + textBox_respond.Text + "', maintain_date = '" + dateTimePicker.Value.ToString(format) + "') ";

                if (con.State != ConnectionState.Open)
                { con.Open(); }
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("แก้ไขข้อมูลการบำรุงรักษาส่วนประกอบโดรนเสร็จเรียบร้อย !!");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //show data to dataGridView
            con.Open();
            String query2 = "SELECT * FROM Maintainance WHERE device_id = '" + id_part + "'";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            DG_Farm.DataSource = dt2;
            con.Close();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ต้องการที่จะลบข้อมูลการบำรุงรักษาส่วนประกอบโดรนนี้ใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE * FROM Maintainance where maintain_id = '" + textBox_mainID.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ลบข้อมูลการบำรุงรักษาส่วนประกอบโดรนเสร็จเรียบร้อย !!");
                }                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //show data to dataGridView
            con.Open();
            String query2 = "SELECT * FROM Maintainance WHERE device_id = '" + id_part + "'";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            DG_Farm.DataSource = dt2;
            con.Close();
        }
    }
}
