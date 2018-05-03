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
            this.DG_Flight = new MissionPlanner.Controls.MyDataGridView();
            this.log_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattern_mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lognoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logdatetimeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.actionnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternmaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.flightLogTableAdapter = new MissionPlanner.FlightLogTableAdapters.FlightLogTableAdapter();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.DG_Flight);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(613, 424);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
            // 
            // DG_Flight
            // 
            this.DG_Flight.AutoGenerateColumns = false;
            this.DG_Flight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Flight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_Flight.Location = new System.Drawing.Point(25, 75);
            this.DG_Flight.Name = "DG_Flight";
            this.DG_Flight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Flight.Size = new System.Drawing.Size(562, 333);
            this.DG_Flight.TabIndex = 9;
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
            // lognoDataGridViewTextBoxColumn
            // 
            this.lognoDataGridViewTextBoxColumn.DataPropertyName = "log_no";
            this.lognoDataGridViewTextBoxColumn.HeaderText = "log_no";
            this.lognoDataGridViewTextBoxColumn.Name = "lognoDataGridViewTextBoxColumn";
            // 
            // logdatetimeDataGridViewImageColumn
            // 
            this.logdatetimeDataGridViewImageColumn.DataPropertyName = "log_datetime";
            this.logdatetimeDataGridViewImageColumn.HeaderText = "log_datetime";
            this.logdatetimeDataGridViewImageColumn.Name = "logdatetimeDataGridViewImageColumn";
            this.logdatetimeDataGridViewImageColumn.ReadOnly = true;
            // 
            // actionnoDataGridViewTextBoxColumn
            // 
            this.actionnoDataGridViewTextBoxColumn.DataPropertyName = "action_no";
            this.actionnoDataGridViewTextBoxColumn.HeaderText = "action_no";
            this.actionnoDataGridViewTextBoxColumn.Name = "actionnoDataGridViewTextBoxColumn";
            // 
            // farmidDataGridViewTextBoxColumn
            // 
            this.farmidDataGridViewTextBoxColumn.DataPropertyName = "farm_id";
            this.farmidDataGridViewTextBoxColumn.HeaderText = "farm_id";
            this.farmidDataGridViewTextBoxColumn.Name = "farmidDataGridViewTextBoxColumn";
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "drone_id";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
            // 
            // patternnameDataGridViewTextBoxColumn
            // 
            this.patternnameDataGridViewTextBoxColumn.DataPropertyName = "pattern_name";
            this.patternnameDataGridViewTextBoxColumn.HeaderText = "pattern_name";
            this.patternnameDataGridViewTextBoxColumn.Name = "patternnameDataGridViewTextBoxColumn";
            // 
            // patternmaskDataGridViewTextBoxColumn
            // 
            this.patternmaskDataGridViewTextBoxColumn.DataPropertyName = "pattern_mask";
            this.patternmaskDataGridViewTextBoxColumn.HeaderText = "pattern_mask";
            this.patternmaskDataGridViewTextBoxColumn.Name = "patternmaskDataGridViewTextBoxColumn";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(613, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางบันทึกผลการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(613, 424);
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
            // Form_log_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 424);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_log_history";
            this.Text = "Log History";
            this.Load += new System.EventHandler(this.Form_log_history_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_log_history_KeyDown);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).EndInit();
            this.panel3.ResumeLayout(false);
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
    }
}