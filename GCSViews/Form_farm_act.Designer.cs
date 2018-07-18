namespace MissionPlanner.GCSViews
{
    partial class Form_farm_act
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_farm_act));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.DG_afterFlight = new MissionPlanner.Controls.MyDataGridView();
            this.flightScheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._Drone_s_Flight_PlannerDataSet4 = new MissionPlanner._Drone_s_Flight_PlannerDataSet4();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.afterFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitySchedule = new MissionPlanner.ActivitySchedule();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule = new MissionPlanner.flightSchedule();
            this.scheduleactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet1 = new MissionPlanner.DroneFlightPlannerDataSet1();
            this.schedule_actionTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet1TableAdapters.schedule_actionTableAdapter();
            this.flightScheduleTableAdapter = new MissionPlanner.flightScheduleTableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleTableAdapter1 = new MissionPlanner.ActivityScheduleTableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightScheduleTableAdapter2 = new MissionPlanner._Drone_s_Flight_PlannerDataSet4TableAdapters.FlightScheduleTableAdapter();
            this.actiondatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionstartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionfinishTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_afterFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Drone_s_Flight_PlannerDataSet4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitySchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 628);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.DG_afterFlight);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1076, 628);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFarm_Act_Paint);
            // 
            // DG_afterFlight
            // 
            this.DG_afterFlight.AutoGenerateColumns = false;
            this.DG_afterFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_afterFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_afterFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actiondatetimeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.actionnameDataGridViewTextBoxColumn,
            this.materialnameDataGridViewTextBoxColumn,
            this.actioncapacityDataGridViewTextBoxColumn,
            this.actioncostDataGridViewTextBoxColumn,
            this.actionstartTimeDataGridViewTextBoxColumn,
            this.actionfinishTimeDataGridViewTextBoxColumn});
            this.DG_afterFlight.DataSource = this.flightScheduleBindingSource2;
            this.DG_afterFlight.Location = new System.Drawing.Point(35, 109);
            this.DG_afterFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DG_afterFlight.Name = "DG_afterFlight";
            this.DG_afterFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_afterFlight.Size = new System.Drawing.Size(1018, 485);
            this.DG_afterFlight.TabIndex = 9;
            this.DG_afterFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            // 
            // flightScheduleBindingSource2
            // 
            this.flightScheduleBindingSource2.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource2.DataSource = this._Drone_s_Flight_PlannerDataSet4;
            // 
            // _Drone_s_Flight_PlannerDataSet4
            // 
            this._Drone_s_Flight_PlannerDataSet4.DataSetName = "_Drone_s_Flight_PlannerDataSet4";
            this._Drone_s_Flight_PlannerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 77);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1076, 77);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางปฏิทินการบินที่ผ่านมา";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // afterFlightBindingSource
            // 
            this.afterFlightBindingSource.DataMember = "AfterFlight";
            // 
            // activitySchedule
            // 
            this.activitySchedule.DataSetName = "ActivitySchedule";
            this.activitySchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource.DataSource = this.flightSchedule;
            // 
            // flightSchedule
            // 
            this.flightSchedule.DataSetName = "flightSchedule";
            this.flightSchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleactionBindingSource
            // 
            this.scheduleactionBindingSource.DataMember = "schedule_action";
            this.scheduleactionBindingSource.DataSource = this.droneFlightPlannerDataSet1;
            // 
            // droneFlightPlannerDataSet1
            // 
            this.droneFlightPlannerDataSet1.DataSetName = "DroneFlightPlannerDataSet1";
            this.droneFlightPlannerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schedule_actionTableAdapter
            // 
            this.schedule_actionTableAdapter.ClearBeforeFill = true;
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // flightScheduleTableAdapter1
            // 
            this.flightScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // flightScheduleBindingSource1
            // 
            this.flightScheduleBindingSource1.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource1.DataSource = this.activitySchedule;
            // 
            // flightScheduleTableAdapter2
            // 
            this.flightScheduleTableAdapter2.ClearBeforeFill = true;
            // 
            // actiondatetimeDataGridViewTextBoxColumn
            // 
            this.actiondatetimeDataGridViewTextBoxColumn.DataPropertyName = "action_datetime";
            this.actiondatetimeDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.actiondatetimeDataGridViewTextBoxColumn.Name = "actiondatetimeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "drone_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสโดรน";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // actionnameDataGridViewTextBoxColumn
            // 
            this.actionnameDataGridViewTextBoxColumn.DataPropertyName = "action_name";
            this.actionnameDataGridViewTextBoxColumn.HeaderText = "ชื่อกิจกรรม";
            this.actionnameDataGridViewTextBoxColumn.Name = "actionnameDataGridViewTextBoxColumn";
            // 
            // materialnameDataGridViewTextBoxColumn
            // 
            this.materialnameDataGridViewTextBoxColumn.DataPropertyName = "material_name";
            this.materialnameDataGridViewTextBoxColumn.HeaderText = "วัตถุดิบ";
            this.materialnameDataGridViewTextBoxColumn.Name = "materialnameDataGridViewTextBoxColumn";
            // 
            // actioncapacityDataGridViewTextBoxColumn
            // 
            this.actioncapacityDataGridViewTextBoxColumn.DataPropertyName = "action_capacity";
            this.actioncapacityDataGridViewTextBoxColumn.HeaderText = "ปริมาณสาร";
            this.actioncapacityDataGridViewTextBoxColumn.Name = "actioncapacityDataGridViewTextBoxColumn";
            // 
            // actioncostDataGridViewTextBoxColumn
            // 
            this.actioncostDataGridViewTextBoxColumn.DataPropertyName = "action_cost";
            this.actioncostDataGridViewTextBoxColumn.HeaderText = "ค่าใช้จ่าย";
            this.actioncostDataGridViewTextBoxColumn.Name = "actioncostDataGridViewTextBoxColumn";
            // 
            // actionstartTimeDataGridViewTextBoxColumn
            // 
            this.actionstartTimeDataGridViewTextBoxColumn.DataPropertyName = "action_startTime";
            this.actionstartTimeDataGridViewTextBoxColumn.HeaderText = "เวลาเริ่ม";
            this.actionstartTimeDataGridViewTextBoxColumn.Name = "actionstartTimeDataGridViewTextBoxColumn";
            // 
            // actionfinishTimeDataGridViewTextBoxColumn
            // 
            this.actionfinishTimeDataGridViewTextBoxColumn.DataPropertyName = "action_finishTime";
            this.actionfinishTimeDataGridViewTextBoxColumn.HeaderText = "เวลาสิ้นสุด";
            this.actionfinishTimeDataGridViewTextBoxColumn.Name = "actionfinishTimeDataGridViewTextBoxColumn";
            // 
            // Form_farm_act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 628);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_farm_act";
            this.Text = "Flight Schedule";
            this.Load += new System.EventHandler(this.Form_farm_act_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_farm_act_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_afterFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Drone_s_Flight_PlannerDataSet4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afterFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitySchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_afterFlight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private DroneFlightPlannerDataSet1 droneFlightPlannerDataSet1;
        private System.Windows.Forms.BindingSource scheduleactionBindingSource;
        private DroneFlightPlannerDataSet1TableAdapters.schedule_actionTableAdapter schedule_actionTableAdapter;
        private flightSchedule flightSchedule;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private flightScheduleTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private ActivitySchedule activitySchedule;
        private ActivityScheduleTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter1;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource1;
        //private DroneFlightPlannerDataSet7 droneFlightPlannerDataSet7;
        private System.Windows.Forms.BindingSource afterFlightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn afnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afcapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afstartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affinishTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmidDataGridViewTextBoxColumn;
        private _Drone_s_Flight_PlannerDataSet4 _Drone_s_Flight_PlannerDataSet4;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource2;
        private _Drone_s_Flight_PlannerDataSet4TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiondatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionstartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionfinishTimeDataGridViewTextBoxColumn;
    }
}