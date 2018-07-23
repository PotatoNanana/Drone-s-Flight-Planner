namespace MissionPlanner.GCSViews
{
    partial class Form_farm_role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_farm_role));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_selected = new MissionPlanner.Controls.MyDataGridView();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.role_selected = new MissionPlanner.role_selected();
            this.Button_show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DG_unselected = new MissionPlanner.Controls.MyDataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.role_unselected = new MissionPlanner.role_unselected();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightScheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._Drone_s_Flight_PlannerDataSet4 = new MissionPlanner._Drone_s_Flight_PlannerDataSet4();
            this.afterFlightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitySchedule = new MissionPlanner.ActivitySchedule();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule = new MissionPlanner.flightSchedule();
            this.scheduleactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet1 = new MissionPlanner.DroneFlightPlannerDataSet1();
            this.schedule_actionTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet1TableAdapters.schedule_actionTableAdapter();
            this.flightScheduleTableAdapter = new MissionPlanner.flightScheduleTableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleTableAdapter1 = new MissionPlanner.ActivityScheduleTableAdapters.FlightScheduleTableAdapter();
            this.flightScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flightScheduleTableAdapter2 = new MissionPlanner._Drone_s_Flight_PlannerDataSet4TableAdapters.FlightScheduleTableAdapter();
            this.userLoginTableAdapter = new MissionPlanner.role_unselectedTableAdapters.UserLoginTableAdapter();
            this.userLoginTableAdapter1 = new MissionPlanner.role_selectedTableAdapters.UserLoginTableAdapter();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_unselected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_unselected)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Drone_s_Flight_PlannerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterFlightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitySchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 440);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.button1);
            this.panel_Main_farm.Controls.Add(this.DG_selected);
            this.panel_Main_farm.Controls.Add(this.Button_show);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.label4);
            this.panel_Main_farm.Controls.Add(this.DG_unselected);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(576, 440);
            this.panel_Main_farm.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label2.Location = new System.Drawing.Point(303, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 69;
            this.label2.Text = "รายชื่อที่มีอยู่ในระบบ";
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
            this.button1.Location = new System.Drawing.Point(308, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 40);
            this.button1.TabIndex = 68;
            this.button1.Text = "ลบ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DG_selected
            // 
            this.DG_selected.AllowUserToAddRows = false;
            this.DG_selected.AllowUserToDeleteRows = false;
            this.DG_selected.AllowUserToOrderColumns = true;
            this.DG_selected.AutoGenerateColumns = false;
            this.DG_selected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_selected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn1});
            this.DG_selected.DataSource = this.userLoginBindingSource1;
            this.DG_selected.Location = new System.Drawing.Point(308, 98);
            this.DG_selected.Name = "DG_selected";
            this.DG_selected.ReadOnly = true;
            this.DG_selected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_selected.Size = new System.Drawing.Size(245, 280);
            this.DG_selected.TabIndex = 67;
            this.DG_selected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_selected_CellContentClick);
            this.DG_selected.Paint += new System.Windows.Forms.PaintEventHandler(this.DG_selected_Paint);
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userLoginBindingSource1
            // 
            this.userLoginBindingSource1.DataMember = "UserLogin";
            this.userLoginBindingSource1.DataSource = this.role_selected;
            // 
            // role_selected
            // 
            this.role_selected.DataSetName = "role_selected";
            this.role_selected.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button_show
            // 
            this.Button_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.Button_show.FlatAppearance.BorderSize = 0;
            this.Button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_show.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button_show.ForeColor = System.Drawing.Color.White;
            this.Button_show.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_show.Location = new System.Drawing.Point(19, 384);
            this.Button_show.Name = "Button_show";
            this.Button_show.Size = new System.Drawing.Size(58, 40);
            this.Button_show.TabIndex = 66;
            this.Button_show.Text = "เพิ่ม";
            this.Button_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Button_show.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label1.Location = new System.Drawing.Point(270, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 27);
            this.label1.TabIndex = 64;
            this.label1.Text = ">>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 27);
            this.label4.TabIndex = 62;
            this.label4.Text = "รายชื่อสำหรับเลือก";
            // 
            // DG_unselected
            // 
            this.DG_unselected.AllowUserToAddRows = false;
            this.DG_unselected.AllowUserToDeleteRows = false;
            this.DG_unselected.AllowUserToOrderColumns = true;
            this.DG_unselected.AutoGenerateColumns = false;
            this.DG_unselected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_unselected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_unselected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn});
            this.DG_unselected.DataSource = this.userLoginBindingSource;
            this.DG_unselected.Location = new System.Drawing.Point(19, 98);
            this.DG_unselected.Name = "DG_unselected";
            this.DG_unselected.ReadOnly = true;
            this.DG_unselected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_unselected.Size = new System.Drawing.Size(245, 280);
            this.DG_unselected.TabIndex = 9;
            this.DG_unselected.Paint += new System.Windows.Forms.PaintEventHandler(this.DG_unselected_Paint);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLoginBindingSource
            // 
            this.userLoginBindingSource.DataMember = "UserLogin";
            this.userLoginBindingSource.DataSource = this.role_unselected;
            // 
            // role_unselected
            // 
            this.role_unselected.DataSetName = "role_unselected";
            this.role_unselected.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(576, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "สิทธิการเข้าถึงฟาร์ม";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // flightScheduleBindingSource2
            // 
            this.flightScheduleBindingSource2.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource2.DataSource = this._Drone_s_Flight_PlannerDataSet4;
            // 
            // _Drone_s_Flight_PlannerDataSet4
            // 
            this._Drone_s_Flight_PlannerDataSet4.DataSetName = "_Drone_s_Flight_PlannerDataSet4";
            this._Drone_s_Flight_PlannerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afterFlightBindingSource
            // 
            this.afterFlightBindingSource.DataMember = "AfterFlight";
            // 
            // activitySchedule
            // 
            this.activitySchedule.DataSetName = "ActivitySchedule";
            this.activitySchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource.DataSource = this.flightSchedule;
            // 
            // flightSchedule
            // 
            this.flightSchedule.DataSetName = "flightSchedule";
            this.flightSchedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleactionBindingSource
            // 
            this.scheduleactionBindingSource.DataMember = "schedule_action";
            this.scheduleactionBindingSource.DataSource = this.droneFlightPlannerDataSet1;
            // 
            // droneFlightPlannerDataSet1
            // 
            this.droneFlightPlannerDataSet1.DataSetName = "DroneFlightPlannerDataSet1";
            this.droneFlightPlannerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schedule_actionTableAdapter
            // 
            this.schedule_actionTableAdapter.ClearBeforeFill = true;
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // flightScheduleTableAdapter1
            // 
            this.flightScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // flightScheduleBindingSource1
            // 
            this.flightScheduleBindingSource1.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource1.DataSource = this.activitySchedule;
            // 
            // flightScheduleTableAdapter2
            // 
            this.flightScheduleTableAdapter2.ClearBeforeFill = true;
            // 
            // userLoginTableAdapter
            // 
            this.userLoginTableAdapter.ClearBeforeFill = true;
            // 
            // userLoginTableAdapter1
            // 
            this.userLoginTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_farm_role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 440);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_farm_role";
            this.Text = "Flight Schedule";
            this.Load += new System.EventHandler(this.Form_farm_role_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_farm_role_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_unselected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.role_unselected)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Drone_s_Flight_PlannerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterFlightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitySchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_unselected;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private DroneFlightPlannerDataSet1 droneFlightPlannerDataSet1;
        private System.Windows.Forms.BindingSource scheduleactionBindingSource;
        private DroneFlightPlannerDataSet1TableAdapters.schedule_actionTableAdapter schedule_actionTableAdapter;
        private flightSchedule flightSchedule;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private flightScheduleTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private ActivitySchedule activitySchedule;
        private ActivityScheduleTableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter1;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource1;
        //private DroneFlightPlannerDataSet7 droneFlightPlannerDataSet7;
        private System.Windows.Forms.BindingSource afterFlightBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn afnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afcapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afstartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affinishTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmidDataGridViewTextBoxColumn;
        private _Drone_s_Flight_PlannerDataSet4 _Drone_s_Flight_PlannerDataSet4;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource2;
        private _Drone_s_Flight_PlannerDataSet4TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Controls.MyDataGridView DG_selected;
        private role_unselected role_unselected;
        private System.Windows.Forms.BindingSource userLoginBindingSource;
        private role_unselectedTableAdapters.UserLoginTableAdapter userLoginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private role_selected role_selected;
        private System.Windows.Forms.BindingSource userLoginBindingSource1;
        private role_selectedTableAdapters.UserLoginTableAdapter userLoginTableAdapter1;
    }
}