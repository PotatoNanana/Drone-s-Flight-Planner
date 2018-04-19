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
        //SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;



        public Menu_maintenance_pre()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);
            
        }

        public Menu_maintenance_pre(string id_drone)
        {
            this.id_drone = id_drone;
            InitializeComponent();
            MyView = new MainSwitcher(this);
        }

        Controls.MainSwitcher MyView;
        private string id_drone;

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

        private void panelMaintenance_pre_Paint(object sender, PaintEventArgs e)
        {
            //show data to dataGridView
            con.Open();
            String query = "SELECT maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_venderPhone,maintain_venderAdd,maintain_lenght,maintain_responder,maintain_date FROM Maintainance";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_mainID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
            textBox_mainAct.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_pre_Click(object sender, EventArgs e)
        {
            //add previtive 
            Form_Add_drone_pre form_Add_Drone_Pre = new Form_Add_drone_pre(id_drone);
            form_Add_Drone_Pre.ShowDialog();
        }
        
        private void but_backto_pre_Click(object sender, EventArgs e)
        {
            OnGotoDroneClicked(e); 
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            //pass to update
            Form_Edit_drone_pre form_Edit_Drone_Pre = new Form_Edit_drone_pre(id_drone);
            form_Edit_Drone_Pre.ShowDialog();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to dataGridView
            con.Open();
            String query = "SELECT maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_venderPhone,maintain_venderAdd,maintain_lenght,maintain_responder,maintain_date FROM Maintainance";
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
                con.Open();
                String query = "DELETE * FROM Maintainance where maintain_id = '" + textBox_mainID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE Record From DB Success!!");
            }
        }

       /* private void button_serch_Click(object sender, EventArgs e)
        {
            // serch record
            con.Open();
            String query = "maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_vendorPhone,maintain_venderAdd,maintain_length,maintain_responder,maintain_date FROM Maintainance where device_id = '" + textBox_mainID.Text + "'OR device_name = '" + textBox_mainAct.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        } */
    }
}
