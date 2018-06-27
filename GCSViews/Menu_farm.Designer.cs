﻿namespace MissionPlanner.GCSViews
{
    partial class Menu_farm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_farm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.button_serch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_farmHost = new System.Windows.Forms.TextBox();
            this.textBox_farmLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_farmName = new System.Windows.Forms.TextBox();
            this.textBox_farmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_pastAct = new System.Windows.Forms.Button();
            this.button_futureAct = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.farmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmhostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet2 = new MissionPlanner.DroneFlightPlannerDataSet2();
            this.BUT_add_farm = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.farmTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet2TableAdapters.FarmTableAdapter();
            this.button_print = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel_Main_farm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 768);
            this.panel2.TabIndex = 1;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.button_print);
            this.panel_Main_farm.Controls.Add(this.button_serch);
            this.panel_Main_farm.Controls.Add(this.label5);
            this.panel_Main_farm.Controls.Add(this.pictureBox);
            this.panel_Main_farm.Controls.Add(this.textBox_farmHost);
            this.panel_Main_farm.Controls.Add(this.textBox_farmLocation);
            this.panel_Main_farm.Controls.Add(this.label4);
            this.panel_Main_farm.Controls.Add(this.label3);
            this.panel_Main_farm.Controls.Add(this.textBox_farmName);
            this.panel_Main_farm.Controls.Add(this.textBox_farmID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.button2);
            this.panel_Main_farm.Controls.Add(this.button_delete);
            this.panel_Main_farm.Controls.Add(this.button_pastAct);
            this.panel_Main_farm.Controls.Add(this.button_futureAct);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.BUT_add_farm);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14F);
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1228, 580);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFarm_Paint);
            // 
            // button_serch
            // 
            this.button_serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_serch.FlatAppearance.BorderSize = 0;
            this.button_serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_serch.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_serch.ForeColor = System.Drawing.Color.White;
            this.button_serch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_serch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_serch.Location = new System.Drawing.Point(914, 502);
            this.button_serch.Name = "button_serch";
            this.button_serch.Size = new System.Drawing.Size(80, 40);
            this.button_serch.TabIndex = 47;
            this.button_serch.Text = "อัพโหลด";
            this.button_serch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_serch.UseVisualStyleBackColor = false;
            this.button_serch.Click += new System.EventHandler(this.button_serch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PJ Standard", 16.25F);
            this.label5.Location = new System.Drawing.Point(532, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 46;
            this.label5.Text = "รูปฟาร์ม";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(636, 315);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 227);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 45;
            this.pictureBox.TabStop = false;
            // 
            // textBox_farmHost
            // 
            this.textBox_farmHost.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_farmHost.Location = new System.Drawing.Point(636, 256);
            this.textBox_farmHost.Name = "textBox_farmHost";
            this.textBox_farmHost.Size = new System.Drawing.Size(255, 34);
            this.textBox_farmHost.TabIndex = 43;
            // 
            // textBox_farmLocation
            // 
            this.textBox_farmLocation.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_farmLocation.Location = new System.Drawing.Point(636, 199);
            this.textBox_farmLocation.Name = "textBox_farmLocation";
            this.textBox_farmLocation.Size = new System.Drawing.Size(255, 34);
            this.textBox_farmLocation.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(532, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "ผู้ดูแล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(532, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "ที่ตั้งฟาร์ม";
            // 
            // textBox_farmName
            // 
            this.textBox_farmName.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_farmName.Location = new System.Drawing.Point(636, 141);
            this.textBox_farmName.Name = "textBox_farmName";
            this.textBox_farmName.Size = new System.Drawing.Size(255, 34);
            this.textBox_farmName.TabIndex = 38;
            // 
            // textBox_farmID
            // 
            this.textBox_farmID.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_farmID.Location = new System.Drawing.Point(636, 81);
            this.textBox_farmID.Name = "textBox_farmID";
            this.textBox_farmID.Size = new System.Drawing.Size(255, 34);
            this.textBox_farmID.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(532, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "ชื่อฟาร์ม";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(532, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "รหัสฟาร์ม";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1042, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "แก้ไขฟาร์ม";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.Location = new System.Drawing.Point(1042, 302);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(130, 40);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "ลบฟาร์ม";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_pastAct
            // 
            this.button_pastAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_pastAct.FlatAppearance.BorderSize = 0;
            this.button_pastAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pastAct.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pastAct.ForeColor = System.Drawing.Color.White;
            this.button_pastAct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_pastAct.Location = new System.Drawing.Point(1042, 88);
            this.button_pastAct.Name = "button_pastAct";
            this.button_pastAct.Size = new System.Drawing.Size(130, 40);
            this.button_pastAct.TabIndex = 11;
            this.button_pastAct.Text = "กิจกรรมที่ผ่านมา";
            this.button_pastAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_pastAct.UseVisualStyleBackColor = false;
            this.button_pastAct.Click += new System.EventHandler(this.button_pastAct_Click);
            // 
            // button_futureAct
            // 
            this.button_futureAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_futureAct.FlatAppearance.BorderSize = 0;
            this.button_futureAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_futureAct.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_futureAct.ForeColor = System.Drawing.Color.White;
            this.button_futureAct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_futureAct.Location = new System.Drawing.Point(1042, 159);
            this.button_futureAct.Name = "button_futureAct";
            this.button_futureAct.Size = new System.Drawing.Size(130, 40);
            this.button_futureAct.TabIndex = 10;
            this.button_futureAct.Text = "กิจกรรมที่จะเกิด";
            this.button_futureAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_futureAct.UseVisualStyleBackColor = false;
            this.button_futureAct.Click += new System.EventHandler(this.button_futureAct_Click);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.farmidDataGridViewTextBoxColumn,
            this.farmnameDataGridViewTextBoxColumn,
            this.farmhostDataGridViewTextBoxColumn,
            this.farmlocationDataGridViewTextBoxColumn});
            this.DG_Farm.DataSource = this.farmBindingSource;
            this.DG_Farm.Location = new System.Drawing.Point(25, 70);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(444, 472);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
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
            // farmBindingSource
            // 
            this.farmBindingSource.DataMember = "Farm";
            this.farmBindingSource.DataSource = this.droneFlightPlannerDataSet2;
            // 
            // droneFlightPlannerDataSet2
            // 
            this.droneFlightPlannerDataSet2.DataSetName = "DroneFlightPlannerDataSet2";
            this.droneFlightPlannerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BUT_add_farm
            // 
            this.BUT_add_farm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_add_farm.FlatAppearance.BorderSize = 0;
            this.BUT_add_farm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_add_farm.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_add_farm.ForeColor = System.Drawing.Color.White;
            this.BUT_add_farm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_add_farm.Location = new System.Drawing.Point(1042, 245);
            this.BUT_add_farm.Name = "BUT_add_farm";
            this.BUT_add_farm.Size = new System.Drawing.Size(130, 40);
            this.BUT_add_farm.TabIndex = 6;
            this.BUT_add_farm.Text = "เพิ่มฟาร์ม";
            this.BUT_add_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_add_farm.UseVisualStyleBackColor = false;
            this.BUT_add_farm.Click += new System.EventHandler(this.BUT_add_farm_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(1130, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1228, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1228, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลฟาร์ม";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // farmTableAdapter
            // 
            this.farmTableAdapter.ClearBeforeFill = true;
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_print.Location = new System.Drawing.Point(1042, 414);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(130, 40);
            this.button_print.TabIndex = 48;
            this.button_print.Text = "พิมพ์รายงาน";
            this.button_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_print.UseVisualStyleBackColor = false;
            // 
            // Menu_farm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Menu_farm";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel2.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Button BUT_add_farm;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_pastAct;
        private System.Windows.Forms.Button button_futureAct;
        private System.Windows.Forms.BindingSource farmBindingSource;
        private DroneFlightPlannerDataSet2 droneFlightPlannerDataSet2;
        private DroneFlightPlannerDataSet2TableAdapters.FarmTableAdapter farmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmhostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_farmHost;
        private System.Windows.Forms.TextBox textBox_farmLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_farmName;
        private System.Windows.Forms.TextBox textBox_farmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_serch;
        private System.Windows.Forms.Button button_print;
    }
}
