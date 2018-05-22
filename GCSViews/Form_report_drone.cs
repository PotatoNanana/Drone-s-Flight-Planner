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
    public partial class Form_report_drone : Form
    {
        public Form_report_drone()
        {
            InitializeComponent();
        }

        private void Form_report_drone_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'droneFlightPlanner1DataSet_device.DeviceList' table. You can move, or remove it, as needed.
            this.deviceListTableAdapter.Fill(this.droneFlightPlanner1DataSet_device.DeviceList);
            // TODO: This line of code loads data into the 'droneFlightPlanner1DataSet_droneID.Drone' table. You can move, or remove it, as needed.
            this.droneTableAdapter.Fill(this.droneFlightPlanner1DataSet_droneID.Drone);

        }
    }
}
