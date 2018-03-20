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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_farm_Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.But_exit = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.But_add_act = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.But_exit);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.But_add_act);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(784, 461);
            this.panel_Main_farm.TabIndex = 10;
            // 
            // But_exit
            // 
            this.But_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_exit.FlatAppearance.BorderSize = 0;
            this.But_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_exit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_exit.ForeColor = System.Drawing.Color.White;
            this.But_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_exit.Location = new System.Drawing.Point(402, 390);
            this.But_exit.Name = "But_exit";
            this.But_exit.Size = new System.Drawing.Size(130, 40);
            this.But_exit.TabIndex = 10;
            this.But_exit.Text = "ปิด";
            this.But_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_exit.UseVisualStyleBackColor = false;
            this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
            // 
            // DG_Farm
            // 
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column1,
            this.Delete,
            this.Edit});
            this.DG_Farm.Location = new System.Drawing.Point(25, 75);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.Size = new System.Drawing.Size(734, 300);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
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
            this.But_add_act.Location = new System.Drawing.Point(252, 390);
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
            this.panel3.Size = new System.Drawing.Size(784, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(784, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางปฏิทินการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "วันที่";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "รหัสกิจกรรม";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ชื่อกิจกรรม";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "รูปแบบการบิน";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "รหัสโดรน";
            this.Column1.Name = "Column1";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "ลบ";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "ลบ";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 80;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "แก้ไข";
            this.Edit.Name = "Edit";
            this.Edit.Text = "แก้ไข";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 80;
            // 
            // Form_farm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_farm_Schedule";
            this.Text = "Flight Schedule";
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Button But_exit;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button But_add_act;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}