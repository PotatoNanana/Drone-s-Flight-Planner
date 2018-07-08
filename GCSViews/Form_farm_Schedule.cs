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
            this.name_farm = name_farm;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        private string id_farm;
        private string name_farm;

        void AddToCombo()
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            try
            {
                //drone
                String queryDrone = "SELECT * from drone ";
                SqlDataAdapter SDA2 = new SqlDataAdapter(queryDrone, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                SDA2.Fill(dt);
                cboDrone.DataSource = dt;
                cboDrone.DisplayMember = "drone_name";
                cboDrone.ValueMember = "drone_id";

                //Activity
                String queryActivity = "SELECT * from Activity_Farm ";
                SqlDataAdapter sdActivity = new SqlDataAdapter(queryActivity, con);
                System.Data.DataTable dtActivity = new System.Data.DataTable();
                sdActivity.Fill(dtActivity);
                cboActivity.DataSource = dtActivity;
                cboActivity.DisplayMember = "act_name";
                cboActivity.ValueMember = "act_no";

                //material
                String queryMaterial = "SELECT * from Material_Act ";
                SqlDataAdapter SDAMaterial = new SqlDataAdapter(queryMaterial, con);
                System.Data.DataTable dtMaterial = new System.Data.DataTable();
                SDAMaterial.Fill(dtMaterial);
                cboMaterial.DataSource = dtMaterial;
                cboMaterial.DisplayMember = "material_name";
                cboMaterial.ValueMember = "material_no";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(con !=null || con.State == ConnectionState.Open)
                    con.Close();
            }

           
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DG_Farm_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void But_add_act_Click(object sender, EventArgs e)
        {          
            if (cboDrone.SelectedValue != "")
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                String query = "SELECT * from drone where drone_id ='"+ cboDrone.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Close();
            }

            if (id_farm == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสฟาร์มให้ครบถ้วน !!");
            }
                
            else
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                
                string query = @" INSERT INTO [dbo].[FlightSchedule] ([action_no],[farm_id],[drone_id],[action_capacity],[action_cost],[action_datetime],[action_startTime],[action_finishTime],[act_no], [action_name],[material_no] ,[material_name]) "+
                    "VALUES(" + " (select CONCAT('AC', COUNT( SUBSTRING(action_no,3,5))+1) from FlightSchedule) " + ",'" + id_farm + "','" + cboDrone.SelectedValue + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "','" + monthCalendar1.SelectionEnd.ToShortDateString() + "','" + textBox_startTime.Text + "','" + textBox_finishTime.Text + "','"+ cboActivity.SelectedValue + "','" + cboActivity.Text + "','" + cboMaterial.SelectedValue + "','" + cboMaterial.Text + "')";
                
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                this.loadListData();
                MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");

                ////show data to DataGridView
                //con.Open();
                //String query2 = "SELECT * FROM Farm";
                //SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                //System.Data.DataTable dt = new System.Data.DataTable();
                //SDA2.Fill(dt);
                //DG_Farm.DataSource = dt;
                //con.Close();
                
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
                oSheet.Cells[1, 3] = "ชือโดรน";
                oSheet.Cells[1, 4] = "รหัสกิจกรรม";
                oSheet.Cells[1, 5] = "ชื่อกิจกรรม";
                oSheet.Cells[1, 6] = "วัตถุดิบ";
                oSheet.Cells[1, 7] = "ปริมาณสาร";
                oSheet.Cells[1, 8] = "ค่าใช้จ่าย";
                oSheet.Cells[1, 9] = "วันที่";
                oSheet.Cells[1, 10] = "เวลาเริ่ม";
                oSheet.Cells[1, 11] = "เวลาเสร็จ";

                oSheet.Cells[2, 1] = id_farm;
                oSheet.Cells[2, 2] = cboDrone.SelectedValue;
                oSheet.Cells[2, 3] = cboDrone.Text;
                oSheet.Cells[2, 4] = cboActivity.SelectedValue;
                oSheet.Cells[2, 5] = cboActivity.Text;
                oSheet.Cells[2, 6] = cboMaterial.Text;
                oSheet.Cells[2, 7] = textBox_cap.Text;
                oSheet.Cells[2, 8] = textBox_cost.Text;
                oSheet.Cells[2, 9] = monthCalendar1.SelectionEnd.ToShortDateString();
                oSheet.Cells[2, 10] = textBox_startTime.Text;
                oSheet.Cells[2, 11] = textBox_finishTime.Text;

                oBook.SaveAs(fileTest);
                oBook.Close();
                oApp.Quit();
            }
        }
        
        private void button_delete_Click(object sender, EventArgs e)
        {            
            try
            {
                if (MessageBox.Show("คุณต้องการลบกิจกรรมนี้ใช่หรือไม่ ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (con.State != ConnectionState.Open)
                    { con.Open(); }
                    String query = "DELETE FROM FlightSchedule where action_no = '" + cboActivity.SelectedValue + "' ";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    loadListData();
                    MessageBox.Show("ทำการลบข้อมูลเรียบร้อยแล้ว !!");

                    //show data to DataGridView
                    //if (con.State != ConnectionState.Open)
                    //{ con.Open(); }
                    //String query2 = "SELECT * FROM Farm";
                    //SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
                    //System.Data.DataTable dt = new System.Data.DataTable();
                    //SDA2.Fill(dt);
                    //DG_Farm.DataSource = dt;
                    //con.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (cboDrone.SelectedValue != "")
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                String query = "SELECT * from drone where drone_id ='" + cboDrone.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Close();
            }

            if (id_farm == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลรหัสฟาร์มให้ครบถ้วน !!");
            }
            
            else
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                string query = @" UPDATE FlightSchedule SET   "
                  + "   [farm_id] = '" + id_farm + "'"
                  + " ,[drone_id] = '" + cboDrone.SelectedValue + "'"
                  + " ,[action_name] =  '" + cboActivity.Text + "'"
                  + " ,[material_name] =  '" + cboMaterial.Text + "'"
                  + " ,[action_capacity] =  '" + textBox_cap.Text + "'"
                  + " ,[action_cost] =  '" + textBox_cost.Text + "'"
                  + " ,[action_datetime] =  '" + monthCalendar1.SelectionEnd.ToShortDateString() + "'"
                  + " ,[action_startTime] = '" + textBox_startTime.Text + "'"
                  + " ,[action_finishTime] =  '" + textBox_finishTime.Text + "'"
                  + " ,[act_no] =  '" + cboActivity.SelectedValue + "'"
                  + " ,[material_no] = '" + cboMaterial.SelectedValue + "' "
                  + " WHERE ACTION_NO = '"+ DG_Farm.SelectedRows[0].Cells["action_no"].Value.ToString() +"' ";

              //  +" ,[action_finish] =  '" + cboDrone.SelectedValue + "'"


                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();


                loadListData();
                MessageBox.Show("ทำการแก้ไขข้อมูลเรียบร้อยแล้ว !!");
                
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
                oSheet.Cells[1, 3] = "ชือโดรน";
                oSheet.Cells[1, 4] = "รหัสกิจกรรม";
                oSheet.Cells[1, 5] = "ชื่อกิจกรรม";
                oSheet.Cells[1, 6] = "วัตถุดิบ";
                oSheet.Cells[1, 7] = "ปริมาณสาร";
                oSheet.Cells[1, 8] = "ค่าใช้จ่าย";
                oSheet.Cells[1, 9] = "วันที่";
                oSheet.Cells[1, 10] = "เวลาเริ่ม";
                oSheet.Cells[1, 11] = "เวลาเสร็จ";

                oSheet.Cells[2, 1] = id_farm;
                oSheet.Cells[2, 2] = cboDrone.SelectedValue;
                oSheet.Cells[2, 3] = cboDrone.Text;
                oSheet.Cells[2, 4] = cboActivity.SelectedValue;
                oSheet.Cells[2, 5] = cboActivity.Text;
                oSheet.Cells[2, 6] = cboMaterial.Text;
                oSheet.Cells[2, 7] = textBox_cap.Text;
                oSheet.Cells[2, 8] = textBox_cost.Text;
                oSheet.Cells[2, 9] = monthCalendar1.SelectionEnd.ToShortDateString();
                oSheet.Cells[2, 10] = textBox_startTime.Text;
                oSheet.Cells[2, 11] = textBox_finishTime.Text;

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

            AddToCombo();
            loadListData();

        }
        void loadListData()
        {
            //show data to DataGridView
            if (con.State != ConnectionState.Open)
            { con.Open(); }

            //String query = "SELECT * FROM FlightSchedule WHERE farm_id = '" + id_farm + "' AND action_finish = 'n' ";
            String query = @"SELECT        Material_Act.material_name, Activity_Farm.act_name, FlightSchedule.action_datetime, Farm.farm_name, FlightSchedule.action_no, FlightSchedule.action_finish, FlightSchedule.action_cost, FlightSchedule.action_capacity, FlightSchedule.action_startTime, 
                FlightSchedule.action_finishTime, FlightSchedule.farm_id, Drone.drone_name, FlightSchedule.drone_id,
				FlightSchedule.act_no, FlightSchedule.material_no
                FROM FlightSchedule INNER JOIN
                Activity_Farm ON FlightSchedule.act_no = Activity_Farm.act_no INNER JOIN
                Material_Act ON FlightSchedule.material_no = Material_Act.material_no INNER JOIN
                Farm ON FlightSchedule.farm_id = Farm.farm_id INNER JOIN
                Drone ON FlightSchedule.drone_id = Drone.drone_id
                where FlightSchedule.farm_id = '" + id_farm + "'  AND action_finish = 'n' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            System.Data.DataTable dt = new System.Data.DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;

            con.Close();
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
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DG_Farm_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DG_Farm_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_cap.Text = DG_Farm.SelectedRows[0].Cells[3].Value.ToString();
                textBox_cost.Text = DG_Farm.SelectedRows[0].Cells[4].Value.ToString();

                //added by Napat 10/06/2018
                textBox_startTime.Text = DG_Farm.SelectedRows[0].Cells["action_startTime"].Value.ToString();
                textBox_finishTime.Text = DG_Farm.SelectedRows[0].Cells["action_finishTime"].Value.ToString();

                cboDrone.SelectedValue = DG_Farm.SelectedRows[0].Cells["drone_id"].Value.ToString();
                cboActivity.SelectedValue = DG_Farm.SelectedRows[0].Cells["act_no"].Value.ToString();
                cboMaterial.SelectedValue = DG_Farm.SelectedRows[0].Cells["material_no"].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            string query = @"INSERT INTO [dbo].[Activity_Farm]
           ([act_no]
           ,[act_name]) VALUES( (select CONCAT('AC0', MAX( SUBSTRING(act_no,4,6))+1) from Activity_Farm) ,'" + cboActivity.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.loadListData();
            AddToCombo();
            MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            string query = @"INSERT INTO [dbo].[Material_Act]
           ([material_no]
           ,[material_name]) VALUES(" + " (select CONCAT('M0', MAX( SUBSTRING(material_no,3,5))+1) from Material_Act) ,'" + cboMaterial.Text + "')";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.loadListData();
            AddToCombo();
            MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            string query = "DELETE FROM [dbo].[Activity_Farm] WHERE act_no = '"+  cboActivity.SelectedValue.ToString() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.loadListData();
            AddToCombo();
            MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            { con.Open(); }
            string query = "DELETE FROM [dbo].[Material_Act] WHERE material_no = '" + cboMaterial.SelectedValue.ToString() + "'";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.loadListData();
            AddToCombo();
            MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");
        }
    }
}
