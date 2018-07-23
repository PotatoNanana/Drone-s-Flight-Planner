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

namespace MissionPlanner.GCSViews
{
    public partial class Form_farm_role : Form
    {
        DateTime startDate, endDate;

        public Form_farm_role()
        {
            InitializeComponent();
        }
        
        public Form_farm_role(string id_farm)
        {
            this.id_farm = id_farm;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        private string id_farm;
        
        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Form_farm_role_KeyDown(object sender, KeyEventArgs e)
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
        
        private void DG_unselected_Paint(object sender, PaintEventArgs e)
        {
            loadUnselected();
        }

        private void DG_selected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadSelected();
        }

        void loadUnselected()
        {
            //show data to DataGridView
            con.Open();
            String query = @"SELECT distinct UserLogin.username FROM UserLogin "+
                "inner join farmRole ON farmRole.username != UserLogin.username and UserLogin.username !='"+ Validation.validateUsername + "' farmRole.farm_id='"+ id_farm+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_unselected.DataSource = dt;
            con.Close();
        }

        private void Form_farm_role_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'role_selected.UserLogin' table. You can move, or remove it, as needed.
            this.userLoginTableAdapter1.Fill(this.role_selected.UserLogin);
            // TODO: This line of code loads data into the 'role_unselected.UserLogin' table. You can move, or remove it, as needed.
            this.userLoginTableAdapter.Fill(this.role_unselected.UserLogin);
        }

        private void DG_selected_Paint(object sender, PaintEventArgs e)
        {
            loadSelected();
        }

        void loadSelected()
        {
            //show data to DataGridView
            con.Open();
            String query = @"SELECT distinct UserLogin.username FROM UserLogin " +
                "inner join farmRole ON farmRole.username = UserLogin.username and UserLogin.username !='" + Validation.validateUsername + "' farmRole.farm_id='" + id_farm + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_selected.DataSource = dt;
            con.Close();
        }
    }
}
