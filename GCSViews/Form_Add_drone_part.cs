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
    public partial class Form_Add_drone_part : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        string imgLocation = "";
        byte[] imgby;
        SqlCommand cmd;
        private string id_drone;

        public Form_Add_drone_part()
        {
            InitializeComponent();
        }

        public Form_Add_drone_part(string id_drone)
        {
            this.id_drone = id_drone;
            InitializeComponent();
        }

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
            /*// 1
           con.Open();
            // for date
            comboBox_alarm.SelectedItem.ToString();
            string format = "yyyy-MM-dd";

            String query = "INSERT INTO DeviceList (device_id,device_name,device_position,device_startDate,device_buyDate,device_expDate,vender_name,vender_add,vender_phone,device_responder,device_pic,device_alarm,device_price,drone_id) "
                                       + "VALUES('" + textBox_partID.Text + "','" + textBox_partName.Text + "','" + textBox_partPosition.Text + "','" + dateTimePicker_startDate.Value.ToString(format) + "','" + dateTimePicker_reg.Value.ToString(format) + "','" + dateTimePicker_ExpDate.Value.ToString(format) + "','" + textBox_VenName.Text + "','" + textBox_venAdd.Text + "','" + textBox_venPhone.Text + "','" + textBox_respond.Text + "',@images,'" + comboBox_alarm.SelectedItem.ToString() + "','" + textBox_price.Text + "','" + id_drone + "')";
            SqlCommand cmd = new SqlCommand(query, con);
           
            //cmd.Parameters.Add("@Images", SqlDbType.Image, imgby.Length);
            //cmd.Parameters["@Images"].Value = imgby;
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Save To DB Success!!"); */
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
                cmd = new SqlCommand(query,con);
                cmd.Parameters.Add(new SqlParameter("@img",img));
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save To DB Success!!"); 

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void button1_Click(object sender, EventArgs e)
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

         public byte[] imageToByteArray(System.Drawing.Image imageIn)
          {
             MemoryStream ms = new MemoryStream();
            imageIn.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return  ms.ToArray();
          }

            //Byte array to photo
            public Image byteArrayToImage(byte[] byteArrayIn)
            {
             MemoryStream ms = new MemoryStream(byteArrayIn);
             Image returnImage = Image.FromStream(ms);
             return returnImage;
            }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
