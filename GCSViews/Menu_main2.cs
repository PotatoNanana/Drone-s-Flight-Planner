using System;
using System.Data;
using System.Windows.Forms;
using MissionPlanner.Controls;
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
            CheckNoti();
        }
        
        private void Goto_farmProfile_Click(object sender, EventArgs e)
        {
            OnGotoFarmProfileClicked(e);
        }

        private void Goto_farmMaintenance_Click(object sender, EventArgs e)
        {
            OnGotoFarmMaintenanceClicked(e);
        }
        
        private void but_schedule_Click(object sender, EventArgs e)
        {
            Form_main_Schedule form_Schedule = new Form_main_Schedule();
            form_Schedule.ShowDialog();
        }

        private void panelFarm_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView 
            con.Open();
            String query = "SELECT Farm.farm_id,farm_name,farm_host,farm_pic,farm_address,farm_road,farm_subDistrict,farm_district,farm_province,farm_postal FROM Farm " +
                "inner join farmRole on Farm.farm_id = farmRole.farm_id and farmRole.username = '"+ Validation.validateUsername + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_farm.DataSource = dt;
            con.Close();
        }

        private void panelFlightSchedule_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView 
            con.Open();
            String query = "SELECT action_no,farmRole.farm_id,drone_id,action_name,material_name,action_capacity,action_cost,action_datetime,action_finish,action_startTime,action_finishTime,act_no,material_no FROM FlightSchedule " +
                "inner join farmRole on FlightSchedule.farm_id = farmRole.farm_id and farmRole.username = '"+ Validation.validateUsername + "' and FlightSchedule.action_finish = 'n' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_schedule.DataSource = dt;
            DG_schedule.Columns["action_datetime"].DefaultCellStyle.Format = "yyyy-MM-dd";
            con.Close();
        }

        private void panelMaintenance_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            con.Open();
            String query = "SELECT * FROM Maintainance ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_maintenance.DataSource = dt;
            con.Close();
        }
        void CheckNoti()
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            try
            {
                String queryShow = @" SELECT *  FROM [DeviceList] a
                  where  
                  (
                  (
                  (
                  (a.device_remindDate = DATEADD(day,ISNULL( a.device_alarm,0),CONVERT (date, CURRENT_TIMESTAMP))
                  and
                   a.device_remindDate = DATEADD(day,0,CONVERT (date, CURRENT_TIMESTAMP))) 
                   )
                   or 
                   a.device_remindDate <= DATEADD(day,0,CONVERT (date, CURRENT_TIMESTAMP)))
                   )
                   and
                   (
                   a.device_expDate >= DATEADD(day,0,CONVERT (date, CURRENT_TIMESTAMP))
                   and
                   a.device_startDate <= DATEADD(day,0,CONVERT (date, CURRENT_TIMESTAMP))
                   ) ";
                SqlDataAdapter SDAShow = new SqlDataAdapter(queryShow, con);
                DataTable dt = new DataTable();
                SDAShow.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    //foreach (var item in dt.Rows)
                    //{
                    //    item[""];
                    //}

                    //open dialog
                    Form_Notify_drone_part f = new Form_Notify_drone_part();
                    f.Show();
                }
                //day,week,month,year


            }
            catch (Exception err)
            {

            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                { con.Close(); }
            }

        }
        
    }
}
