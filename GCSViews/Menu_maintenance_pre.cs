using System;
using System.Data;
using System.Windows.Forms;
using MissionPlanner.Controls;
using System.Data.SqlClient;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_maintenance_pre : MyUserControl
    {
        //SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;
        string id_deviceID = "";

        public Menu_maintenance_pre()
        {
            InitializeComponent();
            MyView = new MainSwitcher(this);            
        }

        public Menu_maintenance_pre(string id_drone,string deviceID)
        {
            this.id_drone = id_drone;
            this.id_deviceID = deviceID;
            InitializeComponent();
            MyView = new MainSwitcher(this);
        }

        Controls.MainSwitcher MyView;
        private string id_drone;

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
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            //show data to dataGridView
            String query = "SELECT maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_venderPhone,maintain_venderAdd,maintain_lenght,maintain_responder,maintain_date FROM Maintainance where device_id='" + id_deviceID +"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            con.Close();

            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                                           + "VALUES('" + id_deviceID + "',(select CONCAT('M00', MAX(CONVERT(INT, SUBSTRING(maintain_id, 3, 5)) + 1)) from Maintainance),'" + textBox_mainAct.Text + "','" + textBox_price.Text + "','" + textBox_venName.Text + "','" + textBox_venPhone.Text + "','" + textBox_venAdd.Text + "','" + textBox_time.Text + "','" + textBox_respond.Text + "','" + dateTimePicker.Value.ToString(format) + "')";

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
            String query2 = "SELECT * FROM Maintainance WHERE device_id = '" + id_deviceID + "'";
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

                String query = "UPDATE Maintainance SET device_id = '" + id_deviceID + "', maintain_activity = '" + textBox_mainAct.Text + "', maintain_price = '" + textBox_price.Text + "', maintain_venderName = '" + textBox_venName.Text + "', maintain_venderPhone = '" + textBox_venPhone.Text + "', maintain_venderAdd = '" + textBox_venAdd.Text + "', maintain_lenght = '" + textBox_time.Text + "', maintain_responder = '" + textBox_respond.Text + "', maintain_date = '" + dateTimePicker.Value.ToString(format) + "' where maintain_id = '" + textBox_mainID.Text +"'";

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
            String query2 = "SELECT * FROM Maintainance WHERE device_id = '" + id_deviceID + "'";
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
                    String query = "DELETE FROM Maintainance where maintain_id = '" + DG_Farm.SelectedRows[0].Cells[0].Value.ToString() + "' ";
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
            String query2 = "SELECT * FROM Maintainance WHERE device_id = '" + id_deviceID + "'";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            DG_Farm.DataSource = dt2;
            con.Close();
        }

        private void DG_Farm_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                String query = @"SELECT       *
FROM Maintainance INNER JOIN
                         DeviceList ON Maintainance.device_id = DeviceList.device_id
                         where DeviceList.drone_id  ='" + id_drone + "' and Maintainance.device_id='" + id_deviceID + "'";
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
                    textBox_time.Text = reader["maintain_lenght"].ToString(); // DG_Farm.SelectedRows[0].Cells[4].Value.ToString();
                    textBox_respond.Text = DG_Farm.SelectedRows[0].Cells[5].Value.ToString();
                    textBox_venName.Text = DG_Farm.SelectedRows[0].Cells[6].Value.ToString();
                    textBox_venAdd.Text = DG_Farm.SelectedRows[0].Cells[7].Value.ToString();
                    textBox_venPhone.Text = DG_Farm.SelectedRows[0].Cells[8].Value.ToString();
                }
                
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
