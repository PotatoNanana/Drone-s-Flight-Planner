using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigFlightLog_farm2 : UserControl, IActivate
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Dictionary<int, int> baudmap = new Dictionary<int, int>
        {
            {57600, 7},
            {38400, 6},
            {9600, 4},
            {19200, 5},
            {115200, 8},
            {1200, 1},
            {2400, 2},
            {4800, 3}
        };

        public ConfigFlightLog_farm2()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
            }
            Enabled = true;
        }

        private void BUT_ConfigLogin_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfigLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfigLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void mavlinkComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}