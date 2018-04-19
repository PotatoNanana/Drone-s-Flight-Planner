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
    public partial class Form_Add_farm : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        public Form_Add_farm()
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
            con.Open();
            String query = "INSERT INTO Farm (farm_id,farm_name,farm_location,farm_host) " + "VALUES('" + textBox_farmID.Text + "','" + textBox_farmName.Text + "','" + textBox_farmLocation.Text + "','" + textBox_farmHost.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save To DB Success!!");  

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_Add_farm_KeyDown(object sender, KeyEventArgs e)
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
    }
}
