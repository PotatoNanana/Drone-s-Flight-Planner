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
    public partial class Form_log_history : Form
    {
        public Form_log_history()
        {
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();

            //string a = "yyyy-MM-dd";
         
            String query = "SELECT * FROM FlightLog ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Flight.DataSource = dt;
            con.Close();
                       
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_log_history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightLog._FlightLog' table. You can move, or remove it, as needed.
            this.flightLogTableAdapter.Fill(this.flightLog._FlightLog);

        }
    }
}
