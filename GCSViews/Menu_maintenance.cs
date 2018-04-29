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
using System.IO;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_maintenance : MyUserControl
    {
        // SqlConnection con = new SqlConnection(@"Data Source=CS-RABBIT\SQLEXPRESS;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        string imgLocation = "";
        byte[] imgby;
        SqlCommand cmd;

        public Menu_maintenance()
        {
            InitializeComponent();
            MyView = new MainSwitcher(this);

            //show data to DataGridView
            con.Open();
            String query = "SELECT drone_id,drone_name,drone_pic FROM Drone";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_DronePart_Clicked;
        public String id_drone;

        protected virtual void OnGotoDronePartClicked(EventArgs e)
        {
            Goto_DronePart_Clicked?.Invoke(this, e);
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

        private void panelMaintenance_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT drone_id,drone_name FROM Drone";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {
            
        }
               
        private void BUT_add_drone_Click(object sender, EventArgs e)

        {
            try
            {
                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                
                String query = "INSERT INTO Drone (drone_id,drone_name,drone_pic) " + "VALUES(,'" + textBox_droneName.Text + "',@img)";

                if (con.State != ConnectionState.Open)
                { con.Open(); }

                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกข้อมูลโดรนสำเร็จ !!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //show data to DataGridView Drone
            con.Open();
            String query2 = "SELECT drone_id,drone_name FROM Drone";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            SDA2.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //detail part of drone
            Menu_maintenance_part menu_maintain_part = new Menu_maintenance_part(id_drone);
            menu_maintain_part.ShowUserControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete drone
            if (MessageBox.Show("ต้องการที่จะลบข้อมูลโดรนใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }                
                String query2 = "DELETE FROM Drone where drone_id = '" + textBox_droneID.Text + "' ";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                SDA2.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ลบข้อมูลโดรนเสร็จเรียบร้อย !!");
            }

            //show data to DataGridView
            con.Open();
            String query = "SELECT Drone_id,Drone_name FROM Drone";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
        }

       /* private void button_serch_Click(object sender, EventArgs e)
        {
            //search drone
            con.Open();
            String query = "SELECT * FROM Drone where drone_id = '" + textBox_droneID + "'OR drone_name = '"+textBox_droneName+"' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
            
        } */

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String query = "UPDATE Drone SET drone_id = '" + textBox_droneID.Text + "',drone_name = '" + textBox_droneName.Text + "',drone_pic = @imag";

                if (con.State != ConnectionState.Open)
                { con.Open(); }

                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();

                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("แก้ไขข้อมูลโดรนสำเร็จ !!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //show data to DataGridView Drone
            con.Open();
            String query2 = "SELECT drone_id,drone_name FROM Drone";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            SDA2.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
        }

        private void DG_Drone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            try
            {
                String query = "SELECT * FROM Drone ";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);            
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_droneID.Text = DG_Drone.SelectedRows[0].Cells[0].Value.ToString();
                    id_drone = DG_Drone.SelectedRows[0].Cells[0].Value.ToString();
                    textBox_droneName.Text = DG_Drone.SelectedRows[0].Cells[1].Value.ToString();
                    byte[] img = (byte[])(reader[2]);
                    if (img == null)
                    { pictureBox.Image = null; }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else MessageBox.Show("ไม่มีข้อมูลในฐานข้อมูล");

                //show data to gridView Part
                String query2 = "SELECT * FROM DeviceList WHERE drone_id = '"+textBox_droneID.Text+"'";
                if (con.State != ConnectionState.Open)
                { con.Open(); }                
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                DG_Part.DataSource = dt2;
                con.Close();                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }           

        }
        public void showGridView()
        { }

        private void button_MaintainPart_Click(object sender, EventArgs e)
        {
            //pass to previtive maintain
            Menu_maintenance_pre menu_maintenance_pre = new Menu_maintenance_pre(id_drone);
            menu_maintenance_pre.ShowUserControl();
        }

        private void DG_Part_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String query = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList WHERE drone_id = '"+textBox_droneID+"'";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_partID.Text = DG_Part.SelectedRows[0].Cells[0].Value.ToString();
                    textBox_partName.Text = DG_Part.SelectedRows[0].Cells[1].Value.ToString();
                    textBox_partPosition.Text = DG_Part.SelectedRows[0].Cells[2].Value.ToString();
                    textBox_partPrice.Text = DG_Part.SelectedRows[0].Cells[3].Value.ToString();
                    textBox_respon.Text = DG_Part.SelectedRows[0].Cells[11].Value.ToString();
                    textBox_venAdd.Text = DG_Part.SelectedRows[0].Cells[9].Value.ToString();
                    textBox_venName.Text = DG_Part.SelectedRows[0].Cells[8].Value.ToString();
                    textBox_venPhone.Text = DG_Part.SelectedRows[0].Cells[10].Value.ToString();
                    comboBox_alarm.Text = DG_Part.SelectedRows[0].Cells[7].Value.ToString();
                    //dateTimePicker_reg.Value.Date = DG_Part.SelectedRows[0].Cells[10].Value.ToString();
                    byte[] img = (byte[])(reader[8]);
                    if (img == null)
                    { pictureBox_part.Image = null; }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox_part.Image = Image.FromStream(ms);
                    }
                }
                else MessageBox.Show("ไม่มีข้อมูลในฐานข้อมูล");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_serchPart_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
                dialog.Title = "เลือกรูปภาพของส่วนประกอบโดรน";
                if (dialog.ShowDialog() == DialogResult.OK)
                {                    
                    imgLocation = dialog.FileName.ToString();
                    pictureBox_part.ImageLocation = imgLocation;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_serchDrrone_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
                dialog.Title = "เลือกรูปภาพของโดรน";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    pictureBox.ImageLocation = imgLocation;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_deletePart_Click(object sender, EventArgs e)
        {
            //delete drone
            if (MessageBox.Show("ต้องการที่จะลบข้อมูลส่วนประกอบโดรนใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                String query = "DELETE FROM DeviceList where device_id = '" + textBox_partID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ลบข้อมูลส่วนประกอบโดรนเสร็จเรียบร้อย !!");
            }

            //show data to DataGridView
            String query2 = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList WHERE drone_id = '" + id_drone + "' ";
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            cmd = new SqlCommand(query2, con);

            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            SDA2.Fill(dt);
            con.Close();
        }

        private void BUT_addPart_Click(object sender, EventArgs e)
        {
            try
            {
                // for date
                comboBox_alarm.SelectedItem.ToString();
                string format = "yyyy-MM-dd";

                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String query = "INSERT INTO DeviceList (device_id,device_name,device_position,device_startDate,device_buyDate,device_expDate,vender_name,vender_add,vender_phone,device_responder,device_pic,device_alarm,device_price,drone_id,device_remindDate) "
                                       + "VALUES('" + textBox_partID.Text + "','" + textBox_partName.Text + "','" + textBox_partPosition.Text + "','" + dateTimePicker_startDate.Value.ToString(format) + "','" + dateTimePicker_reg.Value.ToString(format) + "','" + dateTimePicker_expDate.Value.ToString(format) + "','" + textBox_venName.Text + "','" + textBox_venAdd.Text + "','" + textBox_venPhone.Text + "','" + textBox_respon.Text + "',@img,'" + comboBox_alarm.SelectedItem.ToString() + "','" + textBox_partPrice.Text + "','" + id_drone + "','" + dateTimePicker_startDate.Value.ToString(format) + "')";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกข้อมูลส่วนประกอบโดรนเสร็จเรียบร้อย !!");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //show data to dataGridView Part
            try
            {
                //show data to DataGridView
                String query = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList WHERE drone_id = '" + id_drone + "' ";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);

                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                con.Close();
                DG_Part.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_editPart_Click(object sender, EventArgs e)
        {
            try
            {
                // for date
                comboBox_alarm.SelectedItem.ToString();
                string format = "yyyy-MM-dd";

                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String query = "UPDATE DeviceList SET device_id = '" + textBox_partID.Text + "' , device_name = '" + textBox_partName.Text + "' , device_position = '" + textBox_partPosition.Text + "' , device_startDate = '" + dateTimePicker_startDate.Value.ToString(format) + "',device_buyDate = '" + dateTimePicker_reg.Value.ToString(format) + "',device_expDate = '" + dateTimePicker_expDate.Value.ToString(format) + "',vender_name = '" + textBox_venName.Text + "',vender_add = '" + textBox_venAdd.Text + "',vender_phone = '" + textBox_venPhone.Text + "',vender_responder = '" + textBox_respon.Text + "',device_img = @images,device_alarm = '" + comboBox_alarm.SelectedItem.ToString() + "',device_price = '" + textBox_partPrice.Text + "',device_pic = @img) ";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("แก้ไขข้อมูลส่วนประกอบโดรนเสร็จเรียบร้อย !!");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //show data to dataGridView Part
            try
            {
                //show data to DataGridView
                String query = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList WHERE drone_id = '" + id_drone + "' ";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);

                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                con.Close();
                DG_Part.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
