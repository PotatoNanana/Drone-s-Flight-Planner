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
            textBox_actID.Text = DG_Farm.SelectedRows[0].Cells[0].Value.ToString();
            textBox_actName.Text = DG_Farm.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void But_add_act_Click(object sender, EventArgs e)
        { 
            // add schedule
            Form_Add_farm_act form_Add_Farm_Act = new Form_Add_farm_act(id_farm);
            form_Add_Farm_Act.ShowDialog();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            //show data to DataGridView
            con.Open();

            //string a = "yyyy-MM-dd";
            string dateNow = String.Format("{0:yyyy-MM-dd}", DateTime.Now);

            String query = "SELECT * FROM schedule_action WHERE farm_id = '" + id_farm + "' AND action_date >= '" + dateNow + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_Farm.DataSource = dt;
            con.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // delete Schedule
            if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con.Open();
                String query = "DELETE FROM schedule_action where action_id = '" + textBox_actID.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("DELETE Record From DB Success!!");
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            // edit schedule
            Form_Edit_farm_act form_Edit_Farm = new Form_Edit_farm_act();
            form_Edit_Farm.ShowDialog();
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            // serch record
        }

        private void Form_farm_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedule_act.schedule_action' table. You can move, or remove it, as needed.
            this.schedule_actionTableAdapter.Fill(this.schedule_act.schedule_action);

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
    }
}
