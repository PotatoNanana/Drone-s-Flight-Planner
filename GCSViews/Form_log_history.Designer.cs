namespace MissionPlanner.GCSViews
{
    partial class Form_log_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log_history));
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.But_print = new System.Windows.Forms.Button();
            this.DG_Flight = new MissionPlanner.Controls.MyDataGridView();
            this.transactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet7 = new MissionPlanner.DroneFlightPlannerDataSet7();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.flightLogTableAdapter = new MissionPlanner.FlightLogTableAdapters.FlightLogTableAdapter();
            this.transactTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet7TableAdapters.TransactTableAdapter();
            this.transaction_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.But_print);
            this.panel_Main_farm.Controls.Add(this.DG_Flight);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1176, 731);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
            // 
            // But_print
            // 
            this.But_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_print.FlatAppearance.BorderSize = 0;
            this.But_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_print.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_print.ForeColor = System.Drawing.Color.White;
            this.But_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_print.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_print.Location = new System.Drawing.Point(490, 651);
            this.But_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_print.Name = "But_print";
            this.But_print.Size = new System.Drawing.Size(195, 62);
            this.But_print.TabIndex = 11;
            this.But_print.Text = "พิมพ์รายงาน";
            this.But_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_print.UseVisualStyleBackColor = false;
            this.But_print.Click += new System.EventHandler(this.But_print_Click);
            // 
            // DG_Flight
            // 
            this.DG_Flight.AutoGenerateColumns = false;
            this.DG_Flight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Flight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transaction_datetime,
            this.farm_name,
            this.farm_location,
            this.drone_name,
            this.action_name,
            this.action_capacity,
            this.distance,
            this.area});
            this.DG_Flight.DataSource = this.transactBindingSource;
            this.DG_Flight.Location = new System.Drawing.Point(38, 115);
            this.DG_Flight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DG_Flight.Name = "DG_Flight";
            this.DG_Flight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Flight.Size = new System.Drawing.Size(1102, 512);
            this.DG_Flight.TabIndex = 9;
            this.DG_Flight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Flight_CellContentClick);
            // 
            // transactBindingSource
            // 
            this.transactBindingSource.DataMember = "Transact";
            this.transactBindingSource.DataSource = this.droneFlightPlannerDataSet7;
            // 
            // droneFlightPlannerDataSet7
            // 
            this.droneFlightPlannerDataSet7.DataSetName = "DroneFlightPlannerDataSet7";
            this.droneFlightPlannerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 77);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1176, 77);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางประวัติการบินโดรน";
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
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource.DataSource = this.flightSchedule2;
            // 
            // flightSchedule2
            // 
            this.flightSchedule2.DataSetName = "FlightSchedule2";
            this.flightSchedule2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 731);
            this.panel1.TabIndex = 1;
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // flightLogTableAdapter
            // 
            this.flightLogTableAdapter.ClearBeforeFill = true;
            // 
            // transactTableAdapter
            // 
            this.transactTableAdapter.ClearBeforeFill = true;
            // 
            // transaction_datetime
            // 
            this.transaction_datetime.DataPropertyName = "transaction_datetime";
            this.transaction_datetime.HeaderText = "รหัสประวัติการบิน";
            this.transaction_datetime.Name = "transaction_datetime";
            this.transaction_datetime.Width = 120;
            // 
            // farm_name
            // 
            this.farm_name.DataPropertyName = "farm_name";
            this.farm_name.HeaderText = "ชื่อฟาร์ม";
            this.farm_name.Name = "farm_name";
            // 
            // farm_location
            // 
            this.farm_location.DataPropertyName = "farm_location";
            this.farm_location.HeaderText = "สถานที่ตั้งฟาร์ม";
            this.farm_location.Name = "farm_location";
            this.farm_location.Width = 200;
            // 
            // drone_name
            // 
            this.drone_name.DataPropertyName = "drone_name";
            this.drone_name.HeaderText = "ชื่อโดรน";
            this.drone_name.Name = "drone_name";
            // 
            // action_name
            // 
            this.action_name.DataPropertyName = "action_name";
            this.action_name.HeaderText = "ชื่อกิจกรรม";
            this.action_name.Name = "action_name";
            // 
            // action_capacity
            // 
            this.action_capacity.DataPropertyName = "action_capacity";
            this.action_capacity.HeaderText = "ปริมาณสารที่ใช้";
            this.action_capacity.Name = "action_capacity";
            // 
            // distance
            // 
            this.distance.DataPropertyName = "distance";
            this.distance.HeaderText = "ระยะทาง";
            this.distance.Name = "distance";
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "ขนาดพื้นที่";
            this.area.Name = "area";
            // 
            // droneBindingSource1
            // 
            this.droneBindingSource1.DataMember = "Drone";
            // 
            // Form_log_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 731);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_log_history";
            this.Text = "Log History";
            this.Load += new System.EventHandler(this.Form_log_history_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_log_history_KeyDown);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet7)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Flight;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private FlightSchedule2 flightSchedule2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Panel panel1;
        private FlightSchedule2TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private MissionPlanner.FlightLog flightLog;
        private System.Windows.Forms.BindingSource flightLogBindingSource;
        private FlightLogTableAdapters.FlightLogTableAdapter flightLogTableAdapter;
        private System.Windows.Forms.Button But_print;
        private DroneFlightPlannerDataSet7 droneFlightPlannerDataSet7;
        private System.Windows.Forms.BindingSource transactBindingSource;
        private DroneFlightPlannerDataSet7TableAdapters.TransactTableAdapter transactTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.BindingSource droneBindingSource1;
    }
}