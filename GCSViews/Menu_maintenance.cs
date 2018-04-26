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

                String query = "INSERT INTO Drone (drone_id,drone_name,drone_pic) " + "VALUES('" + textBox_droneID.Text + "','" + textBox_droneName.Text + "',@img)";

                if (con.State != ConnectionState.Open)
                { con.Open(); }

                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกโดรนสำเร็จ!!");

            }
            catch (Exception ex)
            {  MessageBox.Show(ex.Message);    }

            //show data to data grid view
            String query2 = "SELECT * FROM Drone WHERE drone_id = '" + textBox_droneID.Text + "'";
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            cmd = new SqlCommand(query2, con);
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
            try
            {
                //delete drone
                if (MessageBox.Show("ต้องการที่จะลบโดรนใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    String query2 = "DELETE FROM Drone where drone_id = '" + textBox_droneID.Text + "' ";
                    SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                    SDA2.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ลบข้อมูลเสร็จเรียบร้อย !!");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }            

            //show data to data grid view
            String query = "SELECT * FROM Drone WHERE drone_id = '" + textBox_droneID.Text + "'";
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
                byte[] images = null;
                FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                images = brs.ReadBytes((int)Streem.Length);

                String query = "UPDATE Drone SET drone_id = '" + textBox_droneID.Text + "',drone_name = '" + textBox_droneName.Text + "',drone_pic = @images";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();

                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int N = cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("บันทึกข้อมูลสำเร็จ !!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //show data to data grid view
            String query2 = "SELECT * FROM Drone WHERE drone_id = '" + textBox_droneID.Text + "'";
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            cmd = new SqlCommand(query2, con);
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
            con.Close();
        }

        private void DG_Drone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            try
            {
                //show data drone to datagridview
                String query = "SELECT * FROM Drone WHERE drone_id = '" + textBox_droneID.Text + "'";
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
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }          

        }
        public void showGridView()
        { }

        private void button_serch_Click(object sender, EventArgs e)
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

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show data to grid view
            try
            {
                String query = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList WHERE drone_id = '" + textBox_droneID.Text + "' ";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
               // cmd.Parameters.Add("@iddrone", id_drone); // if in same dbo or same schema use like this first
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_partID.Text = DG_Part.SelectedRows[0].Cells[0].Value.ToString();
                    textBox_partName.Text = DG_Part.SelectedRows[0].Cells[1].Value.ToString();
                    byte[] img = (byte[])(reader[8]);
                    if (img == null)
                    { pictureBox.Image = null; }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else MessageBox.Show("ไม่มีข้อมูลในฐานข้อมูล");
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
                dialog.Title = "เลือกรูปภาพของชิ้นส่วนโดรน";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    /*imgLocation = dialog.FileName.ToString();
                    imgby = imageToByteArray(Image.FromFile(dialog.FileName));
                    pictureBox.ImageLocation = imgLocation; */

                    imgLocation = dialog.FileName.ToString();
                    pictureBox.ImageLocation = imgLocation;

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void But_savePart_Click(object sender, EventArgs e)
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

                String query = "INSERT INTO DeviceList (device_id,device_name,device_position,device_startDate,device_buyDate,device_expDate,vender_name,vender_add,vender_phone,device_responder,device_pic,device_alarm,device_price,drone_id) "
                                       + "VALUES('" + textBox_partID.Text + "','" + textBox_partName.Text + "','" + textBox_partPosition.Text + "','" + dateTimePicker_startDate.Value.ToString(format) + "','" + dateTimePicker_reg.Value.ToString(format) + "','" + dateTimePicker_ExpDate.Value.ToString(format) + "','" + textBox_VenName.Text + "','" + textBox_venAdd.Text + "','" + textBox_venPhone.Text + "','" + textBox_respond.Text + "',@img,'" + comboBox_alarm.SelectedItem.ToString() + "','" + textBox_price.Text + "','" + id_drone + "')";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save To DB Success!!");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_maintenance_Load(object sender, EventArgs e)
        {

        }
    }
}
