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
        SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");

        public Menu_maintenance()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);

            get_data();
            update();

            //add_DG();

            /*void add_DG()
            {
                int n = 0;
                for(int i=1; i<=8; i++)
                {
                    n = DG_Drone.Rows.Add();
                    DG_Drone.Rows[n].Cells[0].Value = "DR001";
                    DG_Drone.Rows[n].Cells[1].Value = "Sky Hunter X8";
                    DG_Drone.Rows[n].Cells[2].Value = "Bangkok";
                    DG_Drone.Rows[n].Cells[3].Value = "Napat Jintanakosol";

                    n = DG_Drone.Rows.Add();
                    DG_Drone.Rows[n].Cells[0].Value = "D003";
                    DG_Drone.Rows[n].Cells[1].Value = "DJI Mavic air";
                }
            }*/
        }

        public void get_data()
        {
            con.Open();
            String query = "SELECT * FROM DRONE";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Drone.DataSource = dt;
            con.Close();
            

        }

        //update data grid view
        public void update()
        {
            // add colum
            DG_Drone.ColumnCount = 2;
            DG_Drone.Columns[0].Name = "รหัสโดรน";
            DG_Drone.Columns[1].Name = "ชื่อโดรน";

           // add button view part
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "รายละเอียดส่วนประกอบ";
            btn1.Name = "but_part";
            btn1.Text = "คลิกเพื่อดูรายละเอียด";
            btn1.UseColumnTextForButtonValue = true;
            DG_Drone.Columns.Add(btn1);

            // add button delete drone
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "ลบ";
            btn2.Name = "but_delete";
            btn2.Text = "ลบ";
            btn2.UseColumnTextForButtonValue = true;
            DG_Drone.Columns.Add(btn2);

            // add button update drone
            DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn();
            btn3.HeaderText = "แก้ไข";
            btn3.Name = "but_delete";
            btn3.Text = "แก้ไข";
            btn3.UseColumnTextForButtonValue = true;
            DG_Drone.Columns.Add(btn3);

            //DG_Drone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                      
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

        private void DG_Drone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {
            
        }
               
        private void BUT_add_drone_Click(object sender, EventArgs e)
        {
            Form_Add_drone form_Add_Drone = new Form_Add_drone();
            form_Add_Drone.ShowDialog();
        }
    }
}
