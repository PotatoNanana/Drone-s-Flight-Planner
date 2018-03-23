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

namespace MissionPlanner.GCSViews
{
    public partial class Form_Edit_drone_pre : Form
    {
        public Form_Edit_drone_pre()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlCommand cmd;

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
            //update
            con.Open();

            string format = "yyyy-MM-dd";

            String query = "INSERT INTO Maintainance SET maintain_id = '"+textBox_mainID.Text+"', maintain_activity = '" + textBox_mainAct.Text + "', maintain_price = '" + textBox_mainPrice.Text + "', maintain_venderName = '" + textBox_venName.Text + "', maintain_vendorPhone = '" + textBox_venPhone.Text + "', maintain_venderAdd = '" + textBox_venAdd.Text + "', maintain_length = '" + textBox_time.Text + "', maintain_responder = '" + textBox_responder.Text + "', maintain_date = '" + dateTimePicker.Value.ToString(format) + "') ";
                                              
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update To DB Success!!");

            this.Close();
        }
    }
}
