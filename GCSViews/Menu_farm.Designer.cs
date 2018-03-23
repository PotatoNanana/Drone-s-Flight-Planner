namespace MissionPlanner.GCSViews
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FlightSchedule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BUT_add_farm = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.button_futureAct = new System.Windows.Forms.Button();
            this.button_pastAct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_farmName = new System.Windows.Forms.TextBox();
            this.textBox_farmID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_showData = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
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
            this.panel_Main_farm.Controls.Add(this.button_showData);
            this.panel_Main_farm.Controls.Add(this.textBox_farmName);
            this.panel_Main_farm.Controls.Add(this.textBox_farmID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.button2);
            this.panel_Main_farm.Controls.Add(this.button1);
            this.panel_Main_farm.Controls.Add(this.button_pastAct);
            this.panel_Main_farm.Controls.Add(this.button_futureAct);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.BUT_add_farm);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14F);
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1150, 530);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint_1);
            // 
            // DG_Farm
            // 
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Activity,
            this.FlightSchedule,
            this.Delete,
            this.Edit});
            this.DG_Farm.Location = new System.Drawing.Point(25, 70);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(593, 380);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "รหัสฟาร์ม";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ชื่อฟาร์ม";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ที่ตั้งฟาร์ม";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ผู้ดูแล";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Activity
            // 
            this.Activity.HeaderText = "กิจกรรมที่ผ่านมา";
            this.Activity.Name = "Activity";
            this.Activity.Text = "ดูกิจกรรม";
            this.Activity.ToolTipText = "ดูกิจกรรม";
            this.Activity.UseColumnTextForButtonValue = true;
            this.Activity.Width = 150;
            // 
            // FlightSchedule
            // 
            this.FlightSchedule.HeaderText = "กิจกรรมในอนาคต";
            this.FlightSchedule.Name = "FlightSchedule";
            this.FlightSchedule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightSchedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FlightSchedule.Text = "ดูกิจกรรม";
            this.FlightSchedule.ToolTipText = "ดูกิจกรรม";
            this.FlightSchedule.UseColumnTextForButtonValue = true;
            this.FlightSchedule.Width = 150;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "ลบ";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "ลบ";
            this.Delete.ToolTipText = "ลบ";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "แก้ไข";
            this.Edit.Name = "Edit";
            this.Edit.Text = "แก้ไข";
            this.Edit.ToolTipText = "แก้ไข";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // BUT_add_farm
            // 
            this.BUT_add_farm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_add_farm.FlatAppearance.BorderSize = 0;
            this.BUT_add_farm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_add_farm.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_add_farm.ForeColor = System.Drawing.Color.White;
            this.BUT_add_farm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_add_farm.Location = new System.Drawing.Point(656, 367);
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
            this.panel3.Size = new System.Drawing.Size(1150, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1150, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลฟาร์ม";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // button_futureAct
            // 
            this.button_futureAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_futureAct.FlatAppearance.BorderSize = 0;
            this.button_futureAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_futureAct.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_futureAct.ForeColor = System.Drawing.Color.White;
            this.button_futureAct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_futureAct.Location = new System.Drawing.Point(830, 237);
            this.button_futureAct.Name = "button_futureAct";
            this.button_futureAct.Size = new System.Drawing.Size(130, 40);
            this.button_futureAct.TabIndex = 10;
            this.button_futureAct.Text = "กิจกiรมที่จะเกิด";
            this.button_futureAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_futureAct.UseVisualStyleBackColor = false;
            this.button_futureAct.Click += new System.EventHandler(this.button_futureAct_Click);
            // 
            // button_pastAct
            // 
            this.button_pastAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_pastAct.FlatAppearance.BorderSize = 0;
            this.button_pastAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pastAct.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pastAct.ForeColor = System.Drawing.Color.White;
            this.button_pastAct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_pastAct.Location = new System.Drawing.Point(656, 237);
            this.button_pastAct.Name = "button_pastAct";
            this.button_pastAct.Size = new System.Drawing.Size(130, 40);
            this.button_pastAct.TabIndex = 11;
            this.button_pastAct.Text = "กิจกรรมที่ผ่านมา";
            this.button_pastAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_pastAct.UseVisualStyleBackColor = false;
            this.button_pastAct.Click += new System.EventHandler(this.button_pastAct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(656, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "ลบฟาร์ม";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(830, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "แก้ไขฟาร์ม";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_farmName
            // 
            this.textBox_farmName.Location = new System.Drawing.Point(773, 170);
            this.textBox_farmName.Name = "textBox_farmName";
            this.textBox_farmName.Size = new System.Drawing.Size(187, 30);
            this.textBox_farmName.TabIndex = 38;
            // 
            // textBox_farmID
            // 
            this.textBox_farmID.Location = new System.Drawing.Point(773, 109);
            this.textBox_farmID.Name = "textBox_farmID";
            this.textBox_farmID.Size = new System.Drawing.Size(187, 30);
            this.textBox_farmID.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label2.Location = new System.Drawing.Point(669, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "ชื่อฟาร์ม";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label1.Location = new System.Drawing.Point(669, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "รหัสฟาร์ม";
            // 
            // button_showData
            // 
            this.button_showData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_showData.FlatAppearance.BorderSize = 0;
            this.button_showData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showData.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showData.ForeColor = System.Drawing.Color.White;
            this.button_showData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_showData.Location = new System.Drawing.Point(830, 367);
            this.button_showData.Name = "button_showData";
            this.button_showData.Size = new System.Drawing.Size(130, 40);
            this.button_showData.TabIndex = 39;
            this.button_showData.Text = "แสดงตาราง";
            this.button_showData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_showData.UseVisualStyleBackColor = false;
            this.button_showData.Click += new System.EventHandler(this.button_showData_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Activity;
        private System.Windows.Forms.DataGridViewButtonColumn FlightSchedule;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_pastAct;
        private System.Windows.Forms.Button button_futureAct;
        private System.Windows.Forms.TextBox textBox_farmName;
        private System.Windows.Forms.TextBox textBox_farmID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_showData;
    }
}
