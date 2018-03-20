namespace MissionPlanner.Controls
{
    partial class SITL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SITL));
            this.myGMAP1 = new MissionPlanner.Controls.myGMAP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxquad = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUM_heading = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_wipe = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cmdline = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_simspeed = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxquad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_heading)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_simspeed)).BeginInit();
            this.SuspendLayout();
            // 
            // myGMAP1
            // 
            this.myGMAP1.Bearing = 0F;
            this.myGMAP1.CanDragMap = true;
            this.myGMAP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGMAP1.EmptyTileColor = System.Drawing.Color.Navy;
            this.myGMAP1.GrayScaleMode = false;
            this.myGMAP1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.myGMAP1.LevelsKeepInMemmory = 5;
            this.myGMAP1.Location = new System.Drawing.Point(3, 27);
            this.myGMAP1.MarkersEnabled = true;
            this.myGMAP1.MaxZoom = 2;
            this.myGMAP1.MinZoom = 2;
            this.myGMAP1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.myGMAP1.Name = "myGMAP1";
            this.myGMAP1.NegativeMode = false;
            this.myGMAP1.PolygonsEnabled = true;
            this.myGMAP1.RetryLoadTile = 0;
            this.myGMAP1.RoutesEnabled = true;
            this.myGMAP1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.myGMAP1.SelectedArea = ((GMap.NET.RectLatLng)(resources.GetObject("myGMAP1.SelectedArea")));
            this.myGMAP1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.myGMAP1.ShowTileGridLines = false;
            this.myGMAP1.Size = new System.Drawing.Size(831, 292);
            this.myGMAP1.TabIndex = 0;
            this.myGMAP1.Zoom = 0D;
            this.myGMAP1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.myGMAP1_OnMarkerEnter);
            this.myGMAP1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.myGMAP1_OnMarkerLeave);
            this.myGMAP1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myGMAP1_MouseDown);
            this.myGMAP1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myGMAP1_MouseMove);
            this.myGMAP1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myGMAP1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBoxquad);
            this.panel1.Location = new System.Drawing.Point(60, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 137);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(358, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "โดรน";
            // 
            // pictureBoxquad
            // 
            this.pictureBoxquad.Image = global::MissionPlanner.Properties.Resources.light_05;
            this.pictureBoxquad.ImageNormal = global::MissionPlanner.Properties.Resources.light_05;
            this.pictureBoxquad.ImageOver = global::MissionPlanner.Properties.Resources._01_05;
            this.pictureBoxquad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxquad.Location = new System.Drawing.Point(311, 0);
            this.pictureBoxquad.Name = "pictureBoxquad";
            this.pictureBoxquad.selected = false;
            this.pictureBoxquad.Size = new System.Drawing.Size(125, 112);
            this.pictureBoxquad.TabIndex = 12;
            this.pictureBoxquad.TabStop = false;
            this.pictureBoxquad.Tag = "copter";
            this.pictureBoxquad.Click += new System.EventHandler(this.pictureBoxquad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.myGMAP1);
            this.groupBox1.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 322);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "จุดกำหนดที่ตั้งของฟาร์ม";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "คลิกปุ่มเพื่อเริ่มดำเนินการ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.NUM_heading);
            this.groupBox3.Location = new System.Drawing.Point(13, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heading";
            // 
            // NUM_heading
            // 
            this.NUM_heading.Location = new System.Drawing.Point(68, 18);
            this.NUM_heading.Name = "NUM_heading";
            this.NUM_heading.Size = new System.Drawing.Size(43, 21);
            this.NUM_heading.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chk_wipe);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_cmdline);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmb_model);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.num_simspeed);
            this.groupBox4.Location = new System.Drawing.Point(152, 341);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(698, 43);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced users only";
            // 
            // chk_wipe
            // 
            this.chk_wipe.AutoSize = true;
            this.chk_wipe.Location = new System.Drawing.Point(638, 17);
            this.chk_wipe.Name = "chk_wipe";
            this.chk_wipe.Size = new System.Drawing.Size(55, 20);
            this.chk_wipe.TabIndex = 12;
            this.chk_wipe.Text = "Wipe";
            this.chk_wipe.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Extra command line";
            // 
            // txt_cmdline
            // 
            this.txt_cmdline.Location = new System.Drawing.Point(418, 17);
            this.txt_cmdline.Name = "txt_cmdline";
            this.txt_cmdline.Size = new System.Drawing.Size(213, 21);
            this.txt_cmdline.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Model";
            // 
            // cmb_model
            // 
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Items.AddRange(new object[] {
            "",
            "quadplane",
            "xplane",
            "xplane-heli",
            "firefly",
            "+",
            "quad",
            "copter",
            "x",
            "hexa",
            "octa",
            "tri",
            "y6",
            "heli",
            "heli-dual",
            "heli-compound",
            "singlecopter",
            "coaxcopter",
            "rover",
            "crrcsim",
            "jsbsim",
            "flightaxis",
            "gazebo",
            "last_letter",
            "tracker",
            "balloon",
            "plane",
            "calibration"});
            this.cmb_model.Location = new System.Drawing.Point(176, 17);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(114, 24);
            this.cmb_model.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sim Speed";
            // 
            // num_simspeed
            // 
            this.num_simspeed.Location = new System.Drawing.Point(77, 18);
            this.num_simspeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_simspeed.Name = "num_simspeed";
            this.num_simspeed.Size = new System.Drawing.Size(44, 21);
            this.num_simspeed.TabIndex = 6;
            this.num_simspeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SITL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SITL";
            this.Size = new System.Drawing.Size(862, 544);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxquad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_heading)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_simspeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myGMAP myGMAP1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private PictureBoxMouseOver pictureBoxquad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUM_heading;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_simspeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cmdline;
        private System.Windows.Forms.CheckBox chk_wipe;
    }
}