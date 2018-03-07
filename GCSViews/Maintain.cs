using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;
using System.Reflection;
using log4net;
using MissionPlanner.Controls.BackstageView;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Utilities;
using System.Resources;

namespace MissionPlanner.GCSViews
{
    public partial class Maintain : MyUserControl, IActivate
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static string lastpagename = "";

        public Maintain()
        {
            InitializeComponent();
        }

        public bool isConnected
        {
            get { return MainV2.comPort.BaseStream.IsOpen; }
        }

        public bool isDisConnected
        {
            get { return !MainV2.comPort.BaseStream.IsOpen; }
        }

        private BackstageViewPage AddBackstageViewPage(Type userControl, string headerText, bool enabled = true,
    BackstageViewPage Parent = null, bool advanced = false)
        {
            try
            {
                if (enabled)
                    return backstageView.AddPage(userControl, headerText, Parent, advanced);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }

            return null;
        }

        public void Activate()
        {
        }

        private void Maintain_Load(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager(this.GetType());

            AddBackstageViewPage(typeof(ConfigFirmwareDisabled), rm.GetString("backstageViewPagefw.Text"), isConnected);
            AddBackstageViewPage(typeof(ConfigFirmware), rm.GetString("backstageViewPagefw.Text"), isDisConnected);
            AddBackstageViewPage(typeof(ConfigWizard), rm.GetString("backstageViewPagewizard.Text"));

            //var mand = addbackstageviewpage(typeof(configmandatory), rm.getstring("backstageviewpagemand.text"), isconnected);
            //addbackstageviewpage(typeof(configtradheli), rm.getstring("backstageviewpagetradheli.text"), isheli, mand);
            //addbackstageviewpage(typeof(configframetype), rm.getstring("backstageviewpageframetype.text"), iscopter && !iscopter35plus, mand);
            //addbackstageviewpage(typeof(configframeclasstype), rm.getstring("backstageviewpageframetype.text"), iscopter && iscopter35plus, mand);
            //addbackstageviewpage(typeof(configaccelerometercalibration), rm.getstring("backstageviewpageaccel.text"), isconnected, mand);
            //addbackstageviewpage(typeof(confighwcompass), rm.getstring("backstageviewpagecompass.text"), isconnected, mand);
            //addbackstageviewpage(typeof(configradioinput), rm.getstring("backstageviewpageradio.text"), isconnected, mand);
            //addbackstageviewpage(typeof(configesccalibration), "esc calibration", isconnected, mand);
            //addbackstageviewpage(typeof(configflightmodes), rm.getstring("backstageviewpageflmode.text"), isconnected, mand);
            //addbackstageviewpage(typeof(configfailsafe), rm.getstring("backstageviewpagefs.text"), isconnected, mand);

            var opt = AddBackstageViewPage(typeof(ConfigOptional), rm.GetString("backstageViewPageopt.Text"));
            AddBackstageViewPage(typeof(ConfigGPSInject), "RTK/GPS Inject", true, opt);
            AddBackstageViewPage(typeof(Sikradio), rm.GetString("backstageViewPageSikradio.Text"), true, opt);
            AddBackstageViewPage(typeof(ConfigBatteryMonitoring), rm.GetString("backstageViewPagebatmon.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigBatteryMonitoring2), rm.GetString("backstageViewPageBatt2.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWUAVCAN), "UAVCAN", isConnected, opt);
            AddBackstageViewPage(typeof(ConfigCompassMot), rm.GetString("backstageViewPagecompassmot.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWRangeFinder), rm.GetString("backstageViewPagesonar.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWAirspeed), rm.GetString("backstageViewPageairspeed.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWPX4Flow), rm.GetString("backstageViewPagePX4Flow.Text"), true, opt);
            AddBackstageViewPage(typeof(ConfigHWOptFlow), rm.GetString("backstageViewPageoptflow.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWOSD), rm.GetString("backstageViewPageosd.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigMount), rm.GetString("backstageViewPagegimbal.Text"), isConnected, opt);
            //AddBackstageViewPage(typeof(ConfigAntennaTracker), rm.GetString("backstageViewPageAntTrack.Text"), isTracker, opt);
            AddBackstageViewPage(typeof(ConfigMotorTest), rm.GetString("backstageViewPageMotorTest.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWBT), rm.GetString("backstageViewPagehwbt.Text"), true, opt);
            AddBackstageViewPage(typeof(ConfigHWParachute), rm.GetString("backstageViewPageParachute.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(ConfigHWESP8266), rm.GetString("backstageViewPageESP.Text"), isConnected, opt);
            AddBackstageViewPage(typeof(Antenna.Tracker), "Antenna Tracker", true, opt);


            // remeber last page accessed
            foreach (BackstageViewPage page in backstageView.Pages)
            {
                if (page.LinkText == lastpagename && page.Show)
                {
                    backstageView.ActivatePage(page);
                    break;
                }
            }

            ThemeManager.ApplyThemeTo(this);
        }

        private void Maintain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backstageView.SelectedPage != null)
                lastpagename = backstageView.SelectedPage.LinkText;

            backstageView.Close();
        }

    }
}
