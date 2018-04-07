namespace MissionPlanner.GCSViews
{
    partial class Form_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log));
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.textBox_patternName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_farmID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_droneID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_actNo = new System.Windows.Forms.TextBox();
            this.textBox_patternMask = new System.Windows.Forms.TextBox();
            this.But_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_logNo = new System.Windows.Forms.TextBox();
            this.panel_Main_farm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.But_save);
            this.panel_Main_farm.Controls.Add(this.textBox_patternMask);
            this.panel_Main_farm.Controls.Add(this.textBox_logNo);
            this.panel_Main_farm.Controls.Add(this.label8);
            this.panel_Main_farm.Controls.Add(this.textBox_droneID);
            this.panel_Main_farm.Controls.Add(this.label7);
            this.panel_Main_farm.Controls.Add(this.textBox_farmID);
            this.panel_Main_farm.Controls.Add(this.label4);
            this.panel_Main_farm.Controls.Add(this.label3);
            this.panel_Main_farm.Controls.Add(this.textBox_actNo);
            this.panel_Main_farm.Controls.Add(this.textBox_patternName);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(728, 273);
            this.panel_Main_farm.TabIndex = 11;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
            // 
            // textBox_patternName
            // 
            this.textBox_patternName.Location = new System.Drawing.Point(516, 71);
            this.textBox_patternName.Name = "textBox_patternName";
            this.textBox_patternName.Size = new System.Drawing.Size(200, 31);
            this.textBox_patternName.TabIndex = 28;
            this.textBox_patternName.TextChanged += new System.EventHandler(this.textBox_patternName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "รูปแบบการบิน";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(728, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "หมายเหตุเพิ่มเติม";
            // 
            // textBox_farmID
            // 
            this.textBox_farmID.Location = new System.Drawing.Point(149, 118);
            this.textBox_farmID.Name = "textBox_farmID";
            this.textBox_farmID.Size = new System.Drawing.Size(200, 31);
            this.textBox_farmID.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "รหัสฟาร์ม";
            // 
            // textBox_droneID
            // 
            this.textBox_droneID.Location = new System.Drawing.Point(149, 168);
            this.textBox_droneID.Name = "textBox_droneID";
            this.textBox_droneID.Size = new System.Drawing.Size(200, 31);
            this.textBox_droneID.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "รหัสโดรน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "รหัสกิจกรรม";
            // 
            // textBox_actNo
            // 
            this.textBox_actNo.Location = new System.Drawing.Point(149, 214);
            this.textBox_actNo.Name = "textBox_actNo";
            this.textBox_actNo.Size = new System.Drawing.Size(200, 31);
            this.textBox_actNo.TabIndex = 29;
            // 
            // textBox_patternMask
            // 
            this.textBox_patternMask.Location = new System.Drawing.Point(516, 124);
            this.textBox_patternMask.Multiline = true;
            this.textBox_patternMask.Name = "textBox_patternMask";
            this.textBox_patternMask.Size = new System.Drawing.Size(200, 62);
            this.textBox_patternMask.TabIndex = 42;
            // 
            // But_save
            // 
            this.But_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_save.FlatAppearance.BorderSize = 0;
            this.But_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_save.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_save.ForeColor = System.Drawing.Color.White;
            this.But_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_save.Location = new System.Drawing.Point(544, 209);
            this.But_save.Name = "But_save";
            this.But_save.Size = new System.Drawing.Size(130, 40);
            this.But_save.TabIndex = 43;
            this.But_save.Text = "บันทึก";
            this.But_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_save.UseVisualStyleBackColor = false;
            this.But_save.Click += new System.EventHandler(this.But_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "รหัสประวัติการบิน";
            // 
            // textBox_logNo
            // 
            this.textBox_logNo.Location = new System.Drawing.Point(149, 71);
            this.textBox_logNo.Name = "textBox_logNo";
            this.textBox_logNo.Size = new System.Drawing.Size(200, 31);
            this.textBox_logNo.TabIndex = 41;
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 273);
            this.Controls.Add(this.panel_Main_farm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_log";
            this.Text = "Flight Log";
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.TextBox textBox_patternName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_farmID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_droneID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_actNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_patternMask;
        private System.Windows.Forms.Button But_save;
        private System.Windows.Forms.TextBox textBox_logNo;
        private System.Windows.Forms.Label label8;
    }
}