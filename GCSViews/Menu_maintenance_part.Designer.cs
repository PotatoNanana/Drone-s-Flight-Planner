namespace MissionPlanner.GCSViews
{
    partial class Menu_maintenance_part
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_maintenance_part));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_partName = new System.Windows.Forms.TextBox();
            this.textBox_partID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_backto_pre = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
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
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEVICE_LIST = new MissionPlanner.DEVICE_LIST();
            this.BUT_add_drone_part = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.droneFlightPlannerDataSet = new MissionPlanner.DroneFlightPlannerDataSet();
            this.droneFlightPlannerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListTableAdapter = new MissionPlanner.DEVICE_LISTTableAdapters.DeviceListTableAdapter();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICE_LIST)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSetBindingSource)).BeginInit();
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
            this.panel_Main_farm.Controls.Add(this.label3);
            this.panel_Main_farm.Controls.Add(this.pictureBox);
            this.panel_Main_farm.Controls.Add(this.textBox_partName);
            this.panel_Main_farm.Controls.Add(this.textBox_partID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.but_backto_pre);
            this.panel_Main_farm.Controls.Add(this.button_edit);
            this.panel_Main_farm.Controls.Add(this.button_delete);
            this.panel_Main_farm.Controls.Add(this.button1);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.BUT_add_drone_part);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1259, 500);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMaintenance_pre_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label3.Location = new System.Drawing.Point(828, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "รูปชิ้นส่วน";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(932, 185);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(130, 115);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 35;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // textBox_partName
            // 
            this.textBox_partName.Location = new System.Drawing.Point(932, 131);
            this.textBox_partName.Name = "textBox_partName";
            this.textBox_partName.Size = new System.Drawing.Size(187, 28);
            this.textBox_partName.TabIndex = 34;
            // 
            // textBox_partID
            // 
            this.textBox_partID.Location = new System.Drawing.Point(932, 70);
            this.textBox_partID.Name = "textBox_partID";
            this.textBox_partID.Size = new System.Drawing.Size(187, 28);
            this.textBox_partID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label2.Location = new System.Drawing.Point(828, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "ชื่อชิ้นส่วน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label1.Location = new System.Drawing.Point(828, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "รหัสชิ้นส่วน";
            // 
            // but_backto_pre
            // 
            this.but_backto_pre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.but_backto_pre.FlatAppearance.BorderSize = 0;
            this.but_backto_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_backto_pre.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_backto_pre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_backto_pre.Location = new System.Drawing.Point(25, 443);
            this.but_backto_pre.Name = "but_backto_pre";
            this.but_backto_pre.Size = new System.Drawing.Size(70, 40);
            this.but_backto_pre.TabIndex = 10;
            this.but_backto_pre.Text = "< กลับ";
            this.but_backto_pre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_backto_pre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_backto_pre.UseVisualStyleBackColor = false;
            this.but_backto_pre.Click += new System.EventHandler(this.but_backto_pre_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_edit.Location = new System.Drawing.Point(932, 384);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(130, 40);
            this.button_edit.TabIndex = 27;
            this.button_edit.Text = "แก้ไข";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_delete.Location = new System.Drawing.Point(932, 430);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(130, 40);
            this.button_delete.TabIndex = 26;
            this.button_delete.Text = "ลบ";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("PJ Standard", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1089, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "ข้อมูลการบำรุงรักษาอุปกรณ์";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DG_Farm.DataSource = this.deviceListBindingSource;
            this.DG_Farm.Location = new System.Drawing.Point(25, 70);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(757, 350);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
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
            this.deviceexpDateDataGridViewTextBoxColumn.HeaderText = "วันที่ชิ้นส่วนโดรนครบกำหนดอายุการใช้งาน";
            this.deviceexpDateDataGridViewTextBoxColumn.Name = "deviceexpDateDataGridViewTextBoxColumn";
            // 
            // devicestartDateDataGridViewTextBoxColumn
            // 
            this.devicestartDateDataGridViewTextBoxColumn.DataPropertyName = "device_startDate";
            this.devicestartDateDataGridViewTextBoxColumn.HeaderText = "วันที่เริ่มใช้ชิ้นส่วนโดรน";
            this.devicestartDateDataGridViewTextBoxColumn.Name = "devicestartDateDataGridViewTextBoxColumn";
            // 
            // deviceresponderDataGridViewTextBoxColumn
            // 
            this.deviceresponderDataGridViewTextBoxColumn.DataPropertyName = "device_responder";
            this.deviceresponderDataGridViewTextBoxColumn.HeaderText = "ผู้ติดต่อกับคนขายชิ้นส่วนโดรน";
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
            this.vendernameDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ขาย";
            this.vendernameDataGridViewTextBoxColumn.Name = "vendernameDataGridViewTextBoxColumn";
            // 
            // venderaddDataGridViewTextBoxColumn
            // 
            this.venderaddDataGridViewTextBoxColumn.DataPropertyName = "vender_add";
            this.venderaddDataGridViewTextBoxColumn.HeaderText = "ที่อยู่ผู้ขาย";
            this.venderaddDataGridViewTextBoxColumn.Name = "venderaddDataGridViewTextBoxColumn";
            // 
            // venderphoneDataGridViewTextBoxColumn
            // 
            this.venderphoneDataGridViewTextBoxColumn.DataPropertyName = "vender_phone";
            this.venderphoneDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์ผู้ขาย";
            this.venderphoneDataGridViewTextBoxColumn.Name = "venderphoneDataGridViewTextBoxColumn";
            // 
            // deviceListBindingSource
            // 
            this.deviceListBindingSource.DataMember = "DeviceList";
            this.deviceListBindingSource.DataSource = this.dEVICE_LIST;
            // 
            // dEVICE_LIST
            // 
            this.dEVICE_LIST.DataSetName = "DEVICE_LIST";
            this.dEVICE_LIST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BUT_add_drone_part
            // 
            this.BUT_add_drone_part.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_add_drone_part.FlatAppearance.BorderSize = 0;
            this.BUT_add_drone_part.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_add_drone_part.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_add_drone_part.ForeColor = System.Drawing.Color.White;
            this.BUT_add_drone_part.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_add_drone_part.Location = new System.Drawing.Point(932, 338);
            this.BUT_add_drone_part.Name = "BUT_add_drone_part";
            this.BUT_add_drone_part.Size = new System.Drawing.Size(130, 40);
            this.BUT_add_drone_part.TabIndex = 6;
            this.BUT_add_drone_part.Text = "เพิ่มส่วนประกอบ";
            this.BUT_add_drone_part.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_add_drone_part.UseVisualStyleBackColor = false;
            this.BUT_add_drone_part.Click += new System.EventHandler(this.BUT_add_drone_part_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 42);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(1163, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1259, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1259, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลส่วนประกอบภายในโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // droneFlightPlannerDataSet
            // 
            this.droneFlightPlannerDataSet.DataSetName = "DroneFlightPlannerDataSet";
            this.droneFlightPlannerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // droneFlightPlannerDataSetBindingSource
            // 
            this.droneFlightPlannerDataSetBindingSource.DataSource = this.droneFlightPlannerDataSet;
            this.droneFlightPlannerDataSetBindingSource.Position = 0;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // Menu_maintenance_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Menu_maintenance_part";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel2.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICE_LIST)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Button BUT_add_drone_part;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button but_backto_pre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_partName;
        private System.Windows.Forms.TextBox textBox_partID;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private DEVICE_LIST dEVICE_LIST;
        private DroneFlightPlannerDataSet droneFlightPlannerDataSet;
        private System.Windows.Forms.BindingSource droneFlightPlannerDataSetBindingSource;
        private DEVICE_LISTTableAdapters.DeviceListTableAdapter deviceListTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
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
