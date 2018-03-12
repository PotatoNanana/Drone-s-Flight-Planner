using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Controls;
using MissionPlanner.Controls.BackstageView;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Utilities;

namespace MissionPlanner.GCSViews
{
    public partial class FlightLog : MyUserControl, IActivate
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static string lastpagename = "";

        public FlightLog()
        {
            InitializeComponent();
        }

        public void Activate()
        {
        }

        private BackstageViewPage AddBackstageViewPage(Type userControl, string headerText,
            BackstageViewPage Parent = null, bool advanced = false)
        {
            try
            {
                return backstageView.AddPage(userControl, headerText, Parent, advanced);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }
        }

        private void FlightLog_Load(object sender, EventArgs e)
        {
            try
            {
                BackstageViewPage start = null;

                if (MainV2.comPort.BaseStream.IsOpen)
                {
                    //start = AddBackstageViewPage(typeof(ConfigFlightModes), Strings.FlightModes);
                    AddBackstageViewPage(typeof(ConfigFarmInfo), "Farm 1");
                    AddBackstageViewPage(typeof(ConfigFarmInfo), "Farm 2");
                    AddBackstageViewPage(typeof(ConfigFarmInfo), "Farm 3");
                }
                else
                {
                    //start = AddBackstageViewPage(typeof(ConfigFlightModes), Strings.FlightModes);
                    AddBackstageViewPage(typeof(ConfigFarmInfo), "Farm 1");
                    AddBackstageViewPage(typeof(ConfigFarmInfo), "Farm 2");
                    AddBackstageViewPage(typeof(ConfigFarmInfo), "Farm 3");
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

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backstageView.SelectedPage != null)
                lastpagename = backstageView.SelectedPage.LinkText;

            backstageView.Close();
        }

        private void backstageView_Load(object sender, EventArgs e)
        {

        }
    }
}