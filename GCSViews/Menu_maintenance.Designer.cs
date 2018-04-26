namespace MissionPlanner.GCSViews
{
    partial class Menu_maintenance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Menu_maintenance
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Name = "Menu_maintenance";
            this.Size = new System.Drawing.Size(700, 390);
            this.Load += new System.EventHandler(this.Menu_maintenance_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Drone;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.BindingSource droneBindingSource;
        private DroneFlightPlannerDataSet droneFlightPlannerDataSet;
        private DroneFlightPlannerDataSetTableAdapters.DroneTableAdapter droneTableAdapter;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_droneID;
        private System.Windows.Forms.TextBox textBox_droneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dronenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource droneBindingSource1;
        private Drone drone;
        private DroneTableAdapters.DroneTableAdapter droneTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button BUT_drone_add;
        private System.Windows.Forms.Button button_serch;
        private System.Windows.Forms.ComboBox comboBox_alarm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reg;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_respond;
        private System.Windows.Forms.TextBox textBox_venAdd;
        private System.Windows.Forms.TextBox textBox_venPhone;
        private System.Windows.Forms.TextBox textBox_VenName;
        private System.Windows.Forms.TextBox textBox_partName;
        private System.Windows.Forms.TextBox textBox_partPosition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_partID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private Controls.MyDataGridView DG_Part;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private DroneFlightPlannerDataSet4 droneFlightPlannerDataSet4;
        private DroneFlightPlannerDataSet4TableAdapters.DeviceListTableAdapter deviceListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicepositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicebuyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicestartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceexpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicealarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button But_savePart;
        private System.Windows.Forms.Button button_editPart;
        private System.Windows.Forms.Button button_deletePart;
    }
}
