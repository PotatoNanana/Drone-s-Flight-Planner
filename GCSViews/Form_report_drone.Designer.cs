namespace MissionPlanner.GCSViews
{
    partial class Form_report_drone
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_alarm = new System.Windows.Forms.ComboBox();
            this.droneFlightPlanner1DataSet_droneID = new MissionPlanner.DroneFlightPlanner1DataSet_droneID();
            this.droneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneTableAdapter = new MissionPlanner.DroneFlightPlanner1DataSet_droneIDTableAdapters.DroneTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.But_save = new System.Windows.Forms.Button();
            this.droneFlightPlanner1DataSet_device = new MissionPlanner.DroneFlightPlanner1DataSet_device();
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListTableAdapter = new MissionPlanner.DroneFlightPlanner1DataSet_deviceTableAdapters.DeviceListTableAdapter();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlanner1DataSet_droneID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlanner1DataSet_device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "ชื่อโดรน";
            // 
            // comboBox_alarm
            // 
            this.comboBox_alarm.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.droneBindingSource, "drone_id", true));
            this.comboBox_alarm.DataSource = this.droneBindingSource;
            this.comboBox_alarm.DisplayMember = "drone_name";
            this.comboBox_alarm.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.comboBox_alarm.FormattingEnabled = true;
            this.comboBox_alarm.Location = new System.Drawing.Point(126, 19);
            this.comboBox_alarm.Name = "comboBox_alarm";
            this.comboBox_alarm.Size = new System.Drawing.Size(223, 34);
            this.comboBox_alarm.TabIndex = 74;
            this.comboBox_alarm.ValueMember = "drone_id";
            // 
            // droneFlightPlanner1DataSet_droneID
            // 
            this.droneFlightPlanner1DataSet_droneID.DataSetName = "DroneFlightPlanner1DataSet_droneID";
            this.droneFlightPlanner1DataSet_droneID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // droneBindingSource
            // 
            this.droneBindingSource.DataMember = "Drone";
            this.droneBindingSource.DataSource = this.droneFlightPlanner1DataSet_droneID;
            // 
            // droneTableAdapter
            // 
            this.droneTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 75;
            this.label2.Text = "รายการ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.droneBindingSource, "drone_id", true));
            this.comboBox1.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "รายละเอียดชิ้นส่วนโดรน",
            "รายละเอียดการบำรุงรักษาชิ้นส่วนโดรน"});
            this.comboBox1.Location = new System.Drawing.Point(126, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 34);
            this.comboBox1.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "ชิ้นส่วนโดรน";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deviceListBindingSource, "device_id", true));
            this.comboBox2.DataSource = this.deviceListBindingSource;
            this.comboBox2.DisplayMember = "device_name";
            this.comboBox2.Font = new System.Drawing.Font("PJ Standard", 16F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 34);
            this.comboBox2.TabIndex = 78;
            this.comboBox2.ValueMember = "device_id";
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
            this.But_save.Location = new System.Drawing.Point(377, 234);
            this.But_save.Name = "But_save";
            this.But_save.Size = new System.Drawing.Size(130, 40);
            this.But_save.TabIndex = 79;
            this.But_save.Text = "สั่งพิมพ์";
            this.But_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_save.UseVisualStyleBackColor = false;
            // 
            // droneFlightPlanner1DataSet_device
            // 
            this.droneFlightPlanner1DataSet_device.DataSetName = "DroneFlightPlanner1DataSet_device";
            this.droneFlightPlanner1DataSet_device.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceListBindingSource
            // 
            this.deviceListBindingSource.DataMember = "DeviceList";
            this.deviceListBindingSource.DataSource = this.droneFlightPlanner1DataSet_device;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // DG_Farm
            // 
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Location = new System.Drawing.Point(396, 19);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(449, 185);
            this.DG_Farm.TabIndex = 80;
            // 
            // Form_report_drone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 298);
            this.Controls.Add(this.DG_Farm);
            this.Controls.Add(this.But_save);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_alarm);
            this.Controls.Add(this.label1);
            this.Name = "Form_report_drone";
            this.Text = "รายงานเกี่ยวกับโดรน";
            this.Load += new System.EventHandler(this.Form_report_drone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlanner1DataSet_droneID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlanner1DataSet_device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_alarm;
        private DroneFlightPlanner1DataSet_droneID droneFlightPlanner1DataSet_droneID;
        private System.Windows.Forms.BindingSource droneBindingSource;
        private DroneFlightPlanner1DataSet_droneIDTableAdapters.DroneTableAdapter droneTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button But_save;
        private DroneFlightPlanner1DataSet_device droneFlightPlanner1DataSet_device;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private DroneFlightPlanner1DataSet_deviceTableAdapters.DeviceListTableAdapter deviceListTableAdapter;
        private Controls.MyDataGridView DG_Farm;
    }
}