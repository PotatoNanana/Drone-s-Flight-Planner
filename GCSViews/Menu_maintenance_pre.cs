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
using System.Data.Sql;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_maintenance_pre : MyUserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlCommand cmd;


        public Menu_maintenance_pre()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);
            
        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_Drone_Clicked;

        protected virtual void OnGotoDroneClicked(EventArgs e)
        {
            Goto_Drone_Clicked?.Invoke(this, e);
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

        private void label1_Click(object sender, EventArgs e)
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

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_Farm.Columns[e.ColumnIndex].Name == "Delete")
            {
               
            }

            

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_pre_Click(object sender, EventArgs e)
        {
            //add previtive 
            Form_Add_drone_pre form_Add_Drone_Pre = new Form_Add_drone_pre();
            form_Add_Drone_Pre.ShowDialog();
        }
        
        private void but_backto_pre_Click(object sender, EventArgs e)
        {
            OnGotoDroneClicked(e);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            //update
            Form_Edit_drone_pre form_Edit_Drone_Pre = new Form_Edit_drone_pre();
            form_Edit_Drone_Pre.ShowDialog();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to dataGridView
            con.Open();
            String query = "SELECT maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_vendorPhone,maintain_venderAdd,maintain_length,maintain_responder,maintain_date FROM Maintainance";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // delete
            if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DG_Farm.RemoveCurrent();
            }
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            // serch record
        }
    }
}
