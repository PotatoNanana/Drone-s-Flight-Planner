using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Controls;
using MissionPlanner.Controls.BackstageView;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Utilities;
using System.Resources;

namespace MissionPlanner.GCSViews
{
    public partial class Menu_setup : MyUserControl, IActivate
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static string lastpagename = "";

        public Menu_setup()
        {
            InitializeComponent();
        }

        public void Activate()
        {
        }

        public bool isConnected
        {
            get { return MainV2.comPort.BaseStream.IsOpen; }
        }

        public bool isDisConnected
        {
            get { return !MainV2.comPort.BaseStream.IsOpen; }
        }

        public bool isTracker
        {
            get { return isConnected && MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduTracker; }
        }

        public bool isCopter
        {
            get { return isConnected && MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2; }
        }

        public bool isCopter35plus
        {
            get { return MainV2.comPort.MAV.cs.version >= Version.Parse("3.5"); }
        }

        public bool isHeli
        {
            get { return isConnected && MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.HELICOPTER; }
        }

        public bool isQuadPlane
        {
            get
            {
                return isConnected && isPlane &&
                       MainV2.comPort.MAV.param.ContainsKey("Q_ENABLE") &&
                       (MainV2.comPort.MAV.param["Q_ENABLE"].Value == 1.0);
            }
        }

        public bool isPlane
        {
            get
            {
                return isConnected &&
                       (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane ||
                        MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx);
            }
        }

        public bool isRover
        {
            get { return isConnected && MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover; }
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

        private void backstageView_Load(object sender, EventArgs e)
        {

        }

        private void Menu_setup_load(object sender, EventArgs e)
        {
            try
            {
                BackstageViewPage start = null;

                ResourceManager rm = new ResourceManager(this.GetType());
                //var drone = AddBackstageViewPage(typeof(ConfigDrone), "การทำงานของโดรน");

                //AddBackstageViewPage(typeof(ConfigFirmwareDisabled), " - FirmwareDisabled", isConnected );
                //AddBackstageViewPage(typeof(ConfigFirmware), " - Firmware", isDisConnected);
                AddBackstageViewPage(typeof(ConfigWizard), "ตั้งค่าเริ่มต่นของโดรน");

                //var mand = AddBackstageViewPage(typeof(ConfigMandatory), "Mandatory", isConnected);
                //AddBackstageViewPage(typeof(ConfigTradHeli), " - TradHeli", isHeli, mand);
                //AddBackstageViewPage(typeof(ConfigFrameType), " - Frame Type", isCopter && !isCopter35plus, mand);
                //AddBackstageViewPage(typeof(ConfigFrameClassType), " - FrameClassType", isCopter && isCopter35plus, mand);
                //AddBackstageViewPage(typeof(ConfigAccelerometerCalibration), " - Accelerometer Calibration", isConnected, mand);
                //AddBackstageViewPage(typeof(ConfigHWCompass), " - Compass", isConnected, mand);
                //AddBackstageViewPage(typeof(ConfigRadioInput), " - Radio Input", isConnected, mand);
                //AddBackstageViewPage(typeof(ConfigESCCalibration), " - ESC Calibration", isConnected, mand);
                //AddBackstageViewPage(typeof(ConfigFlightModes), " - Flight Modes", isConnected, mand);
                //AddBackstageViewPage(typeof(ConfigFailSafe), " - Fail Safe", isConnected, mand);

                //var opt = AddBackstageViewPage(typeof(ConfigOptional), " Optional", isConnected);
                //AddBackstageViewPage(typeof(ConfigGPSInject), " - RTK/GPS Inject", true, opt);
                //AddBackstageViewPage(typeof(Sikradio), " - Sikradio", true, opt);
                AddBackstageViewPage(typeof(ConfigBatteryMonitoring), "แบตเตอรี่ของโดรน", isConnected);
                //AddBackstageViewPage(typeof(ConfigBatteryMonitoring2), " - Battery Monitoring2", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigHWUAVCAN), " - UAVCAN", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigCompassMot), " - Compass Motor", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigHWRangeFinder), " - Range Finder", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigHWAirspeed), " - Airspeed", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigHWPX4Flow), " - PX4 Flow", true, opt);
                //AddBackstageViewPage(typeof(ConfigHWOptFlow), " - Opt Flow", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigHWOSD), " - OSD", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigMount), " - Mount", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigAntennaTracker), " - AntennaTracker", isTracker, opt);
                //AddBackstageViewPage(typeof(ConfigMotorTest), " - Motor Test", isConnected, opt);
                AddBackstageViewPage(typeof(ConfigHWBT), "บลูทูธ", true);
                //AddBackstageViewPage(typeof(ConfigHWParachute), " - Parachute", isConnected, opt);
                //AddBackstageViewPage(typeof(ConfigHWESP8266), " - ESP8266", isConnected, opt);
                //AddBackstageViewPage(typeof(Antenna.Tracker), " - Antenna Tracker", true, opt);


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
                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    //start = AddBackstageViewPage(typeof(ConfigFlightModes), Strings.FlightModes);

                    AddBackstageViewPage(typeof(ConfigPlanner), "ตั้งค่าการทำงานโปรแกรม");

                    //AddBackstageViewPage(typeof(ConfigPlanner), " - คลิกเพิื่อตั้งค่า", isConnected);

                    //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
                    //    AddBackstageViewPage(typeof( ConfigAC_Fence), Strings.GeoFence);

                    //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
                    //{
                    //    start = AddBackstageViewPage(typeof( ConfigSimplePids), Strings.BasicTuning);

                    //    AddBackstageViewPage(typeof( ConfigArducopter), Strings.ExtendedTuning);
                    //}

                    //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane)
                    //{
                    //    start = AddBackstageViewPage(typeof( ConfigArduplane), Strings.BasicTuning);
                    //}

                    //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover)
                    //{
                    //    start = AddBackstageViewPage(typeof( ConfigArdurover), Strings.BasicTuning);
                    //}

                    //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduTracker)
                    //{
                    //    start = AddBackstageViewPage(typeof( ConfigAntennaTracker), Strings.ExtendedTuning);
                    //}
                    //AddBackstageViewPage(typeof (ConfigFriendlyParams), Strings.StandardParams);

                    //if (MainV2.DisplayConfiguration.displayAdvancedParams)
                    //{
                    //    AddBackstageViewPage(typeof (ConfigFriendlyParamsAdv), Strings.AdvancedParams, null, true);
                    //}
                    //if (MainV2.DisplayConfiguration.displayFullParamList)
                    //{
                    //    AddBackstageViewPage(typeof (ConfigRawParams), Strings.FullParameterList, null, true);
                    //}
                    //if (MainV2.DisplayConfiguration.displayFullParamTree && !Program.MONO)
                    //{
                    //    AddBackstageViewPage(typeof (ConfigRawParamsTree), Strings.FullParameterTree, null, true);
                    //}                    

                    //if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
                    //{
                    //    start = AddBackstageViewPage(typeof( ConfigFlightModes), Strings.FlightModes);
                    //    AddBackstageViewPage(typeof( ConfigAteryxSensors), " - Ateryx Zero Sensors");
                    //    AddBackstageViewPage(typeof( ConfigAteryx), " - Ateryx Pids");
                    //}

                }
                else
                {
                    //start = AddBackstageViewPage(typeof(ConfigApp), "Application Setting");
                    start = AddBackstageViewPage(typeof(ConfigPlanner), "ตั้งค่าการทำงานโปรแกรม");
                }

                // apply theme before trying to display it
                ThemeManager.ApplyThemeTo(this);

                // remeber last page accessed
                foreach (BackstageViewPage page in backstageView.Pages)
                {
                    if (page.LinkText == lastpagename)
                    {
                        backstageView.ActivatePage(page);
                        break;
                    }
                }

                if (backstageView.SelectedPage == null && start != null)
                    backstageView.ActivatePage(start);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void AddBackstageViewPage(Type type, string v, BackstageViewPage drone)
        {
            throw new NotImplementedException();
        }

        private void AddBackstageViewPage(Type type, string advancedParams, object p, bool v)
        {
            throw new NotImplementedException();
        }

        private void Menu_setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backstageView.SelectedPage != null)
                lastpagename = backstageView.SelectedPage.LinkText;

            backstageView.Close();
        }

    }
}