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
    public partial class Form_farm_act : Form
    {
        DateTime startDate, endDate;

        public Form_farm_act()
        {
            InitializeComponent();
            
        }
        
        public Form_farm_act(string id_farm)
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

        }

        private void But_add_act_Click(object sender, EventArgs e)
        { 
            // pass to add act
            //Form_Add_farm_act form_Add_Farm_Act = new Form_Add_farm_act();
            //form_Add_Farm_Act.ShowDialog();
        }

        void LoadList()
        {
            //show data to DataGridView
            con.Open();

            string startDt = dateTimePicker_startDate.Value.ToString("yyyy-MM-dd");
            string endDt = dateTimePicker_stopDate.Value.ToString("yyyy-MM-dd");
            String query = @"SELECT * FROM FlightSchedule WHERE farm_id = '" + id_farm + "' AND action_finish = 'y' AND " +
                " ( action_datetime >= '" + startDt + "' and action_datetime <='" + endDt + "' )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_afterFlight.DataSource = dt;
            con.Close();
        }

        private void panelFarm_Act_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            LoadList();
        }

        private void Form_farm_act_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Drone_s_Flight_PlannerDataSet4.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter2.Fill(this._Drone_s_Flight_PlannerDataSet4.FlightSchedule);
            LoadList();
        }


        private void button_edit_Click(object sender, EventArgs e)
        {
            // pass to edit act
            //Form_Edit_farm_act form_edit_farm_act = new Form_Edit_farm_act(id_farm);
            //form_edit_farm_act.ShowDialog();

        }

        private void Form_farm_act_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_show_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dateTimePicker_startDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dateTimePicker_startDate.Value;
        }

        private void dateTimePicker_stopDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dateTimePicker_stopDate.Value;
        }
    }
}
