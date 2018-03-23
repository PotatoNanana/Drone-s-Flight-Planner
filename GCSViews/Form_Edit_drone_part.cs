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

namespace MissionPlanner.GCSViews
{
    public partial class Form_Edit_drone_part : Form
    {
        public Form_Edit_drone_part()
        {
            InitializeComponent();
                        
        }

        public Form_Edit_drone_part(string id_drone)
        {
            this.id_drone = id_drone;
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        //SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        string imgLocation = "";
        SqlCommand cmd;
        private string id_drone;

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_save_Click(object sender, EventArgs e)
        {
            con.Open();

            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);

            comboBox_alarm.SelectedItem.ToString();
            string format = "yyyy-MM-dd";

            String query = "UPDATE DeviceList SET device_id = '" + textBox_partID.Text + "' , device_name = '" + textBox_partName.Text + "' , device_position = '" + textBox_partPosition.Text + "' , device_startDate = '" + dateTimePicker_startDate.Value.ToString(format) + "',device_buyDate = '" + dateTimePicker_reg.Value.ToString(format) + "',device_expDate = '" + dateTimePicker_expDate.Value.ToString(format) + "',vender_name = '" + textBox_venName.Text + "',vender_add = '" + textBox_venAdd.Text + "',vender_phone = '" + textBox_venPhone.Text + "',vender_responder = '" + textBox_respon.Text + "',device_img = @images,device_alarm = '" + comboBox_alarm.SelectedItem.ToString() + "',device_price = '" + textBox_partPrice.Text + "') ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();

            cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Update To DB Success!!");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(*.png)|*.png|.jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
    }
}
