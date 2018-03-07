using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Log;
using MissionPlanner.Utilities;
using SerialPort = MissionPlanner.Comms.SerialPort;

namespace MissionPlanner.GCSViews
{
    public partial class SelectMenu : MyUserControl
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        internal static ICommsSerial comPort;
        public static bool threadrun;
        private readonly List<string> cmdHistory = new List<string>();
        private readonly object thisLock = new object();
        private int history;
        private bool inlogview;
        private int inputStartPos;
        DateTime lastsend = DateTime.MinValue;

        public SelectMenu()
        {
            threadrun = false;

            InitializeComponent();

        }
        
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        Controls.MainSwitcher MyView;

        private void MainFlight_Click(object sender, EventArgs e)
        {
            MyView.ShowScreen("FlightPlanner");
        }

        private void MainSetting_Click(object sender, EventArgs e)
        {
            MyView.ShowScreen("InitialSetup");
        }

        private void MainUser_Click(object sender, EventArgs e)
        {
            MyView.ShowScreen("UserLogin");
        }
    }
}