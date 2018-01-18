using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Comms;
using System.Globalization;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System.IO;

namespace MissionPlanner
{
    public partial class DroneLog : Form
    {
        System.Threading.Thread t12;
        static bool threadrun = false;
        static FollowMe Instance;
        static internal SerialPort comPort = new SerialPort();
        static internal PointLatLngAlt lastgotolocation = new PointLatLngAlt(0, 0, 0, "Goto last");
        static internal PointLatLngAlt gotolocation = new PointLatLngAlt(0, 0, 0, "Goto");
        static internal int intalt = 100;
        static float updaterate = 0.5f;

        public DroneLog()
        {
            InitializeComponent();

            MissionPlanner.Utilities.Tracking.AddPage(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.ToString(),
                System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        void mainloop()
        {
            DateTime nextsend = DateTime.Now;

            StreamWriter sw = new StreamWriter(File.OpenWrite("followmeraw.txt"));

            threadrun = true;
            while (threadrun)
            {
                try
                {
                    string line = comPort.ReadLine();

                    sw.WriteLine(line);
                    
                }
                catch
                {
                    System.Threading.Thread.Sleep((int) (1000/updaterate));
                }
            }

            sw.Close();
        }

        private void SerialOutput_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}