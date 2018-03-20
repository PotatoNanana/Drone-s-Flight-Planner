namespace MissionPlanner.GCSViews
{
    partial class Menu_maintenance
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
            this.DG_Drone = new MissionPlanner.Controls.MyDataGridView();
            this.Drone_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BUT_drone_add = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Drone)).BeginInit();
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
            this.panel_Main_farm.Controls.Add(this.DG_Drone);
            this.panel_Main_farm.Controls.Add(this.BUT_drone_add);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14F);
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(700, 500);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint_1);
            // 
            // DG_Drone
            // 
            this.DG_Drone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Drone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Drone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drone_id,
            this.Drone_name,
            this.drone_detail,
            this.Delete,
            this.Edit});
            this.DG_Drone.Location = new System.Drawing.Point(25, 70);
            this.DG_Drone.Name = "DG_Drone";
            this.DG_Drone.Size = new System.Drawing.Size(650, 350);
            this.DG_Drone.TabIndex = 9;
            this.DG_Drone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Drone_CellContentClick);
            // 
            // Drone_id
            // 
            this.Drone_id.HeaderText = "รหัสโดรน";
            this.Drone_id.Name = "Drone_id";
            // 
            // Drone_name
            // 
            this.Drone_name.HeaderText = "ชื่อโดรน";
            this.Drone_name.Name = "Drone_name";
            // 
            // drone_detail
            // 
            this.drone_detail.HeaderText = "รายละเอียดส่วนประกอบ";
            this.drone_detail.Name = "drone_detail";
            this.drone_detail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.drone_detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.drone_detail.Text = "คลิกเพื่อดูรายละเอียด";
            this.drone_detail.UseColumnTextForButtonValue = true;
            this.drone_detail.Width = 160;
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
            // BUT_drone_add
            // 
            this.BUT_drone_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_drone_add.FlatAppearance.BorderSize = 0;
            this.BUT_drone_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_drone_add.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_drone_add.ForeColor = System.Drawing.Color.White;
            this.BUT_drone_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_drone_add.Location = new System.Drawing.Point(285, 440);
            this.BUT_drone_add.Name = "BUT_drone_add";
            this.BUT_drone_add.Size = new System.Drawing.Size(130, 40);
            this.BUT_drone_add.TabIndex = 6;
            this.BUT_drone_add.Text = "เพิ่มโดรน";
            this.BUT_drone_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_drone_add.UseVisualStyleBackColor = false;
            this.BUT_drone_add.Click += new System.EventHandler(this.BUT_add_drone_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(680, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(700, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // Menu_maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Menu_maintenance";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel2.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Drone)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Drone;
        private System.Windows.Forms.Button BUT_drone_add;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drone_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drone_name;
        private System.Windows.Forms.DataGridViewButtonColumn drone_detail;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}
