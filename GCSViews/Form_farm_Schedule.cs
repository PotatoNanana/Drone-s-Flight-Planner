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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace MissionPlanner.GCSViews
{
    public partial class Form_farm_Schedule : Form
    {
        public Form_farm_Schedule()
        {
            InitializeComponent();            
        }

        public Form_farm_Schedule(string id_farm)
        {
            this.id_farm = id_farm;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        private string id_farm;

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DG_Farm_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            textBox_actID.Text = DG_Farm.SelectedRows[0].Cells[2].Value.ToString();
            textBox_actName.Text = DG_Farm.SelectedRows[0].Cells[3].Value.ToString();
            textBox_droneID.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
            textBox_cap.Text = DG_Farm.SelectedRows[0].Cells[4].Value.ToString();
            textBox_cost.Text = DG_Farm.SelectedRows[0].Cells[5].Value.ToString();
            
            //added by Napat 10/06/2018
            textBox_startTime.Text = DG_Farm.SelectedRows[0].Cells[6].Value.ToString();
            textBox_finishTime.Text = DG_Farm.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void But_add_act_Click(object sender, EventArgs e)
        {          
            if (textBox_droneID.Text != "")
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                String query = "SELECT * from drone where drone_id ='"+ textBox_droneID.Text +"'";
                SqlCommand cmd = new SqlCommand(query, con);
                int exists = cmd.ExecuteNonQuery();
                if (exists <= 0)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลรหัสโดรนที่มีอยู่ในระบบ !!");
                }
                con.Close();
            }

            if (id_farm == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสฟาร์มให้ครบถ้วน !!");
            }

            else if (textBox_droneID.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสโดรน !!");
            }

            else if (textBox_actID.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสกิจกรรม !!");
            }
                
            else if (textBox_actName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลชื่อกิจกรรม !!");
            }
                
            else
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                string format = "yyyy-MM-dd";
                String query = "INSERT INTO FlightSchedule (action_no,farm_id,drone_id,action_name,action_capacity,action_cost,action_datetime,action_startTime,action_finishTime) " + "VALUES('" + textBox_actID.Text + "','" + id_farm + "','" + textBox_droneID.Text + "','" + textBox_actName.Text + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "','" + monthCalendar1.SelectionEnd.ToShortDateString() + "','" + textBox_startTime.Text + "','" + textBox_finishTime.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");

                //show data to DataGridView
                con.Open();
                String query2 = "SELECT * FROM Farm";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                SDA2.Fill(dt);
                DG_Farm.DataSource = dt;
                con.Close();
                
                /// got value from menu_farm
                Menu_farm menu_Farm = new Menu_farm();

                ///added filepath
                string filepath = "C:\\Temp\\DroneFlightPlanner";
                if (Directory.Exists(filepath)) { }
                else
                {
                    Directory.CreateDirectory(filepath);
                }
                /// added export worksheet to excel file
                string fileTest = "C:\\Temp\\DroneFlightPlanner\\add_activity_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xlsx";
                MessageBox.Show("ได้ทำการเพิ่มข้อมูลไฟล์การสร้างกิจกรรมที่ C:\\Temp\\DroneFlightPlanner\\add_activity_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xlsx แล้ว");
                Excel.Application oApp;
                Excel.Worksheet oSheet;
                Excel.Workbook oBook;

                oApp = new Excel.Application();
                oBook = oApp.Workbooks.Add();
                oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
                oSheet.Cells[1, 1] = "รหัสฟาร์ม";
                oSheet.Cells[1, 2] = "รหัสโดรน";
                oSheet.Cells[1, 3] = "รหัสกิจกรรม";
                oSheet.Cells[1, 4] = "ชื่อกิจกรรม";
                oSheet.Cells[1, 5] = "ปริมาณสาร";
                oSheet.Cells[1, 6] = "วันที่";
                oSheet.Cells[1, 7] = "เวลาเริ่ม";
                oSheet.Cells[1, 8] = "เวลาเสร็จ";
                    
                oSheet.Cells[2, 1] = menu_Farm.farmIDText;
                oSheet.Cells[2, 2] = textBox_droneID.Text;
                oSheet.Cells[2, 3] = textBox_actID.Text;
                oSheet.Cells[2, 4] = textBox_actName.Text;
                oSheet.Cells[2, 5] = textBox_cap.Text;
                oSheet.Cells[2, 6] = monthCalendar1.Text;
                oSheet.Cells[2, 7] = textBox_startTime.Text;
                oSheet.Cells[2, 8] = textBox_finishTime.Text;

                oBook.SaveAs(fileTest);
                oBook.Close();
                oApp.Quit();
            }
        }
        
        private void button_delete_Click(object sender, EventArgs e)
        {            
            try
            {
                if (MessageBox.Show("คุณต้อการลบกิจกรรมนี้ใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    String query = "DELETE FROM FlightSchedule where action_no = '" + textBox_actID.Text + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ทำการลบข้อมูลเรียบร้อยแล้ว !!");

                    //show data to DataGridView
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    String query2 = "SELECT * FROM Farm";
                    SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    SDA2.Fill(dt);
                    DG_Farm.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textBox_droneID.Text != "")
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                String query = "SELECT * from drone where drone_id ='" + textBox_droneID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int exists = cmd.ExecuteNonQuery();
                if (exists <= 0)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลรหัสโดรนที่มีอยู่ในระบบ !!");
                }
                con.Close();
            }

            if (id_farm == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสฟาร์มให้ครบถ้วน !!");
            }

            else if (textBox_droneID.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสโดรน !!");
            }

            else if (textBox_actID.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสกิจกรรม !!");
            }

            else if (textBox_actName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลชื่อกิจกรรม !!");
            }

            else
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                string format = "yyyy-MM-dd";
                String query = "UPDATE FlightSchedule SET farm_id = '" + id_farm + "',drone_id = '" + textBox_droneID.Text + "',action_no = '" + textBox_actID.Text + "',action_datetime = '" + monthCalendar1.SelectionEnd.ToShortDateString() + "',action_name = '" + textBox_actName.Text + "',action_capacity = '" + textBox_cap.Text + "',action_cost = '" + textBox_cost.Text + "',action_startTime = '" + textBox_startTime.Text + "',action_finishTime= '" + textBox_finishTime.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ทำการแก้ไขข้อมูลเรียบร้อยแล้ว !!");

                //show data to DataGridView
                con.Open();
                String query2 = "SELECT * FROM Farm";
                SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                SDA2.Fill(dt);
                DG_Farm.DataSource = dt;
                con.Close();

                /// got value from menu_farm
                Menu_farm menu_Farm = new Menu_farm();

                ///added filepath
                string filepath = "C:\\Temp\\DroneFlightPlanner";
                if (Directory.Exists(filepath)) { }
                else
                {
                    Directory.CreateDirectory(filepath);
                }
                /// added export worksheet to excel file
                string fileTest = "C:\\Temp\\DroneFlightPlanner\\update_activity_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xlsx";
                MessageBox.Show("ได้ทำการเพิ่มข้อมูลไฟล์การสร้างกิจกรรมที่ C:\\Temp\\DroneFlightPlanner\\add_activity_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xlsx แล้ว");
                Excel.Application oApp;
                Excel.Worksheet oSheet;
                Excel.Workbook oBook;

                oApp = new Excel.Application();
                oBook = oApp.Workbooks.Add();
                oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
                oSheet.Cells[1, 1] = "รหัสฟาร์ม";
                oSheet.Cells[1, 2] = "รหัสโดรน";
                oSheet.Cells[1, 3] = "รหัสกิจกรรม";
                oSheet.Cells[1, 4] = "ชื่อกิจกรรม";
                oSheet.Cells[1, 5] = "ปริมาณสาร";
                oSheet.Cells[1, 6] = "วันที่";
                oSheet.Cells[1, 7] = "เวลาเริ่ม";
                oSheet.Cells[1, 8] = "เวลาเสร็จ";

                oSheet.Cells[2, 1] = menu_Farm.farmIDText;
                oSheet.Cells[2, 2] = textBox_droneID.Text;
                oSheet.Cells[2, 3] = textBox_actID.Text;
                oSheet.Cells[2, 4] = textBox_actName.Text;
                oSheet.Cells[2, 5] = textBox_cap.Text;
                oSheet.Cells[2, 6] = monthCalendar1.Text;
                oSheet.Cells[2, 7] = textBox_startTime.Text;
                oSheet.Cells[2, 8] = textBox_finishTime.Text;

                oBook.SaveAs(fileTest);
                oBook.Close();
                oApp.Quit();
            }
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            // serch record
        }

        private void Form_farm_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet5.FlightSchedule' table. You can move, or remove it, as needed.
            this.flightScheduleTableAdapter1.Fill(this.droneFlightPlannerDataSet5.FlightSchedule);
            // TODO: This line of code loads data into the 'flightSchedule2.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter.Fill(this.flightSchedule2.FlightSchedule);
            // TODO: This line of code loads data into the 'flightSchedule1.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter1.Fill(this.flightSchedule1.FlightSchedule);
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet3.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter.Fill(this.droneFlightPlannerDataSet3.FlightSchedule);
            // TODO: This line of code loads data into the 'schedule_act.schedule_action' table. You can move, or remove it, as needed.
            //this.schedule_actionTableAdapter.Fill(this.schedule_act.schedule_action);

        }

        private void textBox_actName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_actID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_farm_Schedule_KeyDown(object sender, KeyEventArgs e)
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

        private void panelFarm_schedule_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            if (con.State != ConnectionState.Open)
            { con.Open(); }

            String query = "SELECT * FROM FlightSchedule WHERE farm_id = '" + id_farm + "' AND action_finish = 'n' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            System.Data.DataTable dt = new System.Data.DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;

            con.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
        }
    }
}
