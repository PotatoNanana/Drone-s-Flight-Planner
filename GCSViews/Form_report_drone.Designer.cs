namespace MissionPlanner.GCSViews
{
    partial class Form_Report_Drone
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
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.button_Show = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_Noti = new MissionPlanner.Controls.MyDataGridView();
            this.device_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.comboBox_alarm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Noti)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.comboBox_alarm);
            this.panel_Main_farm.Controls.Add(this.button_Show);
            this.panel_Main_farm.Controls.Add(this.button1);
            this.panel_Main_farm.Controls.Add(this.DG_Noti);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(519, 329);
            this.panel_Main_farm.TabIndex = 13;
            // 
            // button_Show
            // 
            this.button_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_Show.FlatAppearance.BorderSize = 0;
            this.button_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_Show.ForeColor = System.Drawing.Color.White;
            this.button_Show.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Show.Location = new System.Drawing.Point(325, 72);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(149, 36);
            this.button_Show.TabIndex = 16;
            this.button_Show.Text = "แสดงข้อมูล";
            this.button_Show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Show.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(167, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "รับทราบ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DG_Noti
            // 
            this.DG_Noti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Noti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Noti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device_id,
            this.device_name,
            this.device_position,
            this.device_alarm});
            this.DG_Noti.Location = new System.Drawing.Point(24, 123);
            this.DG_Noti.Name = "DG_Noti";
            this.DG_Noti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Noti.Size = new System.Drawing.Size(472, 147);
            this.DG_Noti.TabIndex = 9;
            // 
            // device_id
            // 
            this.device_id.DataPropertyName = "device_id";
            this.device_id.HeaderText = "รหัสชิ้นส่วนโดรน";
            this.device_id.Name = "device_id";
            // 
            // device_name
            // 
            this.device_name.DataPropertyName = "device_name";
            this.device_name.HeaderText = "ชื่อชิ้นส่วนโดรน";
            this.device_name.Name = "device_name";
            // 
            // device_position
            // 
            this.device_position.DataPropertyName = "device_position";
            this.device_position.HeaderText = "ตำแหน่งชิ้นส่วนโดรน";
            this.device_position.Name = "device_position";
            // 
            // device_alarm
            // 
            this.device_alarm.DataPropertyName = "device_alarm";
            this.device_alarm.HeaderText = "การแจ้งเตือน";
            this.device_alarm.Name = "device_alarm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(519, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "รายงานส่วนประกอบโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // comboBox_alarm
            // 
            this.comboBox_alarm.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.comboBox_alarm.FormattingEnabled = true;
            this.comboBox_alarm.Items.AddRange(new object[] {
            "ทุกวัน",
            "ทุกอาทิตย์",
            "ทุกเดือน",
            "ทุก1ปี"});
            this.comboBox_alarm.Location = new System.Drawing.Point(101, 74);
            this.comboBox_alarm.Name = "comboBox_alarm";
            this.comboBox_alarm.Size = new System.Drawing.Size(200, 34);
            this.comboBox_alarm.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "โดรน";
            // 
            // Form_Report_Drone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 329);
            this.Controls.Add(this.panel_Main_farm);
            this.Name = "Form_Report_Drone";
            this.Text = "รายงานโดรน";
            this.Load += new System.EventHandler(this.Form_Report_Drone_Load);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Noti)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button1;
        private Controls.MyDataGridView DG_Noti;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_alarm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.ComboBox comboBox_alarm;
        private System.Windows.Forms.Label label1;
    }
}