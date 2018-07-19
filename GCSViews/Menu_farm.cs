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
        public string name_farm;
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
           
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                if (!String.IsNullOrEmpty(imgLocation))
                {
                    FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }
                if (textBox_farmName.Text == "")
                {
                    MessageBox.Show("คุณยังไม่กรอกข้อมูลชื่อฟาร์ม !!");
                }
                else if (img == null)
                {
                    String query = @"INSERT INTO Farm (farm_id,farm_name,farm_host
                       ,[farm_address]
                       ,[farm_road]
                       ,[farm_subDistrict]
                       ,[farm_district]
                       ,[farm_province]
                       ,[farm_postal]) " + "VALUES( (select CONCAT('F0', MAX(CONVERT(INT, SUBSTRING(farm_id , 2,10)) + 1)) from Farm) ,'"
                       + textBox_farmName.Text + "','" 
                       + textBox_farmHost.Text + "','"
                       + textBox1.Text + "','" 
                       + textBox2.Text + "','" 
                       + textBox3.Text + "','"
                       + textBox4.Text + "','"
                       + textBox5.Text + "','"
                       + textBox6.Text + "' )";
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    cmd = new SqlCommand(query, con);
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ !!");
                }
                else
                {
                    String query =@"INSERT INTO Farm (farm_id,farm_name,farm_host ,[farm_address]
                       ,[farm_road]
                       ,[farm_subDistrict]
                       ,[farm_district]
                       ,[farm_province]
                       ,[farm_postal] , farm_pic) " + "VALUES( (select CONCAT('F0', MAX(SUBSTRING(farm_id, 2, 5)) + 1) from Farm) ,'"
                       + textBox_farmName.Text + "','"
                       + textBox_farmHost.Text + "','"
                       + textBox1.Text + "','"
                       + textBox2.Text + "','"
                       + textBox3.Text + "','"
                       + textBox4.Text + "','"
                       + textBox5.Text + "','"
                       + textBox6.Text + "'"
                       + ",@img)";
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ !!");
                }

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
                if (MessageBox.Show("คุณต้องการลบฟาร์มนี้ใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    String query = "DELETE FROM Farm where farm_id = '" + DG_Farm.SelectedRows[0].Cells[0].Value.ToString() + "' ";
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
                if (!String.IsNullOrEmpty(imgLocation))
                {
                    FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                }

                if (textBox_farmName.Text == "")
                {
                    MessageBox.Show("คุณยังไม่กรอกข้อมูลชื่อฟาร์ม !!");
                }
                else if (img == null)
                {
                    String query = @"UPDATE Farm SET farm_name ='" + textBox_farmName.Text + "',farm_host = '" + textBox_farmHost.Text
                         + "',farm_address='" + textBox1.Text
                         + "',farm_road='" + textBox2.Text
                          + "',farm_subDistrict='" + textBox3.Text
                           + "',farm_district='" + textBox4.Text
                            + "',farm_province='" + textBox5.Text
                             + "',farm_postal='" + textBox6.Text
                        + "' where farm_id ='" + DG_Farm.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    cmd = new SqlCommand(query, con);
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ !!");
                }
                else
                {
                    String query = "UPDATE Farm SET farm_name ='" + textBox_farmName.Text + "',farm_host = '" + textBox_farmHost.Text 
                        + "',farm_address='" + textBox1.Text
                         + "',farm_road='" + textBox2.Text
                          + "',farm_subDistrict='" + textBox3.Text
                           + "',farm_district='" + textBox4.Text
                            + "',farm_province='" + textBox5.Text
                             + "',farm_postal='" + textBox6.Text
                        + "',farm_pic = @img where farm_id ='" + DG_Farm.SelectedRows[0].Cells[0].Value.ToString() + "'";
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ !!");
                }

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

        public string farmIDText
        {
            get { return id_farm; }
        }

        private void DG_Farm_Click(object sender, EventArgs e)
        {
            try
            {
                //click and show  data to dataGridView
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                try
                {
                    DG_Farm.MultiSelect = false;
                    byte[] img = null;
                    String query = "SELECT * FROM Farm where farm_id='" + DG_Farm.CurrentRow.Cells[0].Value.ToString() + "'";
                   
                    cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        id_farm = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
                        textBox_farmName.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
                        name_farm = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
                        textBox_farmHost.Text = DG_Farm.SelectedRows[0].Cells[2].Value.ToString();
                        textBox1.Text = reader[4].ToString();
                        textBox2.Text = reader[5].ToString();
                        textBox3.Text = reader[6].ToString();
                        textBox4.Text = reader[7].ToString();
                        textBox5.Text = reader[8].ToString();
                        textBox6.Text = reader[9].ToString();

                        if (!Convert.IsDBNull(reader[3]))
                        {
                            img = (byte[])(reader[3]);
                        }
                        //if (reader[3] != null)

                        if (img == null)
                        { pictureBox.Image = null; }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else MessageBox.Show("ไม่มีข้อมูลในฐานข้อมูล");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    if ((con != null) &&(con.State == ConnectionState.Open))
                    { con.Close(); }
                }

            }
            catch (Exception ex)
            {
 
            }
        }

        private void Menu_farm_Load(object sender, EventArgs e)
        {
            //show data to DataGridView
            if (con.State != ConnectionState.Open)
                con.Open();
            String query = "SELECT * FROM Farm";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }
    }
}
