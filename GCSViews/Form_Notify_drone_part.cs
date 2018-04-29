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
    public partial class Form_Notify_drone_part : Form
    {
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        private string droneId;

        public Form_Notify_drone_part()
        {
            InitializeComponent();
        }

        public Form_Notify_drone_part(string droneId)
        {
            this.droneId = droneId;
            InitializeComponent();
        }

        private void Form_Notify_drone_part_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'partDroneNotify.DeviceList' table. You can move, or remove it, as needed.
            this.deviceListTableAdapter.Fill(this.partDroneNotify.DeviceList);

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Notify_drone_part_KeyDown(object sender, KeyEventArgs e)
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

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {
            //calcurate date remind
            con.Open();
            DateTime nowDay = DateTime.Now;
            String queryDate1 = "UPDATE DeviceList SET device_remind = 'y' WHERE DATEDIFF(@nowDate, device_remindDate) <= 1 AND device_alarm = 'ทุกวัน' AND drone_id = '" + droneId + "' ";
                        
            String queryDate7 = "UPDATE DeviceList SET device_remind = 'y' WHERE DATEDIFF(@nowDate, device_remindDate) <= 7 AND device_alarm = 'ทุกอาทิตย์' AND drone_id = '" + droneId + "' ";
            
            String queryDate30 = "UPDATE DeviceList SET device_remind = 'y' WHERE DATEDIFF(@nowDate, device_remindDate) <= 30 AND device_alarm = 'ทุกเดือน' AND drone_id = '" + droneId + "' ";

            String queryDate365 = "UPDATE DeviceList SET device_remind = 'y' WHERE DATEDIFF(@nowDate, device_remindDate) <= 365 AND device_alarm = 'ทุก1ปี' AND drone_id = '" + droneId + "' ";

            cmd = new SqlCommand(queryDate1, con);
            cmd = new SqlCommand(queryDate7, con);
            cmd = new SqlCommand(queryDate30, con);
            cmd = new SqlCommand(queryDate365, con);
            cmd.Parameters.Add(new SqlParameter("@nowDate", nowDay));
            int x = cmd.ExecuteNonQuery();

            con.Close();

            //show data to DataGridView
            con.Open();
            
            String queryShow = "SELECT device_id,device_name,device_position,device_alarm,device_startDate,device_remindDate FROM DeviceList WHERE drone_id = '" + droneId + "' AND device_remind = 'y' ";
            SqlDataAdapter SDAShow = new SqlDataAdapter(queryShow, con);
            DataTable dt = new DataTable();         
            SDAShow.Fill(dt);
            DG_Noti.DataSource = dt;

            //chang back to not noti
            String queryFinal = "UPDATE DeviceList SET device_remind = 'n' WHERE device_remind = 'y' ";
            SqlDataAdapter SDAFinal = new SqlDataAdapter(queryFinal, con);

            con.Close();
        }
    }
}
