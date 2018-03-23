using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigApp : UserControl, IActivate
    {
        public ConfigApp()
        {
            InitializeComponent();
        }

        public void Activate()
        {
        }
    }
}