﻿namespace MissionPlanner.GCSViews
{
    partial class Form_Add_drone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_drone));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.textBox_droneName = new System.Windows.Forms.TextBox();
            this.textBox_droneID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_exit = new System.Windows.Forms.Button();
            this.BUT_save = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 261);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.textBox_droneName);
            this.panel_Main_farm.Controls.Add(this.textBox_droneID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.but_exit);
            this.panel_Main_farm.Controls.Add(this.BUT_save);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(484, 261);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint_1);
            // 
            // textBox_droneName
            // 
            this.textBox_droneName.Location = new System.Drawing.Point(176, 137);
            this.textBox_droneName.Name = "textBox_droneName";
            this.textBox_droneName.Size = new System.Drawing.Size(200, 30);
            this.textBox_droneName.TabIndex = 14;
            this.textBox_droneName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_droneID
            // 
            this.textBox_droneID.Location = new System.Drawing.Point(176, 97);
            this.textBox_droneID.Name = "textBox_droneID";
            this.textBox_droneID.Size = new System.Drawing.Size(200, 30);
            this.textBox_droneID.TabIndex = 14;
            this.textBox_droneID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ชื่อโดรน";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "รหัสโดรน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.but_exit.FlatAppearance.BorderSize = 0;
            this.but_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_exit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_exit.ForeColor = System.Drawing.Color.White;
            this.but_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_exit.Location = new System.Drawing.Point(255, 200);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(130, 40);
            this.but_exit.TabIndex = 6;
            this.but_exit.Text = "ยกเลิก";
            this.but_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // BUT_save
            // 
            this.BUT_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_save.FlatAppearance.BorderSize = 0;
            this.BUT_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_save.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_save.ForeColor = System.Drawing.Color.White;
            this.BUT_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_save.Location = new System.Drawing.Point(95, 200);
            this.BUT_save.Name = "BUT_save";
            this.BUT_save.Size = new System.Drawing.Size(130, 40);
            this.BUT_save.TabIndex = 6;
            this.BUT_save.Text = "บันทึก";
            this.BUT_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_save.UseVisualStyleBackColor = false;
            this.BUT_save.Click += new System.EventHandler(this.BUT_save_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(464, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(484, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "เพิ่มโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click_1);
            // 
            // Form_Add_drone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Add_drone";
            this.Text = "Drone Adding";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Add_drone_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.TextBox textBox_droneName;
        private System.Windows.Forms.TextBox textBox_droneID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button BUT_save;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
    }
}