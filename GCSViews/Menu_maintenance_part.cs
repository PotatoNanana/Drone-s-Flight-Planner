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
    public partial class Menu_maintenance_part : MyUserControl
    {
        public Menu_maintenance_part()
        {
            InitializeComponent();

            MyView = new MainSwitcher(this);

            add_DG();

            void add_DG()
            {
                int n = 0;
                for(int i=1; i<=8; i++)
                {
                    n = DG_Farm.Rows.Add();
                    DG_Farm.Rows[n].Cells[0].Value = "P001";
                    DG_Farm.Rows[n].Cells[1].Value = "Battery";
                    DG_Farm.Rows[n].Cells[2].Value = "-";
                    DG_Farm.Rows[n].Cells[3].Value = "12/08/2016";
                    DG_Farm.Rows[n].Cells[4].Value = "14/08/2016";
                    DG_Farm.Rows[n].Cells[5].Value = "30/12/2017";
                    DG_Farm.Rows[n].Cells[6].Value = "-";
                    DG_Farm.Rows[n].Cells[8].Value = "2500";
                    DG_Farm.Rows[n].Cells[9].Value = "AG Co.,ltd";
                    DG_Farm.Rows[n].Cells[10].Value = "0942416587";
                    DG_Farm.Rows[n].Cells[11].Value = "44 BanBung, Samut Prakarn";
                    DG_Farm.Rows[n].Cells[12].Value = "ณภัทร";

                    n = DG_Farm.Rows.Add();
                    DG_Farm.Rows[n].Cells[0].Value = "P002";
                    DG_Farm.Rows[n].Cells[1].Value = "propeller";
                    DG_Farm.Rows[n].Cells[2].Value = "-";
                    DG_Farm.Rows[n].Cells[3].Value = "12/08/2016";
                    DG_Farm.Rows[n].Cells[4].Value = "14/08/2016";
                    DG_Farm.Rows[n].Cells[5].Value = "30/12/2017";
                    DG_Farm.Rows[n].Cells[6].Value = "-";
                    DG_Farm.Rows[n].Cells[8].Value = "7600";
                    DG_Farm.Rows[n].Cells[9].Value = "BJKK PLC.";
                    DG_Farm.Rows[n].Cells[10].Value = "0841256987";
                    DG_Farm.Rows[n].Cells[11].Value = "1544 Orn Nuch, Bangkok";
                    DG_Farm.Rows[n].Cells[12].Value = "จุฬารัตน์";
                }
            }
        }

        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_Drone_Clicked;
        public static event EventHandler Goto_DronePre_Clicked;

        protected virtual void OnGotoDroneClicked(EventArgs e)
        {
            Goto_Drone_Clicked?.Invoke(this, e);
        }

        protected virtual void OnGotoDronePreClicked(EventArgs e)
        {
            Goto_DronePre_Clicked?.Invoke(this, e);
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
            if(DG_Farm.Columns[e.ColumnIndex].Name == "part_detail")
            {
                OnGotoDronePreClicked(e);
            }

            if (DG_Farm.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you wnat to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DG_Farm.RemoveCurrent();
            }

            if (DG_Farm.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form_Edit_drone_part form_Edit_Drone_Part = new Form_Edit_drone_part();
                form_Edit_Drone_Part.ShowDialog();
            }

        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_add_drone_part_Click(object sender, EventArgs e)
        {
            Form_Add_drone_part form_Add_Drone_Part = new Form_Add_drone_part();
            form_Add_Drone_Part.ShowDialog();
        }
        
        private void but_backto_pre_Click(object sender, EventArgs e)
        {
            OnGotoDroneClicked(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Add_drone_part form_add_drone_part = new Form_Add_drone_part();
            form_add_drone_part.ShowDialog();
        }
    }
}
