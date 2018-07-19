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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.cboDrone = new System.Windows.Forms.ComboBox();
            this.textBox_finishTime = new System.Windows.Forms.TextBox();
            this.textBox_startTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.textBox_cap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.actiondatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_finishTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.act_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.view_flightschedule = new MissionPlanner.View_flightschedule();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_flightschedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.button5);
            this.panel_Main_farm.Controls.Add(this.button4);
            this.panel_Main_farm.Controls.Add(this.button3);
            this.panel_Main_farm.Controls.Add(this.button2);
            this.panel_Main_farm.Controls.Add(this.cboMaterial);
            this.panel_Main_farm.Controls.Add(this.cboActivity);
            this.panel_Main_farm.Controls.Add(this.cboDrone);
            this.panel_Main_farm.Controls.Add(this.textBox_finishTime);
            this.panel_Main_farm.Controls.Add(this.textBox_startTime);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.label7);
            this.panel_Main_farm.Controls.Add(this.textBox_cost);
            this.panel_Main_farm.Controls.Add(this.textBox_cap);
            this.panel_Main_farm.Controls.Add(this.label6);
            this.panel_Main_farm.Controls.Add(this.label5);
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
            this.panel_Main_farm.Size = new System.Drawing.Size(984, 581);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFarm_schedule_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(361, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 40);
            this.button5.TabIndex = 60;
            this.button5.Text = "ลบ";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(361, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 40);
            this.button4.TabIndex = 59;
            this.button4.Text = "ลบ";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(310, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 40);
            this.button3.TabIndex = 58;
            this.button3.Text = "เพิ่ม";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(310, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 40);
            this.button2.TabIndex = 58;
            this.button2.Text = "เพิ่ม";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboMaterial
            // 
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(117, 513);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(187, 32);
            this.cboMaterial.TabIndex = 57;
            // 
            // cboActivity
            // 
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(117, 446);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(187, 32);
            this.cboActivity.TabIndex = 56;
            // 
            // cboDrone
            // 
            this.cboDrone.FormattingEnabled = true;
            this.cboDrone.Location = new System.Drawing.Point(117, 388);
            this.cboDrone.Name = "cboDrone";
            this.cboDrone.Size = new System.Drawing.Size(187, 32);
            this.cboDrone.TabIndex = 55;
            this.cboDrone.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_finishTime
            // 
            this.textBox_finishTime.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_finishTime.Location = new System.Drawing.Point(703, 512);
            this.textBox_finishTime.Name = "textBox_finishTime";
            this.textBox_finishTime.Size = new System.Drawing.Size(93, 34);
            this.textBox_finishTime.TabIndex = 53;
            // 
            // textBox_startTime
            // 
            this.textBox_startTime.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_startTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_startTime.Location = new System.Drawing.Point(509, 512);
            this.textBox_startTime.Name = "textBox_startTime";
            this.textBox_startTime.ShortcutsEnabled = false;
            this.textBox_startTime.Size = new System.Drawing.Size(93, 34);
            this.textBox_startTime.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label2.Location = new System.Drawing.Point(618, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "เวลาที่เสร็จ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label1.Location = new System.Drawing.Point(432, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "เวลาที่เริ่ม";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label7.Location = new System.Drawing.Point(47, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 27);
            this.label7.TabIndex = 48;
            this.label7.Text = "โดรน";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_cost.Location = new System.Drawing.Point(548, 448);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(187, 34);
            this.textBox_cost.TabIndex = 46;
            // 
            // textBox_cap
            // 
            this.textBox_cap.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_cap.Location = new System.Drawing.Point(548, 386);
            this.textBox_cap.Name = "textBox_cap";
            this.textBox_cap.Size = new System.Drawing.Size(187, 34);
            this.textBox_cap.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label6.Location = new System.Drawing.Point(432, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 27);
            this.label6.TabIndex = 44;
            this.label6.Text = "ปริมาณสาร (มล.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label5.Location = new System.Drawing.Point(432, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 45;
            this.label5.Text = "ค่าใช้จ่าย (บาท)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label3.Location = new System.Drawing.Point(49, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "วัตถุดิบ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label4.Location = new System.Drawing.Point(47, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "กิจกรรม";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(54, 177);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2018, 7, 29, 0, 0, 0, 0), new System.DateTime(2018, 8, 4, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MissionPlanner.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(36, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 257);
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
            this.button_edit.Location = new System.Drawing.Point(810, 435);
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
            this.button_delete.Location = new System.Drawing.Point(810, 488);
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
            this.actioncapacityDataGridViewTextBoxColumn,
            this.actioncostDataGridViewTextBoxColumn,
            this.drone_id,
            this.action_startTime,
            this.action_finishTime,
            this.farm_id,
            this.action_no,
            this.farm_name,
            this.drone_name,
            this.material_no,
            this.act_no});
            this.DG_Farm.DataSource = this.flightScheduleBindingSource1;
            this.DG_Farm.Location = new System.Drawing.Point(325, 94);
            this.DG_Farm.MultiSelect = false;
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(615, 257);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            this.DG_Farm.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_RowEnter);
            this.DG_Farm.Click += new System.EventHandler(this.DG_Farm_Click);
            // 
            // actiondatetimeDataGridViewTextBoxColumn
            // 
            this.actiondatetimeDataGridViewTextBoxColumn.DataPropertyName = "action_datetime";
            this.actiondatetimeDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.actiondatetimeDataGridViewTextBoxColumn.Name = "actiondatetimeDataGridViewTextBoxColumn";
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
            // drone_id
            // 
            this.drone_id.DataPropertyName = "drone_id";
            this.drone_id.HeaderText = "drone_id";
            this.drone_id.Name = "drone_id";
            this.drone_id.Visible = false;
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
            // farm_id
            // 
            this.farm_id.DataPropertyName = "farm_id";
            this.farm_id.HeaderText = "farm_id";
            this.farm_id.Name = "farm_id";
            this.farm_id.Visible = false;
            // 
            // action_no
            // 
            this.action_no.DataPropertyName = "action_no";
            this.action_no.HeaderText = "action_no";
            this.action_no.Name = "action_no";
            this.action_no.Visible = false;
            // 
            // farm_name
            // 
            this.farm_name.DataPropertyName = "farm_name";
            this.farm_name.HeaderText = "ชื่อฟาร์ม";
            this.farm_name.Name = "farm_name";
            // 
            // drone_name
            // 
            this.drone_name.DataPropertyName = "drone_name";
            this.drone_name.HeaderText = "โดรน";
            this.drone_name.Name = "drone_name";
            // 
            // material_no
            // 
            this.material_no.DataPropertyName = "material_no";
            this.material_no.HeaderText = "material_no";
            this.material_no.Name = "material_no";
            this.material_no.Visible = false;
            // 
            // act_no
            // 
            this.act_no.DataPropertyName = "act_no";
            this.act_no.HeaderText = "act_no";
            this.act_no.Name = "act_no";
            this.act_no.Visible = false;
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
            this.But_add_act.Location = new System.Drawing.Point(810, 382);
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
            this.panel3.Size = new System.Drawing.Size(984, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(984, 50);
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
            // view_flightschedule
            // 
            this.view_flightschedule.DataSetName = "View_flightschedule";
            this.view_flightschedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_farm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 620);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "Form_farm_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            ((System.ComponentModel.ISupportInitialize)(this.view_flightschedule)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.TextBox textBox_cap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_finishTime;
        private System.Windows.Forms.TextBox textBox_startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DroneFlightPlannerDataSet5 droneFlightPlannerDataSet5;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource1;
        private DroneFlightPlannerDataSet5TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cboDrone;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_finishTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn act_no;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private View_flightschedule view_flightschedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiondatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}