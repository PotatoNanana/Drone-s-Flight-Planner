namespace MissionPlanner.GCSViews
{
    partial class Form_log_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log_history));
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.But_print = new System.Windows.Forms.Button();
            this.DG_Flight = new MissionPlanner.Controls.MyDataGridView();
            this.transactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneFlightPlannerDataSet7 = new MissionPlanner.DroneFlightPlannerDataSet7();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightLog = new MissionPlanner.FlightLog();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.flightLogTableAdapter = new MissionPlanner.FlightLogTableAdapters.FlightLogTableAdapter();
            this.transactTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet7TableAdapters.TransactTableAdapter();
            this._Drone_s_Flight_PlannerDataSet6 = new MissionPlanner._Drone_s_Flight_PlannerDataSet6();
            this.transactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactTableAdapter1 = new MissionPlanner._Drone_s_Flight_PlannerDataSet6TableAdapters.TransactTableAdapter();
            this.transaction_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_road = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_subDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farm_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Drone_s_Flight_PlannerDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.But_print);
            this.panel_Main_farm.Controls.Add(this.DG_Flight);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(784, 475);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
            // 
            // But_print
            // 
            this.But_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_print.FlatAppearance.BorderSize = 0;
            this.But_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_print.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_print.ForeColor = System.Drawing.Color.White;
            this.But_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_print.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_print.Location = new System.Drawing.Point(327, 423);
            this.But_print.Name = "But_print";
            this.But_print.Size = new System.Drawing.Size(130, 40);
            this.But_print.TabIndex = 11;
            this.But_print.Text = "พิมพ์";
            this.But_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_print.UseVisualStyleBackColor = false;
            // 
            // DG_Flight
            // 
            this.DG_Flight.AutoGenerateColumns = false;
            this.DG_Flight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Flight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transaction_datetime,
            this.drone_name,
            this.farm_name,
            this.farm_host,
            this.farm_address,
            this.farm_road,
            this.farm_subDistrict,
            this.farm_district,
            this.farm_province,
            this.farm_postal,
            this.action_name,
            this.material_name,
            this.action_capacity,
            this.action_cost,
            this.distance,
            this.area});
            this.DG_Flight.DataSource = this.transactBindingSource1;
            this.DG_Flight.Location = new System.Drawing.Point(25, 75);
            this.DG_Flight.Name = "DG_Flight";
            this.DG_Flight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Flight.Size = new System.Drawing.Size(735, 333);
            this.DG_Flight.TabIndex = 9;
            // 
            // transactBindingSource
            // 
            this.transactBindingSource.DataMember = "Transact";
            this.transactBindingSource.DataSource = this.droneFlightPlannerDataSet7;
            // 
            // droneFlightPlannerDataSet7
            // 
            this.droneFlightPlannerDataSet7.DataSetName = "DroneFlightPlannerDataSet7";
            this.droneFlightPlannerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Main_but_farm.Text = "ตารางบันทึกผลการบิน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            // 
            // flightLogBindingSource
            // 
            this.flightLogBindingSource.DataMember = "FlightLog";
            this.flightLogBindingSource.DataSource = this.flightLog;
            // 
            // flightLog
            // 
            this.flightLog.DataSetName = "FlightLog";
            this.flightLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "FlightSchedule";
            this.flightScheduleBindingSource.DataSource = this.flightSchedule2;
            // 
            // flightSchedule2
            // 
            this.flightSchedule2.DataSetName = "FlightSchedule2";
            this.flightSchedule2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 475);
            this.panel1.TabIndex = 1;
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // flightLogTableAdapter
            // 
            this.flightLogTableAdapter.ClearBeforeFill = true;
            // 
            // transactTableAdapter
            // 
            this.transactTableAdapter.ClearBeforeFill = true;
            // 
            // _Drone_s_Flight_PlannerDataSet6
            // 
            this._Drone_s_Flight_PlannerDataSet6.DataSetName = "_Drone_s_Flight_PlannerDataSet6";
            this._Drone_s_Flight_PlannerDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactBindingSource1
            // 
            this.transactBindingSource1.DataMember = "Transact";
            this.transactBindingSource1.DataSource = this._Drone_s_Flight_PlannerDataSet6;
            // 
            // transactTableAdapter1
            // 
            this.transactTableAdapter1.ClearBeforeFill = true;
            // 
            // transaction_datetime
            // 
            this.transaction_datetime.DataPropertyName = "transaction_datetime";
            this.transaction_datetime.HeaderText = "รหัสประวัติการบิน";
            this.transaction_datetime.Name = "transaction_datetime";
            // 
            // drone_name
            // 
            this.drone_name.DataPropertyName = "drone_name";
            this.drone_name.HeaderText = "ชื่อโดรน";
            this.drone_name.Name = "drone_name";
            // 
            // farm_name
            // 
            this.farm_name.DataPropertyName = "farm_name";
            this.farm_name.HeaderText = "ชื่อฟาร์ม";
            this.farm_name.Name = "farm_name";
            // 
            // farm_host
            // 
            this.farm_host.DataPropertyName = "farm_host";
            this.farm_host.HeaderText = "ผู้ดูแลฟาร์ม";
            this.farm_host.Name = "farm_host";
            // 
            // farm_address
            // 
            this.farm_address.DataPropertyName = "farm_address";
            this.farm_address.HeaderText = "ที่ตั้งฟาร์ม";
            this.farm_address.Name = "farm_address";
            // 
            // farm_road
            // 
            this.farm_road.DataPropertyName = "farm_road";
            this.farm_road.HeaderText = "ถนน";
            this.farm_road.Name = "farm_road";
            // 
            // farm_subDistrict
            // 
            this.farm_subDistrict.DataPropertyName = "farm_subDistrict";
            this.farm_subDistrict.HeaderText = "แขวง/ตำบล";
            this.farm_subDistrict.Name = "farm_subDistrict";
            // 
            // farm_district
            // 
            this.farm_district.DataPropertyName = "farm_district";
            this.farm_district.HeaderText = "เขต/อำเภอ";
            this.farm_district.Name = "farm_district";
            // 
            // farm_province
            // 
            this.farm_province.DataPropertyName = "farm_province";
            this.farm_province.HeaderText = "จังหวัด";
            this.farm_province.Name = "farm_province";
            // 
            // farm_postal
            // 
            this.farm_postal.DataPropertyName = "farm_postal";
            this.farm_postal.HeaderText = "รหัสไปรษณีย์";
            this.farm_postal.Name = "farm_postal";
            // 
            // action_name
            // 
            this.action_name.DataPropertyName = "action_name";
            this.action_name.HeaderText = "ชื่อกิจกรรม";
            this.action_name.Name = "action_name";
            // 
            // material_name
            // 
            this.material_name.DataPropertyName = "material_name";
            this.material_name.HeaderText = "วัตถุดิบ";
            this.material_name.Name = "material_name";
            // 
            // action_capacity
            // 
            this.action_capacity.DataPropertyName = "action_capacity";
            this.action_capacity.HeaderText = "ปรืมาณสาร";
            this.action_capacity.Name = "action_capacity";
            // 
            // action_cost
            // 
            this.action_cost.DataPropertyName = "action_cost";
            this.action_cost.HeaderText = "ค่าใช้จ่าย";
            this.action_cost.Name = "action_cost";
            // 
            // distance
            // 
            this.distance.DataPropertyName = "distance";
            this.distance.HeaderText = "ระยะทาง";
            this.distance.Name = "distance";
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "พื้นที่";
            this.area.Name = "area";
            // 
            // Form_log_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_log_history";
            this.Text = "Log History";
            this.Load += new System.EventHandler(this.Form_log_history_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_log_history_KeyDown);
            this.panel_Main_farm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet7)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Drone_s_Flight_PlannerDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Flight;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private FlightSchedule2 flightSchedule2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Panel panel1;
        private FlightSchedule2TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private MissionPlanner.FlightLog flightLog;
        private System.Windows.Forms.BindingSource flightLogBindingSource;
        private FlightLogTableAdapters.FlightLogTableAdapter flightLogTableAdapter;
        private System.Windows.Forms.Button But_print;
        private DroneFlightPlannerDataSet7 droneFlightPlannerDataSet7;
        private System.Windows.Forms.BindingSource transactBindingSource;
        private DroneFlightPlannerDataSet7TableAdapters.TransactTableAdapter transactTableAdapter;
        private _Drone_s_Flight_PlannerDataSet6 _Drone_s_Flight_PlannerDataSet6;
        private System.Windows.Forms.BindingSource transactBindingSource1;
        private _Drone_s_Flight_PlannerDataSet6TableAdapters.TransactTableAdapter transactTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn drone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_host;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_road;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_subDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_province;
        private System.Windows.Forms.DataGridViewTextBoxColumn farm_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}