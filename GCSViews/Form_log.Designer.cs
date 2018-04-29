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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log));
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.But_save = new System.Windows.Forms.Button();
            this.textBox_patternMask = new System.Windows.Forms.TextBox();
            this.textBox_logNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.action_name = new MissionPlanner.action_name();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightScheduleTableAdapter = new MissionPlanner.action_nameTableAdapters.FlightScheduleTableAdapter();
            this.droneFlightPlannerDataSet4 = new MissionPlanner.DroneFlightPlannerDataSet4();
            this.flightScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightScheduleTableAdapter1 = new MissionPlanner.DroneFlightPlannerDataSet4TableAdapters.FlightScheduleTableAdapter();
            this.panel_Main_farm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.action_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.comboBox1);
            this.panel_Main_farm.Controls.Add(this.But_save);
            this.panel_Main_farm.Controls.Add(this.textBox_patternMask);
            this.panel_Main_farm.Controls.Add(this.textBox_logNo);
            this.panel_Main_farm.Controls.Add(this.label8);
            this.panel_Main_farm.Controls.Add(this.label3);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(382, 347);
            this.panel_Main_farm.TabIndex = 11;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
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
            this.But_save.Location = new System.Drawing.Point(219, 295);
            this.But_save.Name = "But_save";
            this.But_save.Size = new System.Drawing.Size(130, 40);
            this.But_save.TabIndex = 43;
            this.But_save.Text = "บันทึก";
            this.But_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_save.UseVisualStyleBackColor = false;
            this.But_save.Click += new System.EventHandler(this.But_save_Click);
            // 
            // textBox_patternMask
            // 
            this.textBox_patternMask.Location = new System.Drawing.Point(149, 173);
            this.textBox_patternMask.Multiline = true;
            this.textBox_patternMask.Name = "textBox_patternMask";
            this.textBox_patternMask.Size = new System.Drawing.Size(200, 101);
            this.textBox_patternMask.TabIndex = 42;
            // 
            // textBox_logNo
            // 
            this.textBox_logNo.Location = new System.Drawing.Point(149, 71);
            this.textBox_logNo.Name = "textBox_logNo";
            this.textBox_logNo.Size = new System.Drawing.Size(200, 31);
            this.textBox_logNo.TabIndex = 41;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "หมายเหตุเพิ่มเติม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "กิจกรรม";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(382, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.flightScheduleBindingSource1;
            this.comboBox1.DisplayMember = "action_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 32);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.ValueMember = "action_no";
            // 
            // action_name
            // 
            this.action_name.DataSetName = "action_name";
            this.action_name.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource.DataSource = this.action_name;
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // droneFlightPlannerDataSet4
            // 
            this.droneFlightPlannerDataSet4.DataSetName = "DroneFlightPlannerDataSet4";
            this.droneFlightPlannerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightScheduleBindingSource1
            // 
            this.flightScheduleBindingSource1.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource1.DataSource = this.droneFlightPlannerDataSet4;
            // 
            // flightScheduleTableAdapter1
            // 
            this.flightScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 347);
            this.Controls.Add(this.panel_Main_farm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_log";
            this.Text = "Flight Log";
            this.Load += new System.EventHandler(this.Form_log_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_log_KeyDown);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.action_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_patternMask;
        private System.Windows.Forms.Button But_save;
        private System.Windows.Forms.TextBox textBox_logNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private action_name action_name;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private action_nameTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private DroneFlightPlannerDataSet4 droneFlightPlannerDataSet4;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource1;
        private DroneFlightPlannerDataSet4TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter1;
    }
}