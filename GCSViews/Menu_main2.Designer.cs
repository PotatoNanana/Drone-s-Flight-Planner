namespace MissionPlanner.GCSViews
{
    partial class Menu_main2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_schedule = new System.Windows.Forms.Button();
            this.lineSeparator3 = new MissionPlanner.Controls.LineSeparator();
            this.DG_schedule = new MissionPlanner.Controls.MyDataGridView();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DG_maintenance = new MissionPlanner.Controls.MyDataGridView();
            this.Goto_farmMaintenance = new System.Windows.Forms.Button();
            this.lineSeparator1 = new MissionPlanner.Controls.LineSeparator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.DG_farm = new MissionPlanner.Controls.MyDataGridView();
            this.Goto_farmProfile = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.button_showDGFarm = new System.Windows.Forms.Button();
            this.button_showDGMaintain = new System.Windows.Forms.Button();
            this.button_showDGSchedule = new System.Windows.Forms.Button();
            this.fArm = new MissionPlanner.FArm();
            this.farmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmTableAdapter = new MissionPlanner.FArmTableAdapters.FarmTableAdapter();
            this.farmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmhostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAintain = new MissionPlanner.MAintain();
            this.maintainanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintainanceTableAdapter = new MissionPlanner.MAintainTableAdapters.MaintainanceTableAdapter();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainactivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintaindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainlengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainresponderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainvenderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainvenderAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainvenderPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_schedule)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_maintenance)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_farm)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.button_showDGSchedule);
            this.panel5.Controls.Add(this.but_schedule);
            this.panel5.Controls.Add(this.lineSeparator3);
            this.panel5.Controls.Add(this.DG_schedule);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel5.Location = new System.Drawing.Point(590, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(716, 280);
            this.panel5.TabIndex = 10;
            // 
            // but_schedule
            // 
            this.but_schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.but_schedule.FlatAppearance.BorderSize = 0;
            this.but_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_schedule.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.but_schedule.ForeColor = System.Drawing.Color.White;
            this.but_schedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_schedule.Location = new System.Drawing.Point(404, 220);
            this.but_schedule.Name = "but_schedule";
            this.but_schedule.Size = new System.Drawing.Size(130, 40);
            this.but_schedule.TabIndex = 6;
            this.but_schedule.Text = "ดูเพิ่มเติม";
            this.but_schedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_schedule.UseVisualStyleBackColor = false;
            this.but_schedule.Click += new System.EventHandler(this.but_schedule_Click);
            // 
            // lineSeparator3
            // 
            this.lineSeparator3.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator3.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator3.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator3.Name = "lineSeparator3";
            this.lineSeparator3.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator3.Size = new System.Drawing.Size(696, 2);
            this.lineSeparator3.TabIndex = 8;
            // 
            // DG_schedule
            // 
            this.DG_schedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column18,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DG_schedule.Location = new System.Drawing.Point(28, 70);
            this.DG_schedule.Name = "DG_schedule";
            this.DG_schedule.Size = new System.Drawing.Size(666, 140);
            this.DG_schedule.TabIndex = 10;
            this.DG_schedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView2_CellContentClick);
            // 
            // Column18
            // 
            this.Column18.HeaderText = "วันที่";
            this.Column18.Name = "Column18";
            this.Column18.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "รหัสฟาร์ม";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "รหัสกิจกรรม";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ชื่อกิจกรรม";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "รูปแบบการบิน";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "รหัสโดรน";
            this.Column9.Name = "Column9";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(716, 50);
            this.panel6.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("PJ Standard", 18F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(716, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "ตารางปฏิทินการบิน";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button_showDGMaintain);
            this.panel2.Controls.Add(this.DG_maintenance);
            this.panel2.Controls.Add(this.Goto_farmMaintenance);
            this.panel2.Controls.Add(this.lineSeparator1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel2.Location = new System.Drawing.Point(60, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 280);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // DG_maintenance
            // 
            this.DG_maintenance.AutoGenerateColumns = false;
            this.DG_maintenance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_maintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.droneidDataGridViewTextBoxColumn,
            this.maintainidDataGridViewTextBoxColumn,
            this.maintainactivityDataGridViewTextBoxColumn,
            this.maintaindateDataGridViewTextBoxColumn,
            this.maintainpriceDataGridViewTextBoxColumn,
            this.maintainlengthDataGridViewTextBoxColumn,
            this.maintainresponderDataGridViewTextBoxColumn,
            this.maintainvenderNameDataGridViewTextBoxColumn,
            this.maintainvenderAddDataGridViewTextBoxColumn,
            this.maintainvenderPhoneDataGridViewTextBoxColumn});
            this.DG_maintenance.DataSource = this.maintainanceBindingSource;
            this.DG_maintenance.Location = new System.Drawing.Point(25, 70);
            this.DG_maintenance.Name = "DG_maintenance";
            this.DG_maintenance.Size = new System.Drawing.Size(1156, 140);
            this.DG_maintenance.TabIndex = 9;
            // 
            // Goto_farmMaintenance
            // 
            this.Goto_farmMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.Goto_farmMaintenance.FlatAppearance.BorderSize = 0;
            this.Goto_farmMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Goto_farmMaintenance.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.Goto_farmMaintenance.ForeColor = System.Drawing.Color.White;
            this.Goto_farmMaintenance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Goto_farmMaintenance.Location = new System.Drawing.Point(558, 220);
            this.Goto_farmMaintenance.Name = "Goto_farmMaintenance";
            this.Goto_farmMaintenance.Size = new System.Drawing.Size(130, 40);
            this.Goto_farmMaintenance.TabIndex = 10;
            this.Goto_farmMaintenance.Text = "ดูเพิ่มเติม";
            this.Goto_farmMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Goto_farmMaintenance.UseVisualStyleBackColor = false;
            this.Goto_farmMaintenance.Click += new System.EventHandler(this.Goto_farmMaintenance_Click);
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator1.Size = new System.Drawing.Size(1226, 2);
            this.lineSeparator1.TabIndex = 8;
            this.lineSeparator1.Load += new System.EventHandler(this.lineSeparator1_Load);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1246, 50);
            this.panel4.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("PJ Standard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1246, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "ข้อมูลแผนการบำรุงรักษา";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.button_showDGFarm);
            this.panel_Main_farm.Controls.Add(this.DG_farm);
            this.panel_Main_farm.Controls.Add(this.Goto_farmProfile);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(500, 280);
            this.panel_Main_farm.TabIndex = 7;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DG_farm
            // 
            this.DG_farm.AllowUserToOrderColumns = true;
            this.DG_farm.AutoGenerateColumns = false;
            this.DG_farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.farmidDataGridViewTextBoxColumn,
            this.farmnameDataGridViewTextBoxColumn,
            this.farmhostDataGridViewTextBoxColumn,
            this.farmlocationDataGridViewTextBoxColumn});
            this.DG_farm.DataSource = this.farmBindingSource;
            this.DG_farm.Location = new System.Drawing.Point(25, 70);
            this.DG_farm.Name = "DG_farm";
            this.DG_farm.Size = new System.Drawing.Size(450, 140);
            this.DG_farm.TabIndex = 9;
            this.DG_farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_farm_CellContentClick);
            // 
            // Goto_farmProfile
            // 
            this.Goto_farmProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.Goto_farmProfile.FlatAppearance.BorderSize = 0;
            this.Goto_farmProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Goto_farmProfile.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goto_farmProfile.ForeColor = System.Drawing.Color.White;
            this.Goto_farmProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Goto_farmProfile.Location = new System.Drawing.Point(279, 220);
            this.Goto_farmProfile.Name = "Goto_farmProfile";
            this.Goto_farmProfile.Size = new System.Drawing.Size(130, 40);
            this.Goto_farmProfile.TabIndex = 6;
            this.Goto_farmProfile.Text = "ดูเพิ่มเติม";
            this.Goto_farmProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Goto_farmProfile.UseVisualStyleBackColor = false;
            this.Goto_farmProfile.Click += new System.EventHandler(this.Goto_farmProfile_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(480, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 50);
            this.panel3.TabIndex = 0;
            // 
            // Main_but_farm
            // 
            this.Main_but_farm.BackColor = System.Drawing.Color.White;
            this.Main_but_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_but_farm.Enabled = false;
            this.Main_but_farm.FlatAppearance.BorderSize = 0;
            this.Main_but_farm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_but_farm.Font = new System.Drawing.Font("PJ Standard", 18F, System.Drawing.FontStyle.Bold);
            this.Main_but_farm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.Main_but_farm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Main_but_farm.Location = new System.Drawing.Point(0, 0);
            this.Main_but_farm.Name = "Main_but_farm";
            this.Main_but_farm.Size = new System.Drawing.Size(500, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลฟาร์ม";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_showDGFarm
            // 
            this.button_showDGFarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_showDGFarm.FlatAppearance.BorderSize = 0;
            this.button_showDGFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showDGFarm.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showDGFarm.ForeColor = System.Drawing.Color.White;
            this.button_showDGFarm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_showDGFarm.Location = new System.Drawing.Point(103, 220);
            this.button_showDGFarm.Name = "button_showDGFarm";
            this.button_showDGFarm.Size = new System.Drawing.Size(130, 40);
            this.button_showDGFarm.TabIndex = 10;
            this.button_showDGFarm.Text = "แสดงตาราง";
            this.button_showDGFarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_showDGFarm.UseVisualStyleBackColor = false;
            this.button_showDGFarm.Click += new System.EventHandler(this.button_showDGFarm_Click);
            // 
            // button_showDGMaintain
            // 
            this.button_showDGMaintain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_showDGMaintain.FlatAppearance.BorderSize = 0;
            this.button_showDGMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showDGMaintain.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showDGMaintain.ForeColor = System.Drawing.Color.White;
            this.button_showDGMaintain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_showDGMaintain.Location = new System.Drawing.Point(402, 220);
            this.button_showDGMaintain.Name = "button_showDGMaintain";
            this.button_showDGMaintain.Size = new System.Drawing.Size(130, 40);
            this.button_showDGMaintain.TabIndex = 11;
            this.button_showDGMaintain.Text = "แสดงตาราง";
            this.button_showDGMaintain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_showDGMaintain.UseVisualStyleBackColor = false;
            this.button_showDGMaintain.Click += new System.EventHandler(this.button_showDGMaintain_Click);
            // 
            // button_showDGSchedule
            // 
            this.button_showDGSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_showDGSchedule.FlatAppearance.BorderSize = 0;
            this.button_showDGSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showDGSchedule.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showDGSchedule.ForeColor = System.Drawing.Color.White;
            this.button_showDGSchedule.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_showDGSchedule.Location = new System.Drawing.Point(226, 220);
            this.button_showDGSchedule.Name = "button_showDGSchedule";
            this.button_showDGSchedule.Size = new System.Drawing.Size(130, 40);
            this.button_showDGSchedule.TabIndex = 12;
            this.button_showDGSchedule.Text = "แสดงตาราง";
            this.button_showDGSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_showDGSchedule.UseVisualStyleBackColor = false;
            // 
            // fArm
            // 
            this.fArm.DataSetName = "FArm";
            this.fArm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // farmBindingSource
            // 
            this.farmBindingSource.DataMember = "Farm";
            this.farmBindingSource.DataSource = this.fArm;
            // 
            // farmTableAdapter
            // 
            this.farmTableAdapter.ClearBeforeFill = true;
            // 
            // farmidDataGridViewTextBoxColumn
            // 
            this.farmidDataGridViewTextBoxColumn.DataPropertyName = "farm_id";
            this.farmidDataGridViewTextBoxColumn.HeaderText = "รหัสฟาร์ม";
            this.farmidDataGridViewTextBoxColumn.Name = "farmidDataGridViewTextBoxColumn";
            // 
            // farmnameDataGridViewTextBoxColumn
            // 
            this.farmnameDataGridViewTextBoxColumn.DataPropertyName = "farm_name";
            this.farmnameDataGridViewTextBoxColumn.HeaderText = "ชื่อฟาร์ม";
            this.farmnameDataGridViewTextBoxColumn.Name = "farmnameDataGridViewTextBoxColumn";
            // 
            // farmhostDataGridViewTextBoxColumn
            // 
            this.farmhostDataGridViewTextBoxColumn.DataPropertyName = "farm_host";
            this.farmhostDataGridViewTextBoxColumn.HeaderText = "ผู้ดูแล";
            this.farmhostDataGridViewTextBoxColumn.Name = "farmhostDataGridViewTextBoxColumn";
            // 
            // farmlocationDataGridViewTextBoxColumn
            // 
            this.farmlocationDataGridViewTextBoxColumn.DataPropertyName = "farm_location";
            this.farmlocationDataGridViewTextBoxColumn.HeaderText = "ที่ตั้งฟาร์ม";
            this.farmlocationDataGridViewTextBoxColumn.Name = "farmlocationDataGridViewTextBoxColumn";
            // 
            // mAintain
            // 
            this.mAintain.DataSetName = "MAintain";
            this.mAintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintainanceBindingSource
            // 
            this.maintainanceBindingSource.DataMember = "Maintainance";
            this.maintainanceBindingSource.DataSource = this.mAintain;
            // 
            // maintainanceTableAdapter
            // 
            this.maintainanceTableAdapter.ClearBeforeFill = true;
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "รหัสโดรน";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
            // 
            // maintainidDataGridViewTextBoxColumn
            // 
            this.maintainidDataGridViewTextBoxColumn.DataPropertyName = "maintain_id";
            this.maintainidDataGridViewTextBoxColumn.HeaderText = "รหัสกิจกรรมซ่อมบำรุง";
            this.maintainidDataGridViewTextBoxColumn.Name = "maintainidDataGridViewTextBoxColumn";
            // 
            // maintainactivityDataGridViewTextBoxColumn
            // 
            this.maintainactivityDataGridViewTextBoxColumn.DataPropertyName = "maintain_activity";
            this.maintainactivityDataGridViewTextBoxColumn.HeaderText = "ชื่อกิจกรรมซ่อมบำรุง";
            this.maintainactivityDataGridViewTextBoxColumn.Name = "maintainactivityDataGridViewTextBoxColumn";
            // 
            // maintaindateDataGridViewTextBoxColumn
            // 
            this.maintaindateDataGridViewTextBoxColumn.DataPropertyName = "maintain_date";
            this.maintaindateDataGridViewTextBoxColumn.HeaderText = "วันที่ส่งซ่อมบำรุง";
            this.maintaindateDataGridViewTextBoxColumn.Name = "maintaindateDataGridViewTextBoxColumn";
            // 
            // maintainpriceDataGridViewTextBoxColumn
            // 
            this.maintainpriceDataGridViewTextBoxColumn.DataPropertyName = "maintain_price";
            this.maintainpriceDataGridViewTextBoxColumn.HeaderText = "ค่าใช้จ่าย";
            this.maintainpriceDataGridViewTextBoxColumn.Name = "maintainpriceDataGridViewTextBoxColumn";
            // 
            // maintainlengthDataGridViewTextBoxColumn
            // 
            this.maintainlengthDataGridViewTextBoxColumn.DataPropertyName = "maintain_length";
            this.maintainlengthDataGridViewTextBoxColumn.HeaderText = "ระยะเวลาการซ่อมบำรุง";
            this.maintainlengthDataGridViewTextBoxColumn.Name = "maintainlengthDataGridViewTextBoxColumn";
            // 
            // maintainresponderDataGridViewTextBoxColumn
            // 
            this.maintainresponderDataGridViewTextBoxColumn.DataPropertyName = "maintain_responder";
            this.maintainresponderDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ติดต่อตัวแทนการซ่อมบำรุง";
            this.maintainresponderDataGridViewTextBoxColumn.Name = "maintainresponderDataGridViewTextBoxColumn";
            // 
            // maintainvenderNameDataGridViewTextBoxColumn
            // 
            this.maintainvenderNameDataGridViewTextBoxColumn.DataPropertyName = "maintain_venderName";
            this.maintainvenderNameDataGridViewTextBoxColumn.HeaderText = "ชื่อบริษัทซ่อมบำรุง";
            this.maintainvenderNameDataGridViewTextBoxColumn.Name = "maintainvenderNameDataGridViewTextBoxColumn";
            // 
            // maintainvenderAddDataGridViewTextBoxColumn
            // 
            this.maintainvenderAddDataGridViewTextBoxColumn.DataPropertyName = "maintain_venderAdd";
            this.maintainvenderAddDataGridViewTextBoxColumn.HeaderText = "ที่อยู่บริษัทซ่อมบำรุง";
            this.maintainvenderAddDataGridViewTextBoxColumn.Name = "maintainvenderAddDataGridViewTextBoxColumn";
            // 
            // maintainvenderPhoneDataGridViewTextBoxColumn
            // 
            this.maintainvenderPhoneDataGridViewTextBoxColumn.DataPropertyName = "maintain_venderPhone";
            this.maintainvenderPhoneDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์บริษัทซ่อมบำรุง";
            this.maintainvenderPhoneDataGridViewTextBoxColumn.Name = "maintainvenderPhoneDataGridViewTextBoxColumn";
            // 
            // Menu_main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1366, 150);
            this.Name = "Menu_main2";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_schedule)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_maintenance)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_farm)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Panel panel3;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Button Goto_farmProfile;
        private System.Windows.Forms.Panel panel2;
        private Controls.LineSeparator lineSeparator1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private Controls.MyDataGridView DG_farm;
        private Controls.MyDataGridView DG_schedule;
        private System.Windows.Forms.Panel panel5;
        private Controls.MyDataGridView DG_maintenance;
        private System.Windows.Forms.Button but_schedule;
        private Controls.LineSeparator lineSeparator3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Goto_farmMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button_showDGSchedule;
        private System.Windows.Forms.Button button_showDGMaintain;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainactivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintaindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainlengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainresponderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainvenderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainvenderAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainvenderPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource maintainanceBindingSource;
        private MAintain mAintain;
        private System.Windows.Forms.Button button_showDGFarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmhostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource farmBindingSource;
        private FArm fArm;
        private FArmTableAdapters.FarmTableAdapter farmTableAdapter;
        private MAintainTableAdapters.MaintainanceTableAdapter maintainanceTableAdapter;
    }
}
