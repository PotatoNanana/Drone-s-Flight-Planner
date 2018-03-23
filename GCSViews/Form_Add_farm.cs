using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Add_farm : Form
    {
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
            SqlConnection sqlcon = new SqlConnection(@"Data Source=napat;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
            string query = "INSERT Farm(farm_id, farm_name, farm_location, farm_host) VALUES ('"+ Farm_id.Text.Trim() + "','" + Farm_name.Text.Trim() + "', '" + Farm_location.Text.Trim() + "', '" + Farm_host.Text.Trim() + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                Menu_farm menu_Farm = new Menu_farm();
                menu_Farm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("มีฟาร์มนี้อยู่แล้ว");
            }
            
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
    }
}
