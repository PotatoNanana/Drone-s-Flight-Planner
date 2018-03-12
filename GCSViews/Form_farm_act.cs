using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class Form_farm_act : Form
    {
        public Form_farm_act()
        {
            InitializeComponent();

            add_DG();

            void add_DG()
            {
                int n = 0;
                for (int i = 1; i <= 8; i++)
                {
                    n = DG_Farm.Rows.Add();
                    DG_Farm.Rows[n].Cells[0].Value = "25/06/2016";
                    DG_Farm.Rows[n].Cells[1].Value = "05268";
                    DG_Farm.Rows[n].Cells[2].Value = "0025";
                    DG_Farm.Rows[n].Cells[3].Value = "รดน้ำ";
                    DG_Farm.Rows[n].Cells[4].Value = "1250";
                    DG_Farm.Rows[n].Cells[5].Value = "30000";

                    n = DG_Farm.Rows.Add();
                    DG_Farm.Rows[n].Cells[0].Value = "13/09/2016";
                    DG_Farm.Rows[n].Cells[1].Value = "06953";
                    DG_Farm.Rows[n].Cells[2].Value = "0074";
                    DG_Farm.Rows[n].Cells[3].Value = "โรยปุ๋ย";
                    DG_Farm.Rows[n].Cells[4].Value = "230";
                    DG_Farm.Rows[n].Cells[5].Value = "25000";
                }
            }
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_add_act_Click(object sender, EventArgs e)
        {
            Form_Add_farm_act form_Add_Farm_Act = new Form_Add_farm_act();
            form_Add_Farm_Act.ShowDialog();
        }
        
        private void DG_Farm_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
