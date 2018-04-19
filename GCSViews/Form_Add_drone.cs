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
using System.IO;
using MissionPlanner.Utilities;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Add_drone : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;
        string imgLocation = "";
        byte[] imgby;
        
        public Form_Add_drone()
        {
            InitializeComponent();
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_add_act_Click(object sender, EventArgs e)
        {
            Form_Add_farm_act form_Add_Farm_Act = new Form_Add_farm_act();
            form_Add_Farm_Act.ShowDialog();
        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Main_farm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_but_farm_Click_1(object sender, EventArgs e)
        {

        }

        private void BUT_save_Click(object sender, EventArgs e)
        {
            try
            {
                // for img 
                byte[] img = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                String query = "INSERT INTO Drone (drone_id,drone_name,drone_pic) " + "VALUES('" + textBox_droneID.Text + "','" + textBox_droneName.Text + "')";

                if (con.State != ConnectionState.Open)
                { con.Open(); }

                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกข้อมูลสำเร็จ!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Menu_maintenance menu_maintain = new Menu_maintenance();
            menu_maintain.ShowUserControl();

            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Add_drone_KeyDown(object sender, KeyEventArgs e)
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

        private void button_serch_Click(object sender, EventArgs e)
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
    }
}





        
