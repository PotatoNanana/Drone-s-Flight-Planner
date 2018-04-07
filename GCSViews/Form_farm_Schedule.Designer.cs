namespace MissionPlanner.GCSViews
{
    partial class Form_farm_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_farm_Schedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_actName = new System.Windows.Forms.TextBox();
            this.textBox_actID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.But_exit = new System.Windows.Forms.Button();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightSchedule2 = new MissionPlanner.FlightSchedule2();
            this.But_add_act = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.flightScheduleTableAdapter = new MissionPlanner.FlightSchedule2TableAdapters.FlightScheduleTableAdapter();
            this.actiondatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.button_edit);
            this.panel_Main_farm.Controls.Add(this.button_delete);
            this.panel_Main_farm.Controls.Add(this.textBox_actName);
            this.panel_Main_farm.Controls.Add(this.textBox_actID);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.button_show);
            this.panel_Main_farm.Controls.Add(this.But_exit);
            this.panel_Main_farm.Controls.Add(this.DG_Farm);
            this.panel_Main_farm.Controls.Add(this.But_add_act);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(968, 426);
            this.panel_Main_farm.TabIndex = 10;
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
            this.button_edit.Location = new System.Drawing.Point(801, 222);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(130, 40);
            this.button_edit.TabIndex = 25;
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
            this.button_delete.Location = new System.Drawing.Point(632, 222);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(130, 40);
            this.button_delete.TabIndex = 24;
            this.button_delete.Text = "ลบ";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_actName
            // 
            this.textBox_actName.Location = new System.Drawing.Point(744, 156);
            this.textBox_actName.Name = "textBox_actName";
            this.textBox_actName.Size = new System.Drawing.Size(187, 31);
            this.textBox_actName.TabIndex = 23;
            this.textBox_actName.TextChanged += new System.EventHandler(this.textBox_actName_TextChanged);
            // 
            // textBox_actID
            // 
            this.textBox_actID.Location = new System.Drawing.Point(744, 99);
            this.textBox_actID.Name = "textBox_actID";
            this.textBox_actID.Size = new System.Drawing.Size(187, 31);
            this.textBox_actID.TabIndex = 22;
            this.textBox_actID.TextChanged += new System.EventHandler(this.textBox_actID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "ชื่อกิจกรรม";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "รหัสกิจกรรม";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_show.FlatAppearance.BorderSize = 0;
            this.button_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_show.ForeColor = System.Drawing.Color.White;
            this.button_show.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_show.Location = new System.Drawing.Point(632, 289);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(130, 40);
            this.button_show.TabIndex = 19;
            this.button_show.Text = "แสดงตาราง";
            this.button_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // But_exit
            // 
            this.But_exit.BackColor = System.Drawing.Color.Tomato;
            this.But_exit.FlatAppearance.BorderSize = 0;
            this.But_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_exit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_exit.ForeColor = System.Drawing.Color.White;
            this.But_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_exit.Location = new System.Drawing.Point(710, 353);
            this.But_exit.Name = "But_exit";
            this.But_exit.Size = new System.Drawing.Size(130, 40);
            this.But_exit.TabIndex = 10;
            this.But_exit.Text = "ปิด";
            this.But_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_exit.UseVisualStyleBackColor = false;
            this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actiondatetimeDataGridViewTextBoxColumn,
            this.droneidDataGridViewTextBoxColumn,
            this.actionnoDataGridViewTextBoxColumn,
            this.actionnameDataGridViewTextBoxColumn,
            this.actioncapacityDataGridViewTextBoxColumn,
            this.actioncostDataGridViewTextBoxColumn});
            this.DG_Farm.DataSource = this.flightScheduleBindingSource;
            this.DG_Farm.Location = new System.Drawing.Point(25, 75);
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.Size = new System.Drawing.Size(562, 333);
            this.DG_Farm.TabIndex = 9;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Farm_CellContentClick);
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
            // But_add_act
            // 
            this.But_add_act.BackColor = System.Drawing.Color.LimeGreen;
            this.But_add_act.FlatAppearance.BorderSize = 0;
            this.But_add_act.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_add_act.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_add_act.ForeColor = System.Drawing.Color.White;
            this.But_add_act.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_add_act.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_add_act.Location = new System.Drawing.Point(801, 289);
            this.But_add_act.Name = "But_add_act";
            this.But_add_act.Size = new System.Drawing.Size(130, 40);
            this.But_add_act.TabIndex = 6;
            this.But_add_act.Text = "เพิ่มกิจกรรม";
            this.But_add_act.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_add_act.UseVisualStyleBackColor = false;
            this.But_add_act.Click += new System.EventHandler(this.But_add_act_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(968, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "ตารางปฏิทินการบินที่กำลังจะเกิด";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // flightScheduleTableAdapter
            // 
            this.flightScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // actiondatetimeDataGridViewTextBoxColumn
            // 
            this.actiondatetimeDataGridViewTextBoxColumn.DataPropertyName = "action_datetime";
            this.actiondatetimeDataGridViewTextBoxColumn.HeaderText = "วันที่";
            this.actiondatetimeDataGridViewTextBoxColumn.Name = "actiondatetimeDataGridViewTextBoxColumn";
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            this.droneidDataGridViewTextBoxColumn.HeaderText = "รหัสโดรน";
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
            // 
            // actionnoDataGridViewTextBoxColumn
            // 
            this.actionnoDataGridViewTextBoxColumn.DataPropertyName = "action_no";
            this.actionnoDataGridViewTextBoxColumn.HeaderText = "เลขที่กิจกรรม";
            this.actionnoDataGridViewTextBoxColumn.Name = "actionnoDataGridViewTextBoxColumn";
            // 
            // actionnameDataGridViewTextBoxColumn
            // 
            this.actionnameDataGridViewTextBoxColumn.DataPropertyName = "action_name";
            this.actionnameDataGridViewTextBoxColumn.HeaderText = "ชื่อกิจกรรม";
            this.actionnameDataGridViewTextBoxColumn.Name = "actionnameDataGridViewTextBoxColumn";
            // 
            // actioncapacityDataGridViewTextBoxColumn
            // 
            this.actioncapacityDataGridViewTextBoxColumn.DataPropertyName = "action_capacity";
            this.actioncapacityDataGridViewTextBoxColumn.HeaderText = "ปริมาณสาร";
            this.actioncapacityDataGridViewTextBoxColumn.Name = "actioncapacityDataGridViewTextBoxColumn";
            // 
            // actioncostDataGridViewTextBoxColumn
            // 
            this.actioncostDataGridViewTextBoxColumn.DataPropertyName = "action_cost";
            this.actioncostDataGridViewTextBoxColumn.HeaderText = "ค่าใช้จ่าย";
            this.actioncostDataGridViewTextBoxColumn.Name = "actioncostDataGridViewTextBoxColumn";
            // 
            // Form_farm_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 426);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_farm_Schedule";
            this.Text = "Flight Schedule";
            this.Load += new System.EventHandler(this.Form_farm_Schedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightSchedule2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Button But_exit;
        private Controls.MyDataGridView DG_Farm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Button But_add_act;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_actName;
        private System.Windows.Forms.TextBox textBox_actID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private FlightSchedule2 flightSchedule2;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private FlightSchedule2TableAdapters.FlightScheduleTableAdapter flightScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiondatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actioncostDataGridViewTextBoxColumn;
    }
}