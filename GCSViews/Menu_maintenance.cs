using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Log;
using MissionPlanner.Utilities;
using MissionPlanner.Plugin;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_maintenance : MyUserControl
    {
        public Menu_maintenance()
        {
            InitializeComponent();

            add_DG();

            void add_DG()
            {
                int n = 0;
                for(int i=1; i<=8; i++)
                {
                    n = DG_Farm.Rows.Add();
                    DG_Farm.Rows[n].Cells[0].Value = "0001";
                    DG_Farm.Rows[n].Cells[1].Value = "Organic farm";
                    DG_Farm.Rows[n].Cells[2].Value = "Bangkok";
                    DG_Farm.Rows[n].Cells[3].Value = "Napat Jintanakosol";

                    n = DG_Farm.Rows.Add();
                    DG_Farm.Rows[n].Cells[0].Value = "0002";
                    DG_Farm.Rows[n].Cells[1].Value = "Black Forest";
                    DG_Farm.Rows[n].Cells[2].Value = "Samut Prakarn";
                    DG_Farm.Rows[n].Cells[3].Value = "Mookda";
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Main_farm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DG_Farm.Columns[e.ColumnIndex].Name == "Activity")
            {
                Form_farm_act form_Farm_Act = new Form_farm_act();
                form_Farm_Act.ShowDialog();
            }

            if (DG_Farm.Columns[e.ColumnIndex].Name == "FlightSchedule")
            {
                Form_main_Schedule form_Farm_Schedule = new Form_main_Schedule();
                form_Farm_Schedule.ShowDialog();
            }

            if (DG_Farm.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DG_Farm.RemoveCurrent();
            }

            if (DG_Farm.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form_Edit_farm form_Edit_Farm = new Form_Edit_farm();
                form_Edit_Farm.ShowDialog();
            }

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_farm_Click(object sender, EventArgs e)
        {
            Form_Add_farm form_Add_Farm = new Form_Add_farm();
            form_Add_Farm.ShowDialog();
        }
    }
}
