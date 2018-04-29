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
            this.DG_Noti = new MissionPlanner.Controls.MyDataGridView();
            this.device_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partDroneNotify = new MissionPlanner.PartDroneNotify();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListTableAdapter = new MissionPlanner.PartDroneNotifyTableAdapters.DeviceListTableAdapter();
            this.deviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicepositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicebuyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceexpDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicestartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceresponderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicepicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.devicealarmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venderaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venderphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.But_exit = new System.Windows.Forms.Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 478);
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
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(491, 478);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
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
            this.device_alarm,
            this.deviceidDataGridViewTextBoxColumn,
            this.devicenameDataGridViewTextBoxColumn,
            this.devicepositionDataGridViewTextBoxColumn,
            this.devicepriceDataGridViewTextBoxColumn,
            this.devicebuyDateDataGridViewTextBoxColumn,
            this.deviceexpDateDataGridViewTextBoxColumn,
            this.devicestartDateDataGridViewTextBoxColumn,
            this.deviceresponderDataGridViewTextBoxColumn,
            this.devicepicDataGridViewImageColumn,
            this.devicealarmDataGridViewTextBoxColumn,
            this.vendernameDataGridViewTextBoxColumn,
            this.venderaddDataGridViewTextBoxColumn,
            this.venderphoneDataGridViewTextBoxColumn,
            this.droneidDataGridViewTextBoxColumn});
            this.DG_Noti.DataSource = this.deviceListBindingSource;
            this.DG_Noti.Location = new System.Drawing.Point(25, 75);
            this.DG_Noti.Name = "DG_Noti";
            this.DG_Noti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Noti.Size = new System.Drawing.Size(445, 333);
            this.DG_Noti.TabIndex = 9;
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 50);
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
            this.Main_but_farm.Name = "Main_but_farm";
            this.Main_but_farm.Size = new System.Drawing.Size(491, 50);
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
            // deviceidDataGridViewTextBoxColumn
            // 
            this.deviceidDataGridViewTextBoxColumn.DataPropertyName = "device_id";
            this.deviceidDataGridViewTextBoxColumn.HeaderText = "device_id";
            this.deviceidDataGridViewTextBoxColumn.Name = "deviceidDataGridViewTextBoxColumn";
            // 
            // devicenameDataGridViewTextBoxColumn
            // 
            this.devicenameDataGridViewTextBoxColumn.DataPropertyName = "device_name";
            this.devicenameDataGridViewTextBoxColumn.HeaderText = "device_name";
            this.devicenameDataGridViewTextBoxColumn.Name = "devicenameDataGridViewTextBoxColumn";
            // 
            // devicepositionDataGridViewTextBoxColumn
            // 
            this.devicepositionDataGridViewTextBoxColumn.DataPropertyName = "device_position";
            this.devicepositionDataGridViewTextBoxColumn.HeaderText = "device_position";
            this.devicepositionDataGridViewTextBoxColumn.Name = "devicepositionDataGridViewTextBoxColumn";
            // 
            // devicepriceDataGridViewTextBoxColumn
            // 
            this.devicepriceDataGridViewTextBoxColumn.DataPropertyName = "device_price";
            this.devicepriceDataGridViewTextBoxColumn.HeaderText = "device_price";
            this.devicepriceDataGridViewTextBoxColumn.Name = "devicepriceDataGridViewTextBoxColumn";
            // 
            // devicebuyDateDataGridViewTextBoxColumn
            // 
            this.devicebuyDateDataGridViewTextBoxColumn.DataPropertyName = "device_buyDate";
            this.devicebuyDateDataGridViewTextBoxColumn.HeaderText = "device_buyDate";
            this.devicebuyDateDataGridViewTextBoxColumn.Name = "devicebuyDateDataGridViewTextBoxColumn";
            // 
            // deviceexpDateDataGridViewTextBoxColumn
            // 
            this.deviceexpDateDataGridViewTextBoxColumn.DataPropertyName = "device_expDate";
            this.deviceexpDateDataGridViewTextBoxColumn.HeaderText = "device_expDate";
            this.deviceexpDateDataGridViewTextBoxColumn.Name = "deviceexpDateDataGridViewTextBoxColumn";
            // 
            // devicestartDateDataGridViewTextBoxColumn
            // 
            this.devicestartDateDataGridViewTextBoxColumn.DataPropertyName = "device_startDate";
            this.devicestartDateDataGridViewTextBoxColumn.HeaderText = "device_startDate";
            this.devicestartDateDataGridViewTextBoxColumn.Name = "devicestartDateDataGridViewTextBoxColumn";
            // 
            // deviceresponderDataGridViewTextBoxColumn
            // 
            this.deviceresponderDataGridViewTextBoxColumn.DataPropertyName = "device_responder";
            this.deviceresponderDataGridViewTextBoxColumn.HeaderText = "device_responder";
            this.deviceresponderDataGridViewTextBoxColumn.Name = "deviceresponderDataGridViewTextBoxColumn";
            // 
            // devicepicDataGridViewImageColumn
            // 
            this.devicepicDataGridViewImageColumn.DataPropertyName = "device_pic";
            this.devicepicDataGridViewImageColumn.HeaderText = "device_pic";
            this.devicepicDataGridViewImageColumn.Name = "devicepicDataGridViewImageColumn";
            // 
            // devicealarmDataGridViewTextBoxColumn
            // 
            this.devicealarmDataGridViewTextBoxColumn.DataPropertyName = "device_alarm";
            this.devicealarmDataGridViewTextBoxColumn.HeaderText = "device_alarm";
            this.devicealarmDataGridViewTextBoxColumn.Name = "devicealarmDataGridViewTextBoxColumn";
            // 
            // vendernameDataGridViewTextBoxColumn
            // 
            this.vendernameDataGridViewTextBoxColumn.DataPropertyName = "vender_name";
            this.vendernameDataGridViewTextBoxColumn.HeaderText = "vender_name";
            this.vendernameDataGridViewTextBoxColumn.Name = "vendernameDataGridViewTextBoxColumn";
            // 
            // venderaddDataGridViewTextBoxColumn
            // 
            this.venderaddDataGridViewTextBoxColumn.DataPropertyName = "vender_add";
            this.venderaddDataGridViewTextBoxColumn.HeaderText = "vender_add";
            this.venderaddDataGridViewTextBoxColumn.Name = "venderaddDataGridViewTextBoxColumn";
            // 
            // venderphoneDataGridViewTextBoxColumn
            // 
            this.venderphoneDataGridViewTextBoxColumn.DataPropertyName = "vender_phone";
            this.venderphoneDataGridViewTextBoxColumn.HeaderText = "vender_phone";
            this.venderphoneDataGridViewTextBoxColumn.Name = "venderphoneDataGridViewTextBoxColumn";
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "drone_id";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
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
            this.But_exit.Location = new System.Drawing.Point(167, 426);
            this.But_exit.Name = "But_exit";
            this.But_exit.Size = new System.Drawing.Size(130, 40);
            this.But_exit.TabIndex = 10;
            this.But_exit.Text = "รับทราบ";
            this.But_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_exit.UseVisualStyleBackColor = false;
            this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
            // 
            // Form_Notify_drone_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 478);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Notify_drone_part";
            this.Text = "Notify Drone Part";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn device_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_alarm;
        private System.Windows.Forms.Button But_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicepositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicebuyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceexpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicestartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceresponderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn devicepicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicealarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
    }
}