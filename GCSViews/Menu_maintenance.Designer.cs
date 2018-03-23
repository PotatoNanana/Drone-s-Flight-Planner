namespace MissionPlanner.GCSViews
{
    partial class Menu_maintenance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.button_show = new System.Windows.Forms.Button();
            this.button_serch = new System.Windows.Forms.Button();
            this.textBox_droneName = new System.Windows.Forms.TextBox();
            this.textBox_droneID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_detail = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.DG_Drone = new MissionPlanner.Controls.MyDataGridView();
            this.droneFlightPlannerDataSet = new MissionPlanner.DroneFlightPlannerDataSet();
            this.BUT_drone_add = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.droneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.droneTableAdapter = new MissionPlanner.DroneFlightPlannerDataSetTableAdapters.DroneTableAdapter();
            this.drone = new MissionPlanner.Drone();
            this.droneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.droneTableAdapter1 = new MissionPlanner.DroneTableAdapters.DroneTableAdapter();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dronenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Drone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource1)).BeginInit();
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
            this.panel_Main_farm.Controls.Add(this.button_show);
            this.panel_Main_farm.Controls.Add(this.button_serch);
            this.panel_Main_farm.Controls.Add(this.textBox_droneName);
            this.panel_Main_farm.Controls.Add(this.textBox_droneID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.button_edit);
            this.panel_Main_farm.Controls.Add(this.button_detail);
            this.panel_Main_farm.Controls.Add(this.button_delete);
            this.panel_Main_farm.Controls.Add(this.DG_Drone);
            this.panel_Main_farm.Controls.Add(this.BUT_drone_add);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14F);
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(700, 454);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint_1);
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show.ForeColor = System.Drawing.Color.White;
            this.button_show.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_show.Location = new System.Drawing.Point(531, 372);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(137, 48);
            this.button_show.TabIndex = 18;
            this.button_show.Text = "แสดงตาราง";
            this.button_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_serch
            // 
            this.button_serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_serch.FlatAppearance.BorderSize = 0;
            this.button_serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_serch.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_serch.ForeColor = System.Drawing.Color.White;
            this.button_serch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_serch.Location = new System.Drawing.Point(531, 223);
            this.button_serch.Name = "button_serch";
            this.button_serch.Size = new System.Drawing.Size(133, 48);
            this.button_serch.TabIndex = 17;
            this.button_serch.Text = "ค้นหาโดรน";
            this.button_serch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_serch.UseVisualStyleBackColor = false;
            this.button_serch.Click += new System.EventHandler(this.button_serch_Click);
            // 
            // textBox_droneName
            // 
            this.textBox_droneName.Location = new System.Drawing.Point(454, 153);
            this.textBox_droneName.Name = "textBox_droneName";
            this.textBox_droneName.Size = new System.Drawing.Size(200, 30);
            this.textBox_droneName.TabIndex = 16;
            // 
            // textBox_droneID
            // 
            this.textBox_droneID.Location = new System.Drawing.Point(454, 96);
            this.textBox_droneID.Name = "textBox_droneID";
            this.textBox_droneID.Size = new System.Drawing.Size(200, 30);
            this.textBox_droneID.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "ชื่อโดรน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "รหัสโดรน";
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_edit.Location = new System.Drawing.Point(531, 298);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(134, 48);
            this.button_edit.TabIndex = 12;
            this.button_edit.Text = "แก้ไขโดรน";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_detail
            // 
            this.button_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_detail.FlatAppearance.BorderSize = 0;
            this.button_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_detail.Font = new System.Drawing.Font("PJ Standard", 12F, System.Drawing.FontStyle.Bold);
            this.button_detail.ForeColor = System.Drawing.Color.White;
            this.button_detail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_detail.Location = new System.Drawing.Point(348, 224);
            this.button_detail.Name = "button_detail";
            this.button_detail.Size = new System.Drawing.Size(134, 48);
            this.button_detail.TabIndex = 10;
            this.button_detail.Text = "รายละเอียดส่วนประกอบ";
            this.button_detail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_detail.UseVisualStyleBackColor = false;
            this.button_detail.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.Location = new System.Drawing.Point(349, 298);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(133, 48);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "ลบโดรน";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // DG_Drone
            // 
            this.DG_Drone.AutoGenerateColumns = false;
            this.DG_Drone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Drone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Drone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.droneidDataGridViewTextBoxColumn,
            this.dronenameDataGridViewTextBoxColumn});
            this.DG_Drone.DataSource = this.droneBindingSource1;
            this.DG_Drone.Location = new System.Drawing.Point(25, 70);
            this.DG_Drone.Name = "DG_Drone";
            this.DG_Drone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Drone.Size = new System.Drawing.Size(298, 350);
            this.DG_Drone.TabIndex = 9;
            this.DG_Drone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Drone_CellContentClick);
            // 
            // droneFlightPlannerDataSet
            // 
            this.droneFlightPlannerDataSet.DataSetName = "DroneFlightPlannerDataSet";
            this.droneFlightPlannerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BUT_drone_add
            // 
            this.BUT_drone_add.BackColor = System.Drawing.Color.LimeGreen;
            this.BUT_drone_add.FlatAppearance.BorderSize = 0;
            this.BUT_drone_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_drone_add.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_drone_add.ForeColor = System.Drawing.Color.White;
            this.BUT_drone_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_drone_add.Location = new System.Drawing.Point(348, 372);
            this.BUT_drone_add.Name = "BUT_drone_add";
            this.BUT_drone_add.Size = new System.Drawing.Size(137, 48);
            this.BUT_drone_add.TabIndex = 6;
            this.BUT_drone_add.Text = "เพิ่มโดรน";
            this.BUT_drone_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_drone_add.UseVisualStyleBackColor = false;
            this.BUT_drone_add.Click += new System.EventHandler(this.BUT_add_drone_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(680, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(700, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // droneBindingSource
            // 
            this.droneBindingSource.DataMember = "Drone";
            this.droneBindingSource.DataSource = this.droneFlightPlannerDataSet;
            // 
            // droneTableAdapter
            // 
            this.droneTableAdapter.ClearBeforeFill = true;
            // 
            // drone
            // 
            this.drone.DataSetName = "Drone";
            this.drone.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // droneBindingSource1
            // 
            this.droneBindingSource1.DataMember = "Drone";
            this.droneBindingSource1.DataSource = this.drone;
            // 
            // droneTableAdapter1
            // 
            this.droneTableAdapter1.ClearBeforeFill = true;
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "รหัสโดรน";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
            // 
            // dronenameDataGridViewTextBoxColumn
            // 
            this.dronenameDataGridViewTextBoxColumn.DataPropertyName = "drone_name";
            this.dronenameDataGridViewTextBoxColumn.HeaderText = "ชื่อโดรน";
            this.dronenameDataGridViewTextBoxColumn.Name = "dronenameDataGridViewTextBoxColumn";
            // 
            // Menu_maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Menu_maintenance";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel2.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Drone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneFlightPlannerDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Drone;
        private System.Windows.Forms.Button BUT_drone_add;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.BindingSource droneBindingSource;
        private DroneFlightPlannerDataSet droneFlightPlannerDataSet;
        private DroneFlightPlannerDataSetTableAdapters.DroneTableAdapter droneTableAdapter;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_droneID;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_serch;
        private System.Windows.Forms.TextBox textBox_droneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dronenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource droneBindingSource1;
        private Drone drone;
        private DroneTableAdapters.DroneTableAdapter droneTableAdapter1;
    }
}
