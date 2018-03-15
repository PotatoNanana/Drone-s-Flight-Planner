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

namespace MissionPlanner.GCSViews
{
    public partial class Menu_main2 : MyUserControl
    {
        public Menu_main2()
        {
            InitializeComponent();

           MyView = new MainSwitcher(this);
            Add_DG();

            void Add_DG()
            {
                int n = 0;
                for (int i = 1; i <= 2; i++)
                {
                    n = DG_farm.Rows.Add();
                    DG_farm.Rows[n].Cells[0].Value = "0001";
                    DG_farm.Rows[n].Cells[1].Value = "Organic farm";
                    DG_farm.Rows[n].Cells[2].Value = "Bangkok";
                    DG_farm.Rows[n].Cells[3].Value = "Napat Jintanakosol";

                    n = DG_farm.Rows.Add();
                    DG_farm.Rows[n].Cells[0].Value = "0002";
                    DG_farm.Rows[n].Cells[1].Value = "Black Forest";
                    DG_farm.Rows[n].Cells[2].Value = "Samut Prakarn";
                    DG_farm.Rows[n].Cells[3].Value = "Mookda";
                }

                for (int i = 1; i <= 3; i++)
                {
                    n = DG_schedule.Rows.Add();
                    DG_schedule.Rows[n].Cells[0].Value = "24/08/2017";
                    DG_schedule.Rows[n].Cells[1].Value = "0584";
                    DG_schedule.Rows[n].Cells[2].Value = "0001";
                    DG_schedule.Rows[n].Cells[3].Value = "สำรวจฟาร์ม";
                    DG_schedule.Rows[n].Cells[4].Value = "0056";
                    DG_schedule.Rows[n].Cells[5].Value = "DR01";

                    n = DG_schedule.Rows.Add();
                    DG_schedule.Rows[n].Cells[0].Value = "08/09/2016";
                    DG_schedule.Rows[n].Cells[1].Value = "0778";
                    DG_schedule.Rows[n].Cells[2].Value = "0002";
                    DG_schedule.Rows[n].Cells[3].Value = "โรยปุ๋ย";
                    DG_schedule.Rows[n].Cells[4].Value = "0078";
                    DG_schedule.Rows[n].Cells[5].Value = "DR02";
                }

                for (int i = 1; i <= 3; i++)
                {   
                    n = DG_maintenance.Rows.Add();
                    DG_maintenance.Rows[n].Cells[0].Value = "06/07/2017";
                    DG_maintenance.Rows[n].Cells[1].Value = "0058";
                    DG_maintenance.Rows[n].Cells[2].Value = "เปลี่ยนแบตเตอรี่";
                    DG_maintenance.Rows[n].Cells[3].Value = "2000";
                    DG_maintenance.Rows[n].Cells[4].Value = "ณภัทร";
                    DG_maintenance.Rows[n].Cells[5].Value = "Aura";
                    DG_maintenance.Rows[n].Cells[6].Value = "02-111-2589";
                    DG_maintenance.Rows[n].Cells[7].Value = "Bangkok";

                    n = DG_maintenance.Rows.Add();
                    DG_maintenance.Rows[n].Cells[0].Value = "05/06/2017";
                    DG_maintenance.Rows[n].Cells[1].Value = "0568";
                    DG_maintenance.Rows[n].Cells[2].Value = "ตรวจสอบใบพัด";
                    DG_maintenance.Rows[n].Cells[3].Value = "1500";
                    DG_maintenance.Rows[n].Cells[4].Value = "จุฬารัตน์";
                    DG_maintenance.Rows[n].Cells[5].Value = "Bang Chak";
                    DG_maintenance.Rows[n].Cells[6].Value = "061-289-2658";
                    DG_maintenance.Rows[n].Cells[7].Value = "Samut Sakorn";
                }
            }
        }
        
        Controls.MainSwitcher MyView;
        public static event EventHandler Goto_farmProfile_Clicked;

        protected virtual void OnGotoFarmProfileClicked(EventArgs e)
        {
            Goto_farmProfile_Clicked?.Invoke(this, e);
        }

        protected override void OnLoad(EventArgs e)
        {
            //MyView.AddScreen(new MainSwitcher.Screen("Menu_farm", typeof(GCSViews.Menu_farm), true));
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Goto_farmProfile_Click(object sender, EventArgs e)
        {
            OnGotoFarmProfileClicked(e);

        }

        public void DG_farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void myDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lineSeparator1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
