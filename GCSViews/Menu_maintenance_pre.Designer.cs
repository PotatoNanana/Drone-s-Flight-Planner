namespace MissionPlanner.GCSViews
{
    partial class Menu_maintenance_pre
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
            this.but_backto_pre = new System.Windows.Forms.Button();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.textBox_mainAct = new System.Windows.Forms.TextBox();
            this.textBox_mainID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.maintainidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainactivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintaindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainlengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainresponderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainvenderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainvenderAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainvenderPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintainanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintainace = new MissionPlanner.maintainace();
            this.BUT_add_drone_pre = new System.Windows.Forms.Button();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.maintainanceTableAdapter = new MissionPlanner.maintainaceTableAdapters.MaintainanceTableAdapter();
            this.panel2.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainace)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.but_backto_pre);
            this.panel2.Controls.Add(this.panel_Main_farm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 768);
            this.panel2.TabIndex = 1;
            // 
            // but_backto_pre
            // 
            this.but_backto_pre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.but_backto_pre.FlatAppearance.BorderSize = 0;
            this.but_backto_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_backto_pre.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_backto_pre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_backto_pre.Location = new System.Drawing.Point(60, 515);
            this.but_backto_pre.Name = "but_backto_pre";
            this.but_backto_pre.Size = new System.Drawing.Size(70, 40);
            this.but_backto_pre.TabIndex = 10;
            this.but_backto_pre.Text = "< กลับ";
            this.but_backto_pre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_backto_pre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.but_backto_pre.UseVisualStyleBackColor = false;
            this.but_backto_pre.Click += new System.EventHandler(this.but_backto_pre_Click);
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.textBox_mainAct);
            this.panel_Main_farm.Controls.Add(this.textBox_mainID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.button_edit);
            this.panel_Main_farm.Controls.Add(this.button_delete);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.BUT_add_drone_pre);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Main_farm.Location = new System.Drawing.Point(60, 40);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(1266, 450);
            this.panel_Main_farm.TabIndex = 8;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMaintenance_pre_Paint);
            // 
            // textBox_mainAct
            // 
            this.textBox_mainAct.Location = new System.Drawing.Point(1034, 147);
            this.textBox_mainAct.Name = "textBox_mainAct";
            this.textBox_mainAct.Size = new System.Drawing.Size(187, 31);
            this.textBox_mainAct.TabIndex = 37;
            // 
            // textBox_mainID
            // 
            this.textBox_mainID.Location = new System.Drawing.Point(1034, 82);
            this.textBox_mainID.Name = "textBox_mainID";
            this.textBox_mainID.Size = new System.Drawing.Size(187, 31);
            this.textBox_mainID.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label2.Location = new System.Drawing.Point(872, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "ชื่อกิจกรรมการซ่อมบำรุง";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.label1.Location = new System.Drawing.Point(872, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "หมายเลขการซ่อมบำรุง";
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
            this.button_edit.Location = new System.Drawing.Point(986, 269);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(130, 40);
            this.button_edit.TabIndex = 32;
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
            this.button_delete.Location = new System.Drawing.Point(986, 315);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(130, 40);
            this.button_delete.TabIndex = 31;
            this.button_delete.Text = "ลบ";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maintainidDataGridViewTextBoxColumn,
            this.maintainactivityDataGridViewTextBoxColumn,
            this.maintaindateDataGridViewTextBoxColumn,
            this.maintainpriceDataGridViewTextBoxColumn,
            this.maintainlengthDataGridViewTextBoxColumn,
            this.maintainresponderDataGridViewTextBoxColumn,
            this.maintainvenderNameDataGridViewTextBoxColumn,
            this.maintainvenderAddDataGridViewTextBoxColumn,
            this.maintainvenderPhoneDataGridViewTextBoxColumn});
            this.DG_Farm.DataSource = this.maintainanceBindingSource;
            this.DG_Farm.Location = new System.Drawing.Point(25, 70);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(831, 350);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
            // 
            // maintainidDataGridViewTextBoxColumn
            // 
            this.maintainidDataGridViewTextBoxColumn.DataPropertyName = "maintain_id";
            this.maintainidDataGridViewTextBoxColumn.HeaderText = "หมายเลขการซ่อมบำรุง";
            this.maintainidDataGridViewTextBoxColumn.Name = "maintainidDataGridViewTextBoxColumn";
            // 
            // maintainactivityDataGridViewTextBoxColumn
            // 
            this.maintainactivityDataGridViewTextBoxColumn.DataPropertyName = "maintain_activity";
            this.maintainactivityDataGridViewTextBoxColumn.HeaderText = "ชื่อกิจกรรมการซ่อมบำรุง";
            this.maintainactivityDataGridViewTextBoxColumn.Name = "maintainactivityDataGridViewTextBoxColumn";
            // 
            // maintaindateDataGridViewTextBoxColumn
            // 
            this.maintaindateDataGridViewTextBoxColumn.DataPropertyName = "maintain_date";
            this.maintaindateDataGridViewTextBoxColumn.HeaderText = "วันที่ทำการซ่อมบำรุง";
            this.maintaindateDataGridViewTextBoxColumn.Name = "maintaindateDataGridViewTextBoxColumn";
            // 
            // maintainpriceDataGridViewTextBoxColumn
            // 
            this.maintainpriceDataGridViewTextBoxColumn.DataPropertyName = "maintain_price";
            this.maintainpriceDataGridViewTextBoxColumn.HeaderText = "ราคาการซ่อมบำรุง";
            this.maintainpriceDataGridViewTextBoxColumn.Name = "maintainpriceDataGridViewTextBoxColumn";
            // 
            // maintainlengthDataGridViewTextBoxColumn
            // 
            this.maintainlengthDataGridViewTextBoxColumn.DataPropertyName = "maintain_length";
            this.maintainlengthDataGridViewTextBoxColumn.HeaderText = "ระยะเวลาการซ่อมบำรุง";
            this.maintainlengthDataGridViewTextBoxColumn.Name = "maintainlengthDataGridViewTextBoxColumn";
            // 
            // maintainresponderDataGridViewTextBoxColumn
            // 
            this.maintainresponderDataGridViewTextBoxColumn.DataPropertyName = "maintain_responder";
            this.maintainresponderDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ติดต่อกับตัวแทนการซ่อมบำรุง";
            this.maintainresponderDataGridViewTextBoxColumn.Name = "maintainresponderDataGridViewTextBoxColumn";
            // 
            // maintainvenderNameDataGridViewTextBoxColumn
            // 
            this.maintainvenderNameDataGridViewTextBoxColumn.DataPropertyName = "maintain_venderName";
            this.maintainvenderNameDataGridViewTextBoxColumn.HeaderText = "ชื่อตัวแทนการซ่อมบำรุง";
            this.maintainvenderNameDataGridViewTextBoxColumn.Name = "maintainvenderNameDataGridViewTextBoxColumn";
            // 
            // maintainvenderAddDataGridViewTextBoxColumn
            // 
            this.maintainvenderAddDataGridViewTextBoxColumn.DataPropertyName = "maintain_venderAdd";
            this.maintainvenderAddDataGridViewTextBoxColumn.HeaderText = "ที่อยู่ตัวแทนการซ่อมบำรุง";
            this.maintainvenderAddDataGridViewTextBoxColumn.Name = "maintainvenderAddDataGridViewTextBoxColumn";
            // 
            // maintainvenderPhoneDataGridViewTextBoxColumn
            // 
            this.maintainvenderPhoneDataGridViewTextBoxColumn.DataPropertyName = "maintain_venderPhone";
            this.maintainvenderPhoneDataGridViewTextBoxColumn.HeaderText = "เบอร์โทรศัพท์ตัวแทนการซ่อมบำรุง";
            this.maintainvenderPhoneDataGridViewTextBoxColumn.Name = "maintainvenderPhoneDataGridViewTextBoxColumn";
            // 
            // maintainanceBindingSource
            // 
            this.maintainanceBindingSource.DataMember = "Maintainance";
            this.maintainanceBindingSource.DataSource = this.maintainace;
            // 
            // maintainace
            // 
            this.maintainace.DataSetName = "maintainace";
            this.maintainace.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BUT_add_drone_pre
            // 
            this.BUT_add_drone_pre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_add_drone_pre.FlatAppearance.BorderSize = 0;
            this.BUT_add_drone_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_add_drone_pre.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_add_drone_pre.ForeColor = System.Drawing.Color.White;
            this.BUT_add_drone_pre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUT_add_drone_pre.Location = new System.Drawing.Point(986, 223);
            this.BUT_add_drone_pre.Name = "BUT_add_drone_pre";
            this.BUT_add_drone_pre.Size = new System.Drawing.Size(130, 40);
            this.BUT_add_drone_pre.TabIndex = 6;
            this.BUT_add_drone_pre.Text = "เพิ่มข้อมูล";
            this.BUT_add_drone_pre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_add_drone_pre.UseVisualStyleBackColor = false;
            this.BUT_add_drone_pre.Click += new System.EventHandler(this.BUT_add_drone_pre_Click);
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.Location = new System.Drawing.Point(10, 50);
            this.lineSeparator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator2.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.lineSeparator2.Size = new System.Drawing.Size(1194, 2);
            this.lineSeparator2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1266, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(1266, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ข้อมูลการบำรุงรักษาชิ้นส่วนภายในโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseVisualStyleBackColor = false;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // maintainanceTableAdapter
            // 
            this.maintainanceTableAdapter.ClearBeforeFill = true;
            // 
            // Menu_maintenance_pre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Menu_maintenance_pre";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel2.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintainace)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Main_farm;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Button BUT_add_drone_pre;
        private Controls.LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button but_backto_pre;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_mainID;
        private System.Windows.Forms.TextBox textBox_mainAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainactivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintaindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainlengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainresponderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainvenderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainvenderAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintainvenderPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource maintainanceBindingSource;
        private maintainace maintainace;
        private maintainaceTableAdapters.MaintainanceTableAdapter maintainanceTableAdapter;
    }
}
