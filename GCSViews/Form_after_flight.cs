using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class Form_after_flight : Form
    {
        public Form_after_flight()
        {
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();

        private void But_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                { con.Open(); }
                //query not complete wait for passing action id after finish flight code
                String query = "UPDATE FlightSchedule SET  action_capacity = '" + textBox_cap.Text + "',action_startTime = '" + textBox_startTime.Text + "',action_finishTime= '" + textBox_finishTime.Text + "' WHERE action_id =  ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว !!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
