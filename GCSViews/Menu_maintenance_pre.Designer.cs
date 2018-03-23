namespace MissionPlanner.GCSViews
{
    partial class Menu_maintenance_pre
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
            this.but_backto_pre = new System.Windows.Forms.Button();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BUT_add_drone_pre = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.but_backto_pre);
            this.panel2.Controls.Add(this.panel_Main_farm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 768);
            this.panel2.TabIndex = 1;
            // 
            // but_backto_pre
            // 
            this.but_backto_pre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.but_backto_pre.FlatAppearance.BorderSize = 0;
            this.but_backto_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_backto_pre.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_backto_pre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_backto_pre.Location = new System.Drawing.Point(60, 566);
            this.but_backto_pre.Name = "but_backto_pre";
            this.but_backto_pre.Size = new System.Drawing.Size(70, 40);
            this.but_backto_pre.TabIndex = 10;
            this.but_backto_pre.Text = "< กลับ";
            this.but_backto_pre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_backto_pre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_backto_pre.UseVisualStyleBackColor = false;
            this.but_backto_pre.Click += new System.EventHandler(this.but_backto_pre_Click);
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.BUT_add_drone_pre);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1250, 500);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint_1);
            // 
            // DG_Farm
            // 
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.date,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column6,
            this.Column11,
            this.Column2,
            this.Delete,
            this.Edit});
            this.DG_Farm.Location = new System.Drawing.Point(25, 70);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.Size = new System.Drawing.Size(1200, 350);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "วันที่ส่งซ่อม";
            this.Column3.Name = "Column3";
            // 
            // date
            // 
            this.date.HeaderText = "กิจกรรม";
            this.date.Name = "date";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ราคา";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ชื่อตัวแทนซ่อมบำรุง";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "เบอร์ตัวแทนซ่อมบำรุง";
            this.Column10.Name = "Column10";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ที่อยู่ตัวแทนซ่อมบำรุง";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "ระยะเวลาในการดำเนินการ";
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ชื่อผู้ติดต่อกับตัวแทนซ่อมบำรุง";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
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
            this.Delete.Width = 50;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "แก้ไข";
            this.Edit.Name = "Edit";
            this.Edit.Text = "แก้ไข";
            this.Edit.ToolTipText = "แก้ไข";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // BUT_add_drone_pre
            // 
            this.BUT_add_drone_pre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_add_drone_pre.FlatAppearance.BorderSize = 0;
            this.BUT_add_drone_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_add_drone_pre.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_add_drone_pre.ForeColor = System.Drawing.Color.White;
            this.BUT_add_drone_pre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_add_drone_pre.Location = new System.Drawing.Point(560, 440);
            this.BUT_add_drone_pre.Name = "BUT_add_drone_pre";
            this.BUT_add_drone_pre.Size = new System.Drawing.Size(130, 40);
            this.BUT_add_drone_pre.TabIndex = 6;
            this.BUT_add_drone_pre.Text = "เพิ่มข้อมูล";
            this.BUT_add_drone_pre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_add_drone_pre.UseVisualStyleBackColor = false;
            this.BUT_add_drone_pre.Click += new System.EventHandler(this.BUT_add_drone_pre_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(1230, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1250, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลการบำรุงรักษาชิ้นส่วนภายในโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // Menu_maintenance_pre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Menu_maintenance_pre";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel2.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Button BUT_add_drone_pre;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button but_backto_pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}
