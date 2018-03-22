using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigNull : UserControl, IActivate
    {
        public ConfigNull()
        {
            InitializeComponent();
        }

        public void Activate()
        {
        }
    }
}