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
using System.Data.SqlClient;


namespace MissionPlanner.GCSViews
{
    public partial class Menu_main2 : MyUserControl
    {
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();

        public Menu_main2()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);

        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_farmProfile_Clicked;
        public static event EventHandler Goto_farmMaintenance_Clicked;

        protected virtual void OnGotoFarmProfileClicked(EventArgs e)
        {
            Goto_farmProfile_Clicked?.Invoke(this, e);
        }

        protected virtual void OnGotoFarmMaintenanceClicked(EventArgs e)
        {
            Goto_farmMaintenance_Clicked?.Invoke(this, e);
        }

        protected override void OnLoad(EventArgs e)
        {
            //MyView.AddScreen(new MainSwitcher.Screen("Menu_farm", typeof(GCSViews.Menu_farm), true));
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Goto_farmProfile_Click(object sender, EventArgs e)
        {
            OnGotoFarmProfileClicked(e);

        }

        private void Goto_farmMaintenance_Click(object sender, EventArgs e)
        {
            OnGotoFarmMaintenanceClicked(e);

        }

        public void DG_farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void myDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lineSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void but_schedule_Click(object sender, EventArgs e)
        {
            Form_main_Schedule form_Schedule = new Form_main_Schedule();
            form_Schedule.ShowDialog();
        }

        private void button_showDGFarm_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT * FROM Farm";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_farm.DataSource = dt;
            con.Close();
        }

        private void button_showDGMaintain_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT * FROM Maintainance";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_maintenance.DataSource = dt;
            con.Close();
        }

        private void button_showDGSchedule_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT * FROM FlightSchedule";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_schedule.DataSource = dt;
            con.Close();

        }
    }
}
