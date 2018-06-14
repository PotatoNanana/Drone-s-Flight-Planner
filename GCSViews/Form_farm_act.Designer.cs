﻿namespace MissionPlanner.GCSViews
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
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.action_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.activitySchedule = new MissionPlanner.ActivitySchedule();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule = new MissionPlanner.flightSchedule();
            this.scheduleactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet1 = new MissionPlanner.DroneFlightPlannerDataSet1();
            this.schedule_actionTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet1TableAdapters.schedule_actionTableAdapter();
            this.flightScheduleTableAdapter = new MissionPlanner.flightScheduleTableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleTableAdapter1 = new MissionPlanner.ActivityScheduleTableAdapters.FlightScheduleTableAdapter();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitySchedule)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 382);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(717, 382);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFarm_Act_Paint);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.action_datetime,
            this.droneidDataGridViewTextBoxColumn,
            this.actionnoDataGridViewTextBoxColumn,
            this.action_name,
            this.action_capacity,
            this.action_cost});
            this.DG_Farm.DataSource = this.flightScheduleBindingSource1;
            this.DG_Farm.Location = new System.Drawing.Point(19, 87);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(679, 280);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            // 
            // action_datetime
            // 
            this.action_datetime.DataPropertyName = "action_datetime";
            this.action_datetime.HeaderText = "วันที่";
            this.action_datetime.Name = "action_datetime";
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "รหัสโดรน";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
            // 
            // actionnoDataGridViewTextBoxColumn
            // 
            this.actionnoDataGridViewTextBoxColumn.DataPropertyName = "action_no";
            this.actionnoDataGridViewTextBoxColumn.HeaderText = "เลขที่กิจกรรม";
            this.actionnoDataGridViewTextBoxColumn.Name = "actionnoDataGridViewTextBoxColumn";
            this.actionnoDataGridViewTextBoxColumn.Width = 120;
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
            this.action_capacity.HeaderText = "ปริมาณสาร";
            this.action_capacity.Name = "action_capacity";
            // 
            // action_cost
            // 
            this.action_cost.DataPropertyName = "action_cost";
            this.action_cost.HeaderText = "ค่าใช้จ่ายในการทำกิจกรรม";
            this.action_cost.Name = "action_cost";
            this.action_cost.Width = 150;
            // 
            // flightScheduleBindingSource1
            // 
            this.flightScheduleBindingSource1.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource1.DataSource = this.activitySchedule;
            // 
            // activitySchedule
            // 
            this.activitySchedule.DataSetName = "ActivitySchedule";
            this.activitySchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(717, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางปฏิทินการบินที่ผ่านมา";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
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
            // Form_farm_act
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 382);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_farm_act";
            this.Text = "Flight Schedule";
            this.Load += new System.EventHandler(this.Form_farm_act_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_farm_act_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitySchedule)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private DroneFlightPlannerDataSet1 droneFlightPlannerDataSet1;
        private System.Windows.Forms.BindingSource scheduleactionBindingSource;
        private DroneFlightPlannerDataSet1TableAdapters.schedule_actionTableAdapter schedule_actionTableAdapter;
        private flightSchedule flightSchedule;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private flightScheduleTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private ActivitySchedule activitySchedule;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource1;
        private ActivityScheduleTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_cost;
    }
}