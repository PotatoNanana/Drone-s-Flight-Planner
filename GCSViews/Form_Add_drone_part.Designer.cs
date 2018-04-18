namespace MissionPlanner.GCSViews
{
    partial class Form_Add_drone_part
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_drone_part));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.comboBox_alarm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_serch = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_ExpDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_reg = new System.Windows.Forms.DateTimePicker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_respond = new System.Windows.Forms.TextBox();
            this.textBox_venAdd = new System.Windows.Forms.TextBox();
            this.textBox_venPhone = new System.Windows.Forms.TextBox();
            this.textBox_VenName = new System.Windows.Forms.TextBox();
            this.textBox_partName = new System.Windows.Forms.TextBox();
            this.textBox_partPosition = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_partID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.But_exit = new System.Windows.Forms.Button();
            this.But_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Main_farm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.comboBox_alarm);
            this.panel_Main_farm.Controls.Add(this.label7);
            this.panel_Main_farm.Controls.Add(this.button_serch);
            this.panel_Main_farm.Controls.Add(this.pictureBox);
            this.panel_Main_farm.Controls.Add(this.dateTimePicker_ExpDate);
            this.panel_Main_farm.Controls.Add(this.dateTimePicker_startDate);
            this.panel_Main_farm.Controls.Add(this.dateTimePicker_reg);
            this.panel_Main_farm.Controls.Add(this.textBox7);
            this.panel_Main_farm.Controls.Add(this.textBox_price);
            this.panel_Main_farm.Controls.Add(this.textBox_respond);
            this.panel_Main_farm.Controls.Add(this.textBox_venAdd);
            this.panel_Main_farm.Controls.Add(this.textBox_venPhone);
            this.panel_Main_farm.Controls.Add(this.textBox_VenName);
            this.panel_Main_farm.Controls.Add(this.textBox_partName);
            this.panel_Main_farm.Controls.Add(this.textBox_partPosition);
            this.panel_Main_farm.Controls.Add(this.label15);
            this.panel_Main_farm.Controls.Add(this.textBox_partID);
            this.panel_Main_farm.Controls.Add(this.label6);
            this.panel_Main_farm.Controls.Add(this.label14);
            this.panel_Main_farm.Controls.Add(this.label13);
            this.panel_Main_farm.Controls.Add(this.label5);
            this.panel_Main_farm.Controls.Add(this.label12);
            this.panel_Main_farm.Controls.Add(this.label4);
            this.panel_Main_farm.Controls.Add(this.label11);
            this.panel_Main_farm.Controls.Add(this.label3);
            this.panel_Main_farm.Controls.Add(this.label10);
            this.panel_Main_farm.Controls.Add(this.label2);
            this.panel_Main_farm.Controls.Add(this.label1);
            this.panel_Main_farm.Controls.Add(this.But_exit);
            this.panel_Main_farm.Controls.Add(this.But_save);
            this.panel_Main_farm.Controls.Add(this.panel3);
            this.panel_Main_farm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main_farm.Font = new System.Drawing.Font("PJ Standard", 14.25F);
            this.panel_Main_farm.Location = new System.Drawing.Point(0, 0);
            this.panel_Main_farm.Name = "panel_Main_farm";
            this.panel_Main_farm.Size = new System.Drawing.Size(914, 461);
            this.panel_Main_farm.TabIndex = 10;
            this.panel_Main_farm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Main_farm_Paint);
            // 
            // comboBox_alarm
            // 
            this.comboBox_alarm.FormattingEnabled = true;
            this.comboBox_alarm.Items.AddRange(new object[] {
            "ทุกวัน",
            "ทุกอาทิตย์",
            "ทุกเดือน",
            "ทุก1ปี"});
            this.comboBox_alarm.Location = new System.Drawing.Point(217, 321);
            this.comboBox_alarm.Name = "comboBox_alarm";
            this.comboBox_alarm.Size = new System.Drawing.Size(200, 32);
            this.comboBox_alarm.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "แจ้งเตือนการบำรุงรักษา";
            // 
            // button_serch
            // 
            this.button_serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.button_serch.FlatAppearance.BorderSize = 0;
            this.button_serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_serch.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_serch.ForeColor = System.Drawing.Color.White;
            this.button_serch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_serch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_serch.Location = new System.Drawing.Point(760, 340);
            this.button_serch.Name = "button_serch";
            this.button_serch.Size = new System.Drawing.Size(80, 40);
            this.button_serch.TabIndex = 16;
            this.button_serch.Text = "อัพโหลด";
            this.button_serch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_serch.UseVisualStyleBackColor = false;
            this.button_serch.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(640, 280);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // dateTimePicker_ExpDate
            // 
            this.dateTimePicker_ExpDate.Location = new System.Drawing.Point(217, 235);
            this.dateTimePicker_ExpDate.Name = "dateTimePicker_ExpDate";
            this.dateTimePicker_ExpDate.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker_ExpDate.TabIndex = 14;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(217, 195);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker_startDate.TabIndex = 14;
            // 
            // dateTimePicker_reg
            // 
            this.dateTimePicker_reg.Location = new System.Drawing.Point(217, 155);
            this.dateTimePicker_reg.Name = "dateTimePicker_reg";
            this.dateTimePicker_reg.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker_reg.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(217, 317);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(0, 31);
            this.textBox7.TabIndex = 13;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(217, 277);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(200, 31);
            this.textBox_price.TabIndex = 13;
            // 
            // textBox_respond
            // 
            this.textBox_respond.Location = new System.Drawing.Point(640, 237);
            this.textBox_respond.Name = "textBox_respond";
            this.textBox_respond.Size = new System.Drawing.Size(200, 31);
            this.textBox_respond.TabIndex = 13;
            // 
            // textBox_venAdd
            // 
            this.textBox_venAdd.Location = new System.Drawing.Point(640, 197);
            this.textBox_venAdd.Name = "textBox_venAdd";
            this.textBox_venAdd.Size = new System.Drawing.Size(200, 31);
            this.textBox_venAdd.TabIndex = 13;
            // 
            // textBox_venPhone
            // 
            this.textBox_venPhone.Location = new System.Drawing.Point(640, 157);
            this.textBox_venPhone.Name = "textBox_venPhone";
            this.textBox_venPhone.Size = new System.Drawing.Size(200, 31);
            this.textBox_venPhone.TabIndex = 13;
            // 
            // textBox_VenName
            // 
            this.textBox_VenName.Location = new System.Drawing.Point(640, 117);
            this.textBox_VenName.Name = "textBox_VenName";
            this.textBox_VenName.Size = new System.Drawing.Size(200, 31);
            this.textBox_VenName.TabIndex = 13;
            // 
            // textBox_partName
            // 
            this.textBox_partName.Location = new System.Drawing.Point(640, 77);
            this.textBox_partName.Name = "textBox_partName";
            this.textBox_partName.Size = new System.Drawing.Size(200, 31);
            this.textBox_partName.TabIndex = 13;
            // 
            // textBox_partPosition
            // 
            this.textBox_partPosition.Location = new System.Drawing.Point(217, 117);
            this.textBox_partPosition.Name = "textBox_partPosition";
            this.textBox_partPosition.Size = new System.Drawing.Size(200, 31);
            this.textBox_partPosition.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(483, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "ชื่อผู้ติดต่อกับตัวแทนจำหน่าย";
            this.label15.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_partID
            // 
            this.textBox_partID.Location = new System.Drawing.Point(217, 77);
            this.textBox_partID.Name = "textBox_partID";
            this.textBox_partID.Size = new System.Drawing.Size(200, 31);
            this.textBox_partID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "วันที่ครบกำหนดอายุใช้งาน";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(483, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "รูปชิ้นส่วนโดรน";
            this.label14.Click += new System.EventHandler(this.label4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(483, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "ที่อยู่ตัวแทนจำหน่าย";
            this.label13.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "ราคา (บาท)";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "เบอร์โทรตัวแทนจำหน่าย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "วันที่เริ่มใช้งาน";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "ชื่อตัวแทนจำหน่าย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "วันที่ลงทะเบียน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "ชื่อชิ้นส่วนโดรน";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "ตำแหน่งชิ้นส่วนโดรน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "รหัสชิ้นส่วนโดรน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // But_exit
            // 
            this.But_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.But_exit.FlatAppearance.BorderSize = 0;
            this.But_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_exit.Font = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold);
            this.But_exit.ForeColor = System.Drawing.Color.White;
            this.But_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.But_exit.Location = new System.Drawing.Point(472, 400);
            this.But_exit.Name = "But_exit";
            this.But_exit.Size = new System.Drawing.Size(130, 40);
            this.But_exit.TabIndex = 10;
            this.But_exit.Text = "ยกเลิก";
            this.But_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_exit.UseVisualStyleBackColor = false;
            this.But_exit.Click += new System.EventHandler(this.But_exit_Click);
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
            this.But_save.Location = new System.Drawing.Point(312, 400);
            this.But_save.Name = "But_save";
            this.But_save.Size = new System.Drawing.Size(130, 40);
            this.But_save.TabIndex = 6;
            this.But_save.Text = "บันทึก";
            this.But_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.But_save.UseVisualStyleBackColor = false;
            this.But_save.Click += new System.EventHandler(this.But_save_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Main_but_farm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 50);
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
            this.Main_but_farm.Size = new System.Drawing.Size(914, 50);
            this.Main_but_farm.TabIndex = 6;
            this.Main_but_farm.Text = "เพิ่มข้อมูลชิ้นส่วนโดรน";
            this.Main_but_farm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_but_farm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_but_farm.UseCompatibleTextRendering = true;
            this.Main_but_farm.UseVisualStyleBackColor = true;
            this.Main_but_farm.Click += new System.EventHandler(this.Main_but_farm_Click);
            // 
            // Form_Add_drone_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Add_drone_part";
            this.Text = "Drone\'s component Adding";
            this.panel1.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Main_farm;
        private System.Windows.Forms.Button But_exit;
        private System.Windows.Forms.Button But_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Main_but_farm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_partID;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_partPosition;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox_respond;
        private System.Windows.Forms.TextBox textBox_venAdd;
        private System.Windows.Forms.TextBox textBox_venPhone;
        private System.Windows.Forms.TextBox textBox_VenName;
        private System.Windows.Forms.TextBox textBox_partName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_serch;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExpDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_reg;
        private System.Windows.Forms.ComboBox comboBox_alarm;
        private System.Windows.Forms.Label label7;
    }
}