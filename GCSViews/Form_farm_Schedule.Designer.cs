namespace MissionPlanner.GCSViews
{
    partial class Form_farm_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_farm_Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_finishTime = new System.Windows.Forms.TextBox();
            this.textBox_startTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_droneID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.textBox_cap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_actName = new System.Windows.Forms.TextBox();
            this.textBox_actID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.actiondatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_finishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet5 = new MissionPlanner.DroneFlightPlannerDataSet5();
            this.But_add_act = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleTableAdapter1 = new MissionPlanner.DroneFlightPlannerDataSet5TableAdapters.FlightScheduleTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flightScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet5 = new MissionPlanner.DroneFlightPlannerDataSet5();
            this.But_add_act = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleTableAdapter1 = new MissionPlanner.DroneFlightPlannerDataSet5TableAdapters.FlightScheduleTableAdapter();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 578);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.button1);
            this.panel_Main_farm.Controls.Add(this.textBox_finishTime);
            this.panel_Main_farm.Controls.Add(this.textBox_startTime);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.textBox_droneID);
            this.panel_Main_farm.Controls.Add(this.label7);
            this.panel_Main_farm.Controls.Add(this.textBox_cost);
            this.panel_Main_farm.Controls.Add(this.textBox_cap);
            this.panel_Main_farm.Controls.Add(this.label6);
            this.panel_Main_farm.Controls.Add(this.label5);
            this.panel_Main_farm.Controls.Add(this.textBox_actName);
            this.panel_Main_farm.Controls.Add(this.textBox_actID);
            this.panel_Main_farm.Controls.Add(this.label3);
            this.panel_Main_farm.Controls.Add(this.label4);
            this.panel_Main_farm.Controls.Add(this.monthCalendar1);
            this.panel_Main_farm.Controls.Add(this.pictureBox1);
            this.panel_Main_farm.Controls.Add(this.button_edit);
            this.panel_Main_farm.Controls.Add(this.button_delete);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.But_add_act);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(968, 578);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFarm_schedule_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(773, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "พิมพ์";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox_finishTime
            // 
            this.textBox_finishTime.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_finishTime.Location = new System.Drawing.Point(646, 506);
            this.textBox_finishTime.Name = "textBox_finishTime";
            this.textBox_finishTime.Size = new System.Drawing.Size(93, 34);
            this.textBox_finishTime.TabIndex = 53;
            // 
            // textBox_startTime
            // 
            this.textBox_startTime.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_startTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_startTime.Location = new System.Drawing.Point(460, 506);
            this.textBox_startTime.Name = "textBox_startTime";
            this.textBox_startTime.ShortcutsEnabled = false;
            this.textBox_startTime.Size = new System.Drawing.Size(93, 34);
            this.textBox_startTime.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label2.Location = new System.Drawing.Point(561, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "เวลาที่เสร็จ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label1.Location = new System.Drawing.Point(383, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "เวลาที่เริ่ม";
            // 
            // textBox_droneID
            // 
            this.textBox_droneID.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_droneID.Location = new System.Drawing.Point(163, 387);
            this.textBox_droneID.Name = "textBox_droneID";
            this.textBox_droneID.Size = new System.Drawing.Size(187, 34);
            this.textBox_droneID.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label7.Location = new System.Drawing.Point(47, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 48;
            this.label7.Text = "รหัสโดรน";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_cost.Location = new System.Drawing.Point(491, 448);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(187, 34);
            this.textBox_cost.TabIndex = 46;
            // 
            // textBox_cap
            // 
            this.textBox_cap.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_cap.Location = new System.Drawing.Point(491, 386);
            this.textBox_cap.Name = "textBox_cap";
            this.textBox_cap.Size = new System.Drawing.Size(187, 34);
            this.textBox_cap.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label6.Location = new System.Drawing.Point(375, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "ปริมาณสาร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label5.Location = new System.Drawing.Point(375, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 27);
            this.label5.TabIndex = 45;
            this.label5.Text = "ค่าใช้จ่าย";
            // 
            // textBox_actName
            // 
            this.textBox_actName.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_actName.Location = new System.Drawing.Point(165, 510);
            this.textBox_actName.Name = "textBox_actName";
            this.textBox_actName.Size = new System.Drawing.Size(187, 34);
            this.textBox_actName.TabIndex = 43;
            // 
            // textBox_actID
            // 
            this.textBox_actID.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_actID.Location = new System.Drawing.Point(163, 445);
            this.textBox_actID.Name = "textBox_actID";
            this.textBox_actID.Size = new System.Drawing.Size(187, 34);
            this.textBox_actID.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label3.Location = new System.Drawing.Point(49, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "ชื่อกิจกรรม";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label4.Location = new System.Drawing.Point(47, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "รหัสกิจกรรม";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(71, 164);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MissionPlanner.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(36, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_edit.Location = new System.Drawing.Point(773, 417);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(130, 40);
            this.button_edit.TabIndex = 25;
            this.button_edit.Text = "แก้ไข";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_delete.Location = new System.Drawing.Point(773, 470);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(130, 40);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = "ลบ";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actiondatetimeDataGridViewTextBoxColumn,
            this.droneidDataGridViewTextBoxColumn,
            this.actionnoDataGridViewTextBoxColumn,
            this.actionnameDataGridViewTextBoxColumn,
            this.actioncapacityDataGridViewTextBoxColumn,
            this.actioncostDataGridViewTextBoxColumn,
            this.action_startTime,
            this.action_finishTime});
            this.DG_Farm.DataSource = this.flightScheduleBindingSource1;
            this.DG_Farm.Location = new System.Drawing.Point(511, 94);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(429, 257);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            // 
            // actiondatetimeDataGridViewTextBoxColumn
            // 
            this.actiondatetimeDataGridViewTextBoxColumn.DataPropertyName = "action_datetime";
            this.actiondatetimeDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.actiondatetimeDataGridViewTextBoxColumn.Name = "actiondatetimeDataGridViewTextBoxColumn";
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
            // 
            // actionnameDataGridViewTextBoxColumn
            // 
            this.actionnameDataGridViewTextBoxColumn.DataPropertyName = "action_name";
            this.actionnameDataGridViewTextBoxColumn.HeaderText = "ชื่อกิจกรรม";
            this.actionnameDataGridViewTextBoxColumn.Name = "actionnameDataGridViewTextBoxColumn";
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
            // action_startTime
            // 
            this.action_startTime.DataPropertyName = "action_startTime";
            this.action_startTime.HeaderText = "เวลาเริ่มต้น";
            this.action_startTime.Name = "action_startTime";
            // 
            // action_finishTime
            // 
            this.action_finishTime.DataPropertyName = "action_finishTime";
            this.action_finishTime.HeaderText = "เวลาสิ้นสุด";
            this.action_finishTime.Name = "action_finishTime";
            // 
            // flightScheduleBindingSource1
            // 
            this.flightScheduleBindingSource1.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource1.DataSource = this.droneFlightPlannerDataSet5;
            // 
            // droneFlightPlannerDataSet5
            // 
            this.droneFlightPlannerDataSet5.DataSetName = "DroneFlightPlannerDataSet5";
            this.droneFlightPlannerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // But_add_act
            // 
            this.But_add_act.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_add_act.FlatAppearance.BorderSize = 0;
            this.But_add_act.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_add_act.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_add_act.ForeColor = System.Drawing.Color.White;
            this.But_add_act.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_add_act.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_add_act.Location = new System.Drawing.Point(773, 364);
            this.But_add_act.Name = "But_add_act";
            this.But_add_act.Size = new System.Drawing.Size(130, 40);
            this.But_add_act.TabIndex = 6;
            this.But_add_act.Text = "เพิ่มกิจกรรม";
            this.But_add_act.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_add_act.UseVisualStyleBackColor = false;
            this.But_add_act.Click += new System.EventHandler(this.But_add_act_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(968, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางปฏิทินการบินที่กำลังจะเกิด";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
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
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // flightScheduleTableAdapter1
            // 
            this.flightScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // actiondatetimeDataGridViewTextBoxColumn
            // 
            this.actiondatetimeDataGridViewTextBoxColumn.DataPropertyName = "action_datetime";
            this.actiondatetimeDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.actiondatetimeDataGridViewTextBoxColumn.Name = "actiondatetimeDataGridViewTextBoxColumn";
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
            // 
            // actionnameDataGridViewTextBoxColumn
            // 
            this.actionnameDataGridViewTextBoxColumn.DataPropertyName = "action_name";
            this.actionnameDataGridViewTextBoxColumn.HeaderText = "ชื่อกิจกรรม";
            this.actionnameDataGridViewTextBoxColumn.Name = "actionnameDataGridViewTextBoxColumn";
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
            // action_startTime
            // 
            this.action_startTime.DataPropertyName = "action_startTime";
            this.action_startTime.HeaderText = "เวลาเริ่มต้น";
            this.action_startTime.Name = "action_startTime";
            // 
            // action_finishTime
            // 
            this.action_finishTime.DataPropertyName = "action_finishTime";
            this.action_finishTime.HeaderText = "เวลาสิ้นสุด";
            this.action_finishTime.Name = "action_finishTime";
            // 
            // Form_farm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 578);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_farm_Schedule";
            this.Text = "Flight Schedule";
            this.Load += new System.EventHandler(this.Form_farm_Schedule_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_farm_Schedule_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button But_add_act;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private FlightSchedule2 flightSchedule2;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private FlightSchedule2TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox_droneID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.TextBox textBox_cap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_actName;
        private System.Windows.Forms.TextBox textBox_actID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_finishTime;
        private System.Windows.Forms.TextBox textBox_startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DroneFlightPlannerDataSet5 droneFlightPlannerDataSet5;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource1;
        private DroneFlightPlannerDataSet5TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiondatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_finishTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}