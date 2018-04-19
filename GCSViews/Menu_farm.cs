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

        private void label1_Click(object sender, EventArgs e)
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
            textBox_farmID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
            id_farm = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
            textBox_farmName.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_farm_Click(object sender, EventArgs e)
        {
            //add farm
            Form_Add_farm form_Add_Farm = new Form_Add_farm();
            form_Add_Farm.ShowDialog();
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
            // delete farm
            if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                String query = "DELETE FROM Farm where farm_id = '" + textBox_farmID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE Record From DB Success!!");
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // update farm
            Form_Edit_farm form_Edit_Farm = new Form_Edit_farm(id_farm);
            form_Edit_Farm.ShowDialog();
        }
        
    }
}
