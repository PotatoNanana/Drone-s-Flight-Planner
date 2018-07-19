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

        private void button_show_Click(object sender, EventArgs e)
        {
            
                       
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_log_history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Drone_s_Flight_PlannerDataSet6.Transact' table. You can move, or remove it, as needed.
            this.transactTableAdapter1.Fill(this._Drone_s_Flight_PlannerDataSet6.Transact);

        }

        private void Form_log_history_KeyDown(object sender, KeyEventArgs e)
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
            //show data to DataGridView
            con.Open();
            String query = "SELECT * FROM transact";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Flight.DataSource = dt;
            con.Close();
        }
    }
}
