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
<<<<<<< HEAD
            this.log_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern_mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
||||||| merged common ancestors
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
=======
            this.transactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet7 = new MissionPlanner.DroneFlightPlannerDataSet7();
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.flightLogTableAdapter = new MissionPlanner.FlightLogTableAdapters.FlightLogTableAdapter();
<<<<<<< HEAD
            this.lognoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logdatetimeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.actionnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternmaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
||||||| merged common ancestors
            this.log_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern_mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.transactTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet7TableAdapters.TransactTableAdapter();
            this.transaction_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
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
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(784, 475);
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
            this.But_print.Location = new System.Drawing.Point(327, 423);
            this.But_print.Name = "But_print";
            this.But_print.Size = new System.Drawing.Size(130, 40);
            this.But_print.TabIndex = 11;
            this.But_print.Text = "พิมพ์";
            this.But_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_print.UseVisualStyleBackColor = false;
            // 
            // DG_Flight
            // 
            this.DG_Flight.AutoGenerateColumns = false;
            this.DG_Flight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Flight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
<<<<<<< HEAD
            this.log_no,
            this.log_datetime,
            this.action_no,
            this.farm_id,
            this.drone_id,
            this.pattern_name,
            this.pattern_mask,
            this.lognoDataGridViewTextBoxColumn,
            this.logdatetimeDataGridViewImageColumn,
            this.actionnoDataGridViewTextBoxColumn,
            this.farmidDataGridViewTextBoxColumn,
            this.droneidDataGridViewTextBoxColumn,
            this.patternnameDataGridViewTextBoxColumn,
            this.patternmaskDataGridViewTextBoxColumn});
            this.DG_Flight.DataSource = this.flightLogBindingSource;
||||||| merged common ancestors
            this.log_no,
            this.log_datetime,
            this.action_no,
            this.farm_id,
            this.drone_id,
            this.pattern_name,
            this.pattern_mask});
            this.DG_Flight.DataSource = this.flightLogBindingSource;
=======
            this.transaction_datetime,
            this.farm_name,
            this.farm_location,
            this.drone_name,
            this.action_name,
            this.action_capacity,
            this.distance,
            this.area});
            this.DG_Flight.DataSource = this.transactBindingSource;
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            this.DG_Flight.Location = new System.Drawing.Point(25, 75);
            this.DG_Flight.Name = "DG_Flight";
            this.DG_Flight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Flight.Size = new System.Drawing.Size(735, 333);
            this.DG_Flight.TabIndex = 9;
            this.DG_Flight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Flight_CellContentClick);
            // 
            // log_no
            // 
            this.log_no.DataPropertyName = "log_no";
            this.log_no.HeaderText = "รหัสประวัติการบิน";
            this.log_no.Name = "log_no";
            // 
            // log_datetime
            // 
            this.log_datetime.DataPropertyName = "log_datetime";
            this.log_datetime.HeaderText = "วันที่";
            this.log_datetime.Name = "log_datetime";
            this.log_datetime.ReadOnly = true;
            // 
            // action_no
            // 
            this.action_no.DataPropertyName = "action_no";
            this.action_no.HeaderText = "รหัสกิจกรรม";
            this.action_no.Name = "action_no";
            // 
            // farm_id
            // 
            this.farm_id.DataPropertyName = "farm_id";
            this.farm_id.HeaderText = "รหัสฟาร์ม";
            this.farm_id.Name = "farm_id";
            // 
            // drone_id
            // 
            this.drone_id.DataPropertyName = "drone_id";
            this.drone_id.HeaderText = "รหัสโดรน";
            this.drone_id.Name = "drone_id";
            // 
            // pattern_name
            // 
            this.pattern_name.DataPropertyName = "pattern_name";
            this.pattern_name.HeaderText = "รูปแบบการบิน";
            this.pattern_name.Name = "pattern_name";
            // 
            // pattern_mask
            // 
            this.pattern_mask.DataPropertyName = "pattern_mask";
            this.pattern_mask.HeaderText = "หมายเหตุ";
            this.pattern_mask.Name = "pattern_mask";
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(784, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางบันทึกผลการบิน";
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 475);
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
<<<<<<< HEAD
            // lognoDataGridViewTextBoxColumn
||||||| merged common ancestors
            // log_no
=======
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
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.lognoDataGridViewTextBoxColumn.DataPropertyName = "log_no";
            this.lognoDataGridViewTextBoxColumn.HeaderText = "log_no";
            this.lognoDataGridViewTextBoxColumn.Name = "lognoDataGridViewTextBoxColumn";
||||||| merged common ancestors
            this.log_no.DataPropertyName = "log_no";
            this.log_no.HeaderText = "รหัสประวัติการบิน";
            this.log_no.Name = "log_no";
=======
            // farm_name
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            // logdatetimeDataGridViewImageColumn
||||||| merged common ancestors
            // log_datetime
=======
            this.farm_name.DataPropertyName = "farm_name";
            this.farm_name.HeaderText = "ชื่อฟาร์ม";
            this.farm_name.Name = "farm_name";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.logdatetimeDataGridViewImageColumn.DataPropertyName = "log_datetime";
            this.logdatetimeDataGridViewImageColumn.HeaderText = "log_datetime";
            this.logdatetimeDataGridViewImageColumn.Name = "logdatetimeDataGridViewImageColumn";
            this.logdatetimeDataGridViewImageColumn.ReadOnly = true;
||||||| merged common ancestors
            this.log_datetime.DataPropertyName = "log_datetime";
            this.log_datetime.HeaderText = "วันที่";
            this.log_datetime.Name = "log_datetime";
            this.log_datetime.ReadOnly = true;
=======
            // farm_location
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            // actionnoDataGridViewTextBoxColumn
||||||| merged common ancestors
            // action_no
=======
            this.farm_location.DataPropertyName = "farm_location";
            this.farm_location.HeaderText = "สถานที่ตั้งฟาร์ม";
            this.farm_location.Name = "farm_location";
            this.farm_location.Width = 200;
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.actionnoDataGridViewTextBoxColumn.DataPropertyName = "action_no";
            this.actionnoDataGridViewTextBoxColumn.HeaderText = "action_no";
            this.actionnoDataGridViewTextBoxColumn.Name = "actionnoDataGridViewTextBoxColumn";
||||||| merged common ancestors
            this.action_no.DataPropertyName = "action_no";
            this.action_no.HeaderText = "รหัสกิจกรรม";
            this.action_no.Name = "action_no";
=======
            // drone_name
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            // farmidDataGridViewTextBoxColumn
||||||| merged common ancestors
            // farm_id
=======
            this.drone_name.DataPropertyName = "drone_name";
            this.drone_name.HeaderText = "ชื่อโดรน";
            this.drone_name.Name = "drone_name";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.farmidDataGridViewTextBoxColumn.DataPropertyName = "farm_id";
            this.farmidDataGridViewTextBoxColumn.HeaderText = "farm_id";
            this.farmidDataGridViewTextBoxColumn.Name = "farmidDataGridViewTextBoxColumn";
||||||| merged common ancestors
            this.farm_id.DataPropertyName = "farm_id";
            this.farm_id.HeaderText = "รหัสฟาร์ม";
            this.farm_id.Name = "farm_id";
=======
            // action_name
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            // droneidDataGridViewTextBoxColumn
||||||| merged common ancestors
            // drone_id
=======
            this.action_name.DataPropertyName = "action_name";
            this.action_name.HeaderText = "ชื่อกิจกรรม";
            this.action_name.Name = "action_name";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "drone_id";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
||||||| merged common ancestors
            this.drone_id.DataPropertyName = "drone_id";
            this.drone_id.HeaderText = "รหัสโดรน";
            this.drone_id.Name = "drone_id";
=======
            // action_capacity
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            // patternnameDataGridViewTextBoxColumn
||||||| merged common ancestors
            // pattern_name
=======
            this.action_capacity.DataPropertyName = "action_capacity";
            this.action_capacity.HeaderText = "ปริมาณสารที่ใช้";
            this.action_capacity.Name = "action_capacity";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.patternnameDataGridViewTextBoxColumn.DataPropertyName = "pattern_name";
            this.patternnameDataGridViewTextBoxColumn.HeaderText = "pattern_name";
            this.patternnameDataGridViewTextBoxColumn.Name = "patternnameDataGridViewTextBoxColumn";
||||||| merged common ancestors
            this.pattern_name.DataPropertyName = "pattern_name";
            this.pattern_name.HeaderText = "รูปแบบการบิน";
            this.pattern_name.Name = "pattern_name";
=======
            // distance
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            // patternmaskDataGridViewTextBoxColumn
||||||| merged common ancestors
            // pattern_mask
=======
            this.distance.DataPropertyName = "distance";
            this.distance.HeaderText = "ระยะทาง";
            this.distance.Name = "distance";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
<<<<<<< HEAD
            this.patternmaskDataGridViewTextBoxColumn.DataPropertyName = "pattern_mask";
            this.patternmaskDataGridViewTextBoxColumn.HeaderText = "pattern_mask";
            this.patternmaskDataGridViewTextBoxColumn.Name = "patternmaskDataGridViewTextBoxColumn";
||||||| merged common ancestors
            this.pattern_mask.DataPropertyName = "pattern_mask";
            this.pattern_mask.HeaderText = "หมายเหตุ";
            this.pattern_mask.Name = "pattern_mask";
=======
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "ขนาดพื้นที่";
            this.area.Name = "area";
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
            // 
            // Form_log_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
<<<<<<< HEAD
        private System.Windows.Forms.DataGridViewTextBoxColumn log_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern_mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn lognoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn logdatetimeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternmaskDataGridViewTextBoxColumn;
||||||| merged common ancestors
        private System.Windows.Forms.DataGridViewTextBoxColumn log_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattern_mask;
=======
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
>>>>>>> 93d3aebc83daf45cb364e35722ab0009447cfbfc
    }
}