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
    public partial class Menu_maintenance_pre : MyUserControl
    {
        public Menu_maintenance_pre()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);

            add_DG();

            void add_DG()
            {
                int n = 0;
                n = DG_Farm.Rows.Add();
                DG_Farm.Rows[n].Cells[0].Value = "12/06/2017";
                DG_Farm.Rows[n].Cells[1].Value = "Change Battery";
                DG_Farm.Rows[n].Cells[4].Value = "AG Co.,ltd";
                DG_Farm.Rows[n].Cells[5].Value = "0942416587";
                DG_Farm.Rows[n].Cells[6].Value = "44 BanBung, Samut Prakarn";
                DG_Farm.Rows[n].Cells[7].Value = "5";
                DG_Farm.Rows[n].Cells[8].Value = "ณภัทร";

                n = DG_Farm.Rows.Add();
                DG_Farm.Rows[n].Cells[0].Value = "P002";
                DG_Farm.Rows[n].Cells[1].Value = "Check battery";
                DG_Farm.Rows[n].Cells[4].Value = "BJKK PLC.";
                DG_Farm.Rows[n].Cells[5].Value = "0841256987";
                DG_Farm.Rows[n].Cells[6].Value = "1544 Orn Nuch, Bangkok";
                DG_Farm.Rows[n].Cells[7].Value = "3";
                DG_Farm.Rows[n].Cells[8].Value = "จุฬารัตน์";
            }
        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_Drone_Clicked;

        protected virtual void OnGotoDroneClicked(EventArgs e)
        {
            Goto_Drone_Clicked?.Invoke(this, e);
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
            if (DG_Farm.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DG_Farm.RemoveCurrent();
            }

            if (DG_Farm.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form_Edit_drone_pre form_Edit_Drone_Pre = new Form_Edit_drone_pre();
                form_Edit_Drone_Pre.ShowDialog();
            }

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_pre_Click(object sender, EventArgs e)
        {
            Form_Add_drone_pre form_Add_Drone_Pre = new Form_Add_drone_pre();
            form_Add_Drone_Pre.ShowDialog();
        }
        
        private void but_backto_pre_Click(object sender, EventArgs e)
        {
            OnGotoDroneClicked(e);
        }
    }
}
