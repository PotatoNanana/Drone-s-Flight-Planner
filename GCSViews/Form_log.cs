﻿using System;
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
    public partial class Form_log : Form
    {
        private string file;
        

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        SqlCommand cmd;

        public Form_log()
        {
            InitializeComponent();
        }

        public Form_log(string file)
        {
            InitializeComponent();
            this.file = file;
        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        public String droneId;

        private void But_save_Click(object sender, EventArgs e) // 
        {
            FlightPlanner FP = new FlightPlanner();
            // FlightPlanner.id_farm = ID_farm;
            // FlightPlanner.id_drone = ID_drone;
            string ID_farm = FP.id_farmGet();       
            string ID_drone = FP.id_droneGet();

            con.Open();

            // edit flight log
            String query = "INSERT INTO FlightLog (log_no,action_no,farm_no,drone_id,pattern_name,pattern_mask) " + "VALUES('" + textBox_logNo.Text + "','" +comboBox1.Text + "',@idfarm,@iddrone,'" + file + "','" +textBox_patternMask.Text+"' )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);

            cmd.Parameters.Add("@idfarm", ID_farm);
            cmd.Parameters.Add("@iddrone", ID_drone);

            // update status activity in flight_schedule
            //String query2 = "UPDATE FlightSchedule SET action_finish = 'y' WHERE action_id = '"+comboBox1.Text+"' "; //old
            String query2 = "SELECT * INTO AfterFlight WHERE action_id = '"+comboBox1.Text+"'";

            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("บันทึกข้อมูลสำเร็จ !!");

            //notify drone tools
            droneId = ID_drone;
            
            //go to form notify drone part 
            Form_Notify_drone_part form_notify_drone_part = new Form_Notify_drone_part(droneId);
            form_notify_drone_part.ShowDialog();

            this.Close();
        }

        /*private void textBox_patternName_TextChanged(object sender, EventArgs e)
        {

            textBox_patternName.Text = file;
        
            textBox_patternName.Text = file;
        

            //textBox_patternName.Text = file;
        } */


        private void Form_log_KeyDown(object sender, KeyEventArgs e)
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

        private void Form_log_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet4.FlightSchedule' table. You can move, or remove it, as needed.
            this.flightScheduleTableAdapter1.Fill(this.droneFlightPlannerDataSet4.FlightSchedule);
            // TODO: This line of code loads data into the 'action_name.FlightSchedule' table. You can move, or remove it, as needed.
            this.flightScheduleTableAdapter.Fill(this.action_name.FlightSchedule);

        }

       /* private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.flightScheduleTableAdapter1.FillBy(this.droneFlightPlannerDataSet4.FlightSchedule, id_farmToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        } */
    }
}
