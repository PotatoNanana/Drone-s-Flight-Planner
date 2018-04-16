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
using Community.CsharpSqlite.SQLiteClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_maintenance_part : MyUserControl
    {
        //SqlConnection con = new SqlConnection(@"Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        public Menu_maintenance_part()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);
                        
        }

        public Menu_maintenance_part(string id_drone)
        {
            this.id_drone = id_drone;
            InitializeComponent();

            MyView = new MainSwitcher(this);
        }

        Controls.MainSwitcher MyView;
        private string id_drone;

        public static event EventHandler Goto_Drone_Clicked;
        public static event EventHandler Goto_DronePre_Clicked;

        protected virtual void OnGotoDroneClicked(EventArgs e)
        {
            Goto_Drone_Clicked?.Invoke(this, e);
        }

        protected virtual void OnGotoDronePreClicked(EventArgs e)
        {
            Goto_DronePre_Clicked?.Invoke(this, e);
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
            textBox_partID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
            textBox_partName.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
        }


        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_part_Click(object sender, EventArgs e)
        {
            //pass to add part
            Form_Add_drone_part form_Add_Drone_Part = new Form_Add_drone_part(id_drone);
            form_Add_Drone_Part.ShowDialog();
        }
        
        private void but_backto_pre_Click(object sender, EventArgs e)
        {
            //go back
            OnGotoDroneClicked(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pass to previtive maintain
            Menu_maintenance_pre menu_maintenance_pre = new Menu_maintenance_pre(id_drone);
            menu_maintenance_pre.ShowUserControl();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            //edit
            Form_Edit_drone_part form_Edit_Drone_Part = new Form_Edit_drone_part(id_drone);
            form_Edit_Drone_Part.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //delete
            if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                String query = "DELETE FROM DeviceList where device_id = '" + textBox_partID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE Record From DB Success!!");

            }
        }


        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            con.Close();
            DG_Farm.DataSource = dt;
        }

        private byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        private string FixBase64ForImage(string pic)
        {
           System.Text.StringBuilder sbText = new System.Text.StringBuilder(pic,pic.Length);
            sbText.Replace("\r\n", String.Empty); sbText.Replace(" ", String.Empty); 
            return sbText.ToString(); 
        }

        /*private void button_serch_Click(object sender, EventArgs e)
        {
            //serch record
            con.Open();
            String query = "SELECT device_id,device_name,device_position,device_price,device_buyDate,device_expDate,device_startDate,device_responder,device_pic,device_alarm,vender_name,vender_add,vender_phone FROM DeviceList where device_id = '" + textBox_partID.Text + "' OR device_name = '" + textBox_partName.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
            
        } */
    }
}
