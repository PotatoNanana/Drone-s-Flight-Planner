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
using Microsoft.CSharp;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Add_act : Form
    {
        public Form_Add_act()
        {
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();

        private void But_save_Click(object sender, EventArgs e)
        {
            con.Open();

            string format = "yyyy-MM-dd";

            String query = "INSERT INTO FlightSchedule (action_no,farm_id,drone_id,action_name,action_capacity,action_cost,action_datetime) " + "VALUES('" + textBox_actID.Text + "','" + textBox_farmID.Text + "','" + textBox_droneID.Text + "','" + textBox_actName.Text + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "','" + dateTimePicker.Value.ToString(format) + "')";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Save To DB Success!!");

            /// 
            /// added export worksheet to excel file
            /// save file with date and time using the ISO 8601 format
            /// 
            string fileTest = "C:\\Temp\\DroneFlightPlanner\\add_activity_"+ DateTime.Now.ToString("yyyyMMddTHHmmss") + ".xlsx";
            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);

            if (File.Exists(fileTest))
            {
                File.Delete(fileTest);
            }
            
            oSheet.Cells[1, 1] = "วันที่ทำรายการ";
            oSheet.Cells[1, 2] = "รหัสฟาร์ม";
            oSheet.Cells[1, 3] = "รหัสโดรน";
            oSheet.Cells[1, 4] = "รหัสกิจกรรม";
            oSheet.Cells[1, 5] = "ชื่อกิจกรรม";
            oSheet.Cells[1, 6] = "ปริมาณสาร";
            oSheet.Cells[1, 7] = "วันที่กิจกรรม";

            oSheet.Cells[2, 1] = DateTime.Now.ToString("g", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
            oSheet.Cells[2, 2] = textBox_farmID.Text;
            oSheet.Cells[2, 3] = textBox_droneID.Text;
            oSheet.Cells[2, 4] = textBox_actID.Text;
            oSheet.Cells[2, 5] = textBox_actName.Text;
            oSheet.Cells[2, 6] = textBox_cap.Text;
            oSheet.Cells[2, 7] = dateTimePicker.Value.ToString("d", System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR")); 

            oSheet.Columns.AutoFit();
            oBook.SaveAs(fileTest);
            oBook.Close();
            oApp.Quit();

            this.Close();
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Add_act_KeyDown(object sender, KeyEventArgs e)
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
        
    }
}
