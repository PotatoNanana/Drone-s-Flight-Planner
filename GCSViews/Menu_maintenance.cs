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
    public partial class Menu_maintenance : MyUserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");

        public Menu_maintenance()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);
              
        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_DronePart_Clicked;

        protected virtual void OnGotoDronePartClicked(EventArgs e)
        {
            Goto_DronePart_Clicked?.Invoke(this, e);
        }

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

        private void panel_Main_farm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {
            
        }
               
        private void BUT_add_drone_Click(object sender, EventArgs e)
        {
            //add drone

            Form_Add_drone form_Add_Drone = new Form_Add_drone();
            form_Add_Drone.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //detail part of drone
            Menu_maintenance_part menu_maintain_part = new Menu_maintenance_part();
            menu_maintain_part.ShowUserControl();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete drone
            if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                String query = "DELETE * FROM Drone where drone_id = '"+textBox_droneID.Text+"' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Record  in DB Success!!");
            }

        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            //search drone
            con.Open();
            String query = "SELECT * FROM Drone where drone_id = '" + textBox_droneID.Text + "'OR drone_name = '"+textBox_droneName.Text+"' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
            
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            //edit drone
            Form_Edit_drone form_edit_drone = new Form_Edit_drone();
            form_edit_drone.ShowDialog();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT Drone_id,Dronr_name FROM Drone";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
        }

        private void DG_Drone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_droneID.Text = DG_Drone.SelectedRows[0].Cells[0].Value.ToString();
            textBox_droneName.Text = DG_Drone.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
