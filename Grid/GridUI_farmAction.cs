using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using MissionPlanner.Plugin;


namespace MissionPlanner
{
    public partial class GridUI_farmAction : Form
    {
        private Grid_farmAction grid_farmAction;

        public PluginHost Host { get; internal set; }

        // GridUI
        public GridUI_farmAction (GridUI_farmAction plugin)
        {
            InitializeComponent();
        }

        public GridUI_farmAction()
        {
        }

        public GridUI_farmAction(Grid_farmAction grid_farmAction)
        {
            this.grid_farmAction = grid_farmAction;
        }


        /// <summary>
        /// Added button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void LoadGrid()
        {
            throw new NotImplementedException();
        }
    }
}