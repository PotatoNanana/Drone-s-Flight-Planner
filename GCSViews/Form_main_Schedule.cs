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
    public partial class Form_main_Schedule : Form
    {
        public Form_main_Schedule()
        {
            InitializeComponent();            
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void DG_Farm_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            textBox_actID.Text = DG_Farm.SelectedRows[0].Cells[3].Value.ToString();
            textBox_actName.Text = DG_Farm.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void But_add_act_Click(object sender, EventArgs e)
        {
            Form_Add_act form_Add_Act = new Form_Add_act();
            form_Add_Act.ShowDialog();
        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();

            //string a = "yyyy-MM-dd";
            string dateNow = String.Format("{0:yyyy-MM-dd}", DateTime.Now);

            String query = "SELECT * FROM FlightSchedule WHERE action_finish = 'n' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void Form_main_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f_Schedule.FlightSchedule' table. You can move, or remove it, as needed.            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                string query = "DELETE FROM FlightSchedule WHERE action_no = '" + textBox_actID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DELETE Record From DB Success!!");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Form_Edit_act form_Edit_Act = new Form_Edit_act();
            form_Edit_Act.ShowDialog();
        }

        private void textBox_actID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
