using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void lineSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_venAdd_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");

        private void myButton2_Click(object sender, EventArgs e)
        {
            con.Open();

            String query = "INSERT INTO device_list (maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_vendorPhone,maintain_venderAdd,maintain_length,maintain_responder,maintain_date) "
                                       + "VALUES('" + textBox_id.Text + "','" + textBox_name.Text + "','" + comboBox.Text + "','" + textBox_price.Text + "','" + textBox_venName.Text + "','" + maskedTextBox_venNum.Text + "','" + richTextBox1_venAdd.Text + "','" + textBox_lenght.Text + "','" + textBox_resp.Text + "','" + dateTimePicker1.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save To DB Success!!");
        }
    }
}
