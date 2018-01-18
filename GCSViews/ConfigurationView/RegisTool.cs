using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using log4net;
using Microsoft.Scripting.Utils;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class FirstTool : UserControl
    {
        public FirstTool()
        {
            InitializeComponent();
        }

        internal bool startup = true;
        public void Activate()
        {
            startup = true;

            CMB_paramfiles.Enabled = false;
            BUT_paramfileload.Enabled = false;
            ThreadPool.QueueUserWorkItem(updatedefaultlist);

            Params.Enabled = false;

            foreach (DataGridViewColumn col in Params.Columns)
            {
                if (!String.IsNullOrEmpty(Settings.Instance["rawparam_" + col.Name + "_width"]))
                {
                    col.Width = Settings.Instance.GetInt32("rawparam_" + col.Name + "_width");
                    log.InfoFormat("{0} to {1}", col.Name, col.Width);
                }
            }

            processToScreen();

            Params.Enabled = true;

            Common.MessageShowAgain(Strings.RawParamWarning, Strings.RawParamWarningi);

            startup = false;

            txt_search.Focus();
        }

        private void BUT_browse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = ".jpeg",
                RestoreDirectory = true,
                Filter = ParamFile.FileMask
            })
            {
                var dr = ofd.ShowDialog();

                
            }
        }
    }
}
