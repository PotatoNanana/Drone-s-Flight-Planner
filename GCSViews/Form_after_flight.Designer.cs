namespace MissionPlanner.GCSViews
{
    partial class Form_after_flight
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
            this.textBox_cap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.But_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.textBox_finishTime = new System.Windows.Forms.TextBox();
            this.textBox_startTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Main_farm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.textBox_finishTime);
            this.panel_Main_farm.Controls.Add(this.textBox_startTime);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.textBox_cap);
            this.panel_Main_farm.Controls.Add(this.label6);
            this.panel_Main_farm.Controls.Add(this.But_save);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(368, 283);
            this.panel_Main_farm.TabIndex = 12;
            // 
            // textBox_cap
            // 
            this.textBox_cap.Location = new System.Drawing.Point(149, 64);
            this.textBox_cap.Name = "textBox_cap";
            this.textBox_cap.Size = new System.Drawing.Size(200, 31);
            this.textBox_cap.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 58;
            this.label6.Text = "ปริมาณสาร";
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
            this.But_save.Location = new System.Drawing.Point(112, 222);
            this.But_save.Name = "But_save";
            this.But_save.Size = new System.Drawing.Size(130, 40);
            this.But_save.TabIndex = 43;
            this.But_save.Text = "บันทึก";
            this.But_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_save.UseVisualStyleBackColor = false;
            this.But_save.Click += new System.EventHandler(this.But_save_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(368, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลหลังการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // textBox_finishTime
            // 
            this.textBox_finishTime.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_finishTime.Location = new System.Drawing.Point(149, 164);
            this.textBox_finishTime.Name = "textBox_finishTime";
            this.textBox_finishTime.Size = new System.Drawing.Size(93, 34);
            this.textBox_finishTime.TabIndex = 65;
            // 
            // textBox_startTime
            // 
            this.textBox_startTime.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.textBox_startTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_startTime.Location = new System.Drawing.Point(149, 113);
            this.textBox_startTime.Name = "textBox_startTime";
            this.textBox_startTime.ShortcutsEnabled = false;
            this.textBox_startTime.Size = new System.Drawing.Size(93, 34);
            this.textBox_startTime.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label2.Location = new System.Drawing.Point(32, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 63;
            this.label2.Text = "เวลาที่เสร็จ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label1.Location = new System.Drawing.Point(32, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 62;
            this.label1.Text = "เวลาที่เริ่ม";
            // 
            // Form_after_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 283);
            this.Controls.Add(this.panel_Main_farm);
            this.Name = "Form_after_flight";
            this.Text = "ข้อมูลหลังการบิน";
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Button But_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.TextBox textBox_cap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_finishTime;
        private System.Windows.Forms.TextBox textBox_startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}