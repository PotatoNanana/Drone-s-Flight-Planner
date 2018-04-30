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
    public partial class Menu_farm : MyUserControl
    {
        public Menu_farm()
        {
            InitializeComponent();            
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        public string id_farm;
        string imgLocation = "";
        byte[] imgby;
        SqlCommand cmd;       

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

        private void panelFarm_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT * FROM Farm";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //click and show  data to dataGridView
            try
            {
                String query = "SELECT * FROM Farm ";
                if (con.State != ConnectionState.Open)
                     { con.Open(); }
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox_farmID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
                    id_farm = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
                    textBox_farmName.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
                    textBox_farmLocation.Text = DG_Farm.SelectedRows[0].Cells[3].Value.ToString();
                    textBox_farmHost.Text = DG_Farm.SelectedRows[0].Cells[2].Value.ToString();
                    byte[] img = (byte[])(reader[4]);
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

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_farm_Click(object sender, EventArgs e)
        {
            try
            {
                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String query = "INSERT INTO Farm (farm_id,farm_name,farm_location,farm_host,farm_pic) " + "VALUES('" + textBox_farmID.Text + "','" + textBox_farmName.Text + "','" + textBox_farmLocation.Text + "','" + textBox_farmHost.Text + "',@img)";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกข้อมูลสำเร็จ !!");

                //show data to DataGridView
                con.Open();
                String query2 = "SELECT * FROM Farm";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                SDA2.Fill(dt);
                DG_Farm.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_pastAct_Click(object sender, EventArgs e)
        {
            // activity in past
            Form_farm_act form_Farm_Act = new Form_farm_act(id_farm);
            form_Farm_Act.ShowDialog();
        }

        private void button_futureAct_Click(object sender, EventArgs e)
        {
            // activity in future
            Form_farm_Schedule form_Farm_Schedule = new Form_farm_Schedule(id_farm);
            form_Farm_Schedule.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("คุณต้อการลบฟาร์มนี้ใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE FROM Farm where farm_id = '" + textBox_farmID.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ทำการลบข้อมูลเรียบร้อยแล้ว !!");

                    //show data to DataGridView
                    con.Open();
                    String query2 = "SELECT * FROM Farm";
                    SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                    DataTable dt = new DataTable();
                    SDA2.Fill(dt);
                    DG_Farm.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String query = "UPDATE Farm SET farm_id = '" + textBox_farmID.Text + "',farm_name = '" + textBox_farmName.Text + "',farm_location = '" + textBox_farmLocation.Text + "',farm_host = '" + textBox_farmHost.Text + "',farm_pic = @img ";
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ !!");

                //show data to DataGridView
                con.Open();
                String query2 = "SELECT * FROM Farm";
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
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images(.jpg,.png)|*.png;*.jpg";
                dialog.Title = "เลือกรูปภาพของฟาร์ม";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    pictureBox.ImageLocation = imgLocation;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
