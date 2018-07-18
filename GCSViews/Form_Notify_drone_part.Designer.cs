namespace MissionPlanner.GCSViews
{
    partial class Form_Notify_drone_part
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Notify_drone_part));
            this.flightLogTableAdapter = new MissionPlanner.FlightLogTableAdapters.FlightLogTableAdapter();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.But_exit = new System.Windows.Forms.Button();
            this.DG_Noti = new MissionPlanner.Controls.MyDataGridView();
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partDroneNotify = new MissionPlanner.PartDroneNotify();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListTableAdapter = new MissionPlanner.PartDroneNotifyTableAdapters.DeviceListTableAdapter();
            this.afterFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Noti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDroneNotify)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterFlightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flightLogTableAdapter
            // 
            this.flightLogTableAdapter.ClearBeforeFill = true;
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 735);
            this.panel1.TabIndex = 2;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.But_exit);
            this.panel_Main_farm.Controls.Add(this.DG_Noti);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(736, 735);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
            // 
            // But_exit
            // 
            this.But_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_exit.FlatAppearance.BorderSize = 0;
            this.But_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_exit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_exit.ForeColor = System.Drawing.Color.White;
            this.But_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_exit.Location = new System.Drawing.Point(250, 655);
            this.But_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_exit.Name = "But_exit";
            this.But_exit.Size = new System.Drawing.Size(195, 62);
            this.But_exit.TabIndex = 10;
            this.But_exit.Text = "รับทราบ";
            this.But_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_exit.UseVisualStyleBackColor = false;
            this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
            // 
            // DG_Noti
            // 
            this.DG_Noti.AutoGenerateColumns = false;
            this.DG_Noti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Noti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Noti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device_id,
            this.device_name,
            this.device_position,
            this.device_alarm});
            this.DG_Noti.DataSource = this.deviceListBindingSource;
            this.DG_Noti.Location = new System.Drawing.Point(38, 115);
            this.DG_Noti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DG_Noti.Name = "DG_Noti";
            this.DG_Noti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Noti.Size = new System.Drawing.Size(668, 512);
            this.DG_Noti.TabIndex = 9;
            // 
            // deviceListBindingSource
            // 
            this.deviceListBindingSource.DataMember = "DeviceList";
            this.deviceListBindingSource.DataSource = this.partDroneNotify;
            // 
            // partDroneNotify
            // 
            this.partDroneNotify.DataSetName = "PartDroneNotify";
            this.partDroneNotify.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 77);
            this.panel3.TabIndex = 0;
            // 
            // Main_but_farm
            // 
            this.Main_but_farm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.Main_but_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_but_farm.FlatAppearance.BorderSize = 0;
            this.Main_but_farm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_but_farm.Font = new System.Drawing.Font("PJ Standard", 18F, System.Drawing.FontStyle.Bold);
            this.Main_but_farm.ForeColor = System.Drawing.Color.White;
            this.Main_but_farm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_but_farm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Main_but_farm.Location = new System.Drawing.Point(0, 0);
            this.Main_but_farm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_but_farm.Name = "Main_but_farm";
            this.Main_but_farm.Size = new System.Drawing.Size(736, 77);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "แจ้งเตือนชิ้นส่วนการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // flightLogBindingSource
            // 
            this.flightLogBindingSource.DataMember = "FlightLog";
            this.flightLogBindingSource.DataSource = this.flightLog;
            // 
            // flightLog
            // 
            this.flightLog.DataSetName = "FlightLog";
            this.flightLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightSchedule2
            // 
            this.flightSchedule2.DataSetName = "FlightSchedule2";
            this.flightSchedule2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource.DataSource = this.flightSchedule2;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // afterFlightBindingSource
            // 
            this.afterFlightBindingSource.DataMember = "AfterFlight";
            // 
            // device_id
            // 
            this.device_id.DataPropertyName = "device_id";
            this.device_id.HeaderText = "รหัสชิ้นส่วนโดรน";
            this.device_id.Name = "device_id";
            // 
            // device_name
            // 
            this.device_name.DataPropertyName = "device_name";
            this.device_name.HeaderText = "ชื่อชิ้นส่วนโดรน";
            this.device_name.Name = "device_name";
            // 
            // device_position
            // 
            this.device_position.DataPropertyName = "device_position";
            this.device_position.HeaderText = "ตำแหน่งชิ้นส่วนโดรน";
            this.device_position.Name = "device_position";
            // 
            // device_alarm
            // 
            this.device_alarm.DataPropertyName = "device_alarm";
            this.device_alarm.HeaderText = "การแจ้งเตือน";
            this.device_alarm.Name = "device_alarm";
            // 
            // Form_Notify_drone_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 735);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Notify_drone_part";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notify Drone Part";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Notify_drone_part_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Notify_drone_part_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Noti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDroneNotify)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterFlightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FlightLogTableAdapters.FlightLogTableAdapter flightLogTableAdapter;
        private FlightSchedule2TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Noti;
        private System.Windows.Forms.BindingSource flightLogBindingSource;
        private MissionPlanner.FlightLog flightLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private FlightSchedule2 flightSchedule2;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private PartDroneNotify partDroneNotify;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private PartDroneNotifyTableAdapters.DeviceListTableAdapter deviceListTableAdapter;
        private System.Windows.Forms.Button But_exit;
        //private DroneFlightPlannerDataSet6 droneFlightPlannerDataSet6;
        private System.Windows.Forms.BindingSource afterFlightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_alarm;
    }
}