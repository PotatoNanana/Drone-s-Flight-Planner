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

            MyView = new MainSwitcher(this);

            add_DG();

            void add_DG()
            {
                int n = 0;
                for(int i=1; i<=8; i++)
                {
                    n = DG_Drone.Rows.Add();
                    DG_Drone.Rows[n].Cells[0].Value = "DR001";
                    DG_Drone.Rows[n].Cells[1].Value = "Sky Hunter X8";
                    DG_Drone.Rows[n].Cells[2].Value = "Bangkok";
                    DG_Drone.Rows[n].Cells[3].Value = "Napat Jintanakosol";

                    n = DG_Drone.Rows.Add();
                    DG_Drone.Rows[n].Cells[0].Value = "D003";
                    DG_Drone.Rows[n].Cells[1].Value = "DJI Mavic air";
                }
            }
        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_DronePart_Clicked;

        protected virtual void OnGotoDronePartClicked(EventArgs e)
        {
            Goto_DronePart_Clicked?.Invoke(this, e);
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

        private void DG_Drone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DG_Drone.Columns[e.ColumnIndex].Name == "drone_detail")
            {
                OnGotoDronePartClicked(e);
            }

            if (DG_Drone.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DG_Drone.RemoveCurrent();
            }

            if (DG_Drone.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form_Edit_drone form_Edit_Drone = new Form_Edit_drone();
                form_Edit_Drone.ShowDialog();
            }

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_Click(object sender, EventArgs e)
        {
            Form_Add_drone form_Add_Drone = new Form_Add_drone();
            form_Add_Drone.ShowDialog();
        }
    }
}
