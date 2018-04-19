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
    public partial class Form_Edit_drone : Form
    {
        public Form_Edit_drone ()
        {
            InitializeComponent();
        }

        public Form_Edit_drone(string id_drone)
        {
            this.id_drone = id_drone;
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        private string id_drone;

        string imgLocation = "";
        SqlCommand cmd;
        
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
            con.Open();

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

        private void Form_Edit_drone_KeyDown(object sender, KeyEventArgs e)
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(*.png)|*.png|.jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imgLocation;
            }
        }
    }
}
