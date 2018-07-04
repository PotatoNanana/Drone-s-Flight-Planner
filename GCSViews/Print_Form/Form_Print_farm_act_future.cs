using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.Print_Form
{
    public partial class Form_Print_farm_act_future : Form
    {
        public Form_Print_farm_act_future()
        {
            InitializeComponent();
        }

        private void Form_Print_farm_act_future_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
