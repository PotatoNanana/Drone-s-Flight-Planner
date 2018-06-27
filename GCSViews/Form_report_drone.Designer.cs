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
            this.components = new System.ComponentModel.Container();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_droneName = new System.Windows.Forms.ComboBox();
            this.button_Show = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_Noti = new MissionPlanner.Controls.MyDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.droneFlightPlannerDataSet8 = new MissionPlanner.DroneFlightPlannerDataSet8();
            this.droneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet8TableAdapters.DroneTableAdapter();
            this.droneFlightPlannerDataSet9 = new MissionPlanner.DroneFlightPlannerDataSet9();
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListTableAdapter = new MissionPlanner.DroneFlightPlannerDataSet9TableAdapters.DeviceListTableAdapter();
            this.deviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicepositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicebuyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceexpDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicestartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceresponderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicealarmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venderaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venderphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Noti)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.button_print);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.comboBox_droneName);
            this.panel_Main_farm.Controls.Add(this.button_Show);
            this.panel_Main_farm.Controls.Add(this.button1);
            this.panel_Main_farm.Controls.Add(this.DG_Noti);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(519, 346);
            this.panel_Main_farm.TabIndex = 13;
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
            // comboBox_droneName
            // 
            this.comboBox_droneName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.droneBindingSource, "drone_name", true));
            this.comboBox_droneName.DataSource = this.droneBindingSource;
            this.comboBox_droneName.DisplayMember = "drone_name";
            this.comboBox_droneName.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.comboBox_droneName.FormattingEnabled = true;
            this.comboBox_droneName.Location = new System.Drawing.Point(101, 74);
            this.comboBox_droneName.Name = "comboBox_droneName";
            this.comboBox_droneName.Size = new System.Drawing.Size(200, 34);
            this.comboBox_droneName.TabIndex = 67;
            this.comboBox_droneName.ValueMember = "drone_name";
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
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
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
            this.DG_Noti.AutoGenerateColumns = false;
            this.DG_Noti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Noti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Noti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceidDataGridViewTextBoxColumn,
            this.devicenameDataGridViewTextBoxColumn,
            this.devicepositionDataGridViewTextBoxColumn,
            this.devicepriceDataGridViewTextBoxColumn,
            this.devicebuyDateDataGridViewTextBoxColumn,
            this.deviceexpDateDataGridViewTextBoxColumn,
            this.devicestartDateDataGridViewTextBoxColumn,
            this.deviceresponderDataGridViewTextBoxColumn,
            this.devicealarmDataGridViewTextBoxColumn,
            this.vendernameDataGridViewTextBoxColumn,
            this.venderaddDataGridViewTextBoxColumn,
            this.venderphoneDataGridViewTextBoxColumn});
            this.DG_Noti.DataSource = this.deviceListBindingSource;
            this.DG_Noti.Location = new System.Drawing.Point(24, 123);
            this.DG_Noti.Name = "DG_Noti";
            this.DG_Noti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Noti.Size = new System.Drawing.Size(472, 147);
            this.DG_Noti.TabIndex = 9;
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
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_print.FlatAppearance.BorderSize = 0;
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_print.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_print.Location = new System.Drawing.Point(171, 289);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(130, 40);
            this.button_print.TabIndex = 69;
            this.button_print.Text = "พิมพ์";
            this.button_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_print.UseVisualStyleBackColor = false;
            // 
            // droneFlightPlannerDataSet8
            // 
            this.droneFlightPlannerDataSet8.DataSetName = "DroneFlightPlannerDataSet8";
            this.droneFlightPlannerDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // droneBindingSource
            // 
            this.droneBindingSource.DataMember = "Drone";
            this.droneBindingSource.DataSource = this.droneFlightPlannerDataSet8;
            // 
            // droneTableAdapter
            // 
            this.droneTableAdapter.ClearBeforeFill = true;
            // 
            // droneFlightPlannerDataSet9
            // 
            this.droneFlightPlannerDataSet9.DataSetName = "DroneFlightPlannerDataSet9";
            this.droneFlightPlannerDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceListBindingSource
            // 
            this.deviceListBindingSource.DataMember = "DeviceList";
            this.deviceListBindingSource.DataSource = this.droneFlightPlannerDataSet9;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // deviceidDataGridViewTextBoxColumn
            // 
            this.deviceidDataGridViewTextBoxColumn.DataPropertyName = "device_id";
            this.deviceidDataGridViewTextBoxColumn.HeaderText = "รหัสชิ้นส่วนโดรน";
            this.deviceidDataGridViewTextBoxColumn.Name = "deviceidDataGridViewTextBoxColumn";
            // 
            // devicenameDataGridViewTextBoxColumn
            // 
            this.devicenameDataGridViewTextBoxColumn.DataPropertyName = "device_name";
            this.devicenameDataGridViewTextBoxColumn.HeaderText = "ชื่อชิ้นส่วนโดรน";
            this.devicenameDataGridViewTextBoxColumn.Name = "devicenameDataGridViewTextBoxColumn";
            // 
            // devicepositionDataGridViewTextBoxColumn
            // 
            this.devicepositionDataGridViewTextBoxColumn.DataPropertyName = "device_position";
            this.devicepositionDataGridViewTextBoxColumn.HeaderText = "ตำแหน่งชิ้นส่วนโดรน";
            this.devicepositionDataGridViewTextBoxColumn.Name = "devicepositionDataGridViewTextBoxColumn";
            // 
            // devicepriceDataGridViewTextBoxColumn
            // 
            this.devicepriceDataGridViewTextBoxColumn.DataPropertyName = "device_price";
            this.devicepriceDataGridViewTextBoxColumn.HeaderText = "ราคาชิ้นส่วนโดรน";
            this.devicepriceDataGridViewTextBoxColumn.Name = "devicepriceDataGridViewTextBoxColumn";
            // 
            // devicebuyDateDataGridViewTextBoxColumn
            // 
            this.devicebuyDateDataGridViewTextBoxColumn.DataPropertyName = "device_buyDate";
            this.devicebuyDateDataGridViewTextBoxColumn.HeaderText = "วันที่ซื้อชิ้นส่วนโดรน";
            this.devicebuyDateDataGridViewTextBoxColumn.Name = "devicebuyDateDataGridViewTextBoxColumn";
            // 
            // deviceexpDateDataGridViewTextBoxColumn
            // 
            this.deviceexpDateDataGridViewTextBoxColumn.DataPropertyName = "device_expDate";
            this.deviceexpDateDataGridViewTextBoxColumn.HeaderText = "วันที่ชิ้นส่วนโดรนหมดอายุ";
            this.deviceexpDateDataGridViewTextBoxColumn.Name = "deviceexpDateDataGridViewTextBoxColumn";
            // 
            // devicestartDateDataGridViewTextBoxColumn
            // 
            this.devicestartDateDataGridViewTextBoxColumn.DataPropertyName = "device_startDate";
            this.devicestartDateDataGridViewTextBoxColumn.HeaderText = "วันที่เริ่มใช้งานชิ้นส่วนโดรน";
            this.devicestartDateDataGridViewTextBoxColumn.Name = "devicestartDateDataGridViewTextBoxColumn";
            // 
            // deviceresponderDataGridViewTextBoxColumn
            // 
            this.deviceresponderDataGridViewTextBoxColumn.DataPropertyName = "device_responder";
            this.deviceresponderDataGridViewTextBoxColumn.HeaderText = "ผู้ทำการจัดซื้อชิ้นส่วนโดรน";
            this.deviceresponderDataGridViewTextBoxColumn.Name = "deviceresponderDataGridViewTextBoxColumn";
            // 
            // devicealarmDataGridViewTextBoxColumn
            // 
            this.devicealarmDataGridViewTextBoxColumn.DataPropertyName = "device_alarm";
            this.devicealarmDataGridViewTextBoxColumn.HeaderText = "การแจ้งเตือนการบำรุงรักษาชิ้นส่วนโดรน";
            this.devicealarmDataGridViewTextBoxColumn.Name = "devicealarmDataGridViewTextBoxColumn";
            // 
            // vendernameDataGridViewTextBoxColumn
            // 
            this.vendernameDataGridViewTextBoxColumn.DataPropertyName = "vender_name";
            this.vendernameDataGridViewTextBoxColumn.HeaderText = "ชื่อตัวแทนจำหน่าย";
            this.vendernameDataGridViewTextBoxColumn.Name = "vendernameDataGridViewTextBoxColumn";
            // 
            // venderaddDataGridViewTextBoxColumn
            // 
            this.venderaddDataGridViewTextBoxColumn.DataPropertyName = "vender_add";
            this.venderaddDataGridViewTextBoxColumn.HeaderText = "ที่อยู่ตัวแทนจำหน่าย";
            this.venderaddDataGridViewTextBoxColumn.Name = "venderaddDataGridViewTextBoxColumn";
            // 
            // venderphoneDataGridViewTextBoxColumn
            // 
            this.venderphoneDataGridViewTextBoxColumn.DataPropertyName = "vender_phone";
            this.venderphoneDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์ตัวแทนจำหน่าย";
            this.venderphoneDataGridViewTextBoxColumn.Name = "venderphoneDataGridViewTextBoxColumn";
            // 
            // Form_Report_Drone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 346);
            this.Controls.Add(this.panel_Main_farm);
            this.Name = "Form_Report_Drone";
            this.Text = "รายงานโดรน";
            this.Load += new System.EventHandler(this.Form_Report_Drone_Load);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Noti)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button1;
        private Controls.MyDataGridView DG_Noti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.ComboBox comboBox_droneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_print;
        private DroneFlightPlannerDataSet8 droneFlightPlannerDataSet8;
        private System.Windows.Forms.BindingSource droneBindingSource;
        private DroneFlightPlannerDataSet8TableAdapters.DroneTableAdapter droneTableAdapter;
        private DroneFlightPlannerDataSet9 droneFlightPlannerDataSet9;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private DroneFlightPlannerDataSet9TableAdapters.DeviceListTableAdapter deviceListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicepositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicebuyDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceexpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicestartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceresponderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicealarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venderphoneDataGridViewTextBoxColumn;
    }
}