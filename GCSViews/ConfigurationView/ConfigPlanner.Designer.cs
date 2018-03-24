namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigPlanner));
            this.label26 = new System.Windows.Forms.Label();
            this.CMB_videoresolutions = new System.Windows.Forms.ComboBox();
            this.CHK_speechaltwarning = new System.Windows.Forms.CheckBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.CMB_speedunits = new System.Windows.Forms.ComboBox();
            this.CMB_distunits = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.CHK_speechbattery = new System.Windows.Forms.CheckBox();
            this.CHK_speechcustom = new System.Windows.Forms.CheckBox();
            this.CHK_speechmode = new System.Windows.Forms.CheckBox();
            this.CHK_speechwaypoint = new System.Windows.Forms.CheckBox();
            this.CHK_enablespeech = new System.Windows.Forms.CheckBox();
            this.CHK_hudshow = new System.Windows.Forms.CheckBox();
            this.label92 = new System.Windows.Forms.Label();
            this.CMB_videosources = new System.Windows.Forms.ComboBox();
            this.BUT_Joystick = new MissionPlanner.Controls.MyButton();
            this.BUT_videostop = new MissionPlanner.Controls.MyButton();
            this.BUT_videostart = new MissionPlanner.Controls.MyButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_log_dir = new System.Windows.Forms.TextBox();
            this.BUT_logdirbrowse = new MissionPlanner.Controls.MyButton();
            this.CHK_speecharmdisarm = new System.Windows.Forms.CheckBox();
            this.CHK_speechlowspeed = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CHK_disttohomeflightdata = new System.Windows.Forms.CheckBox();
            this.CHK_resetapmonconnect = new System.Windows.Forms.CheckBox();
            this.label108 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // CMB_videoresolutions
            // 
            this.CMB_videoresolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_videoresolutions.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_videoresolutions, "CMB_videoresolutions");
            this.CMB_videoresolutions.Name = "CMB_videoresolutions";
            // 
            // CHK_speechaltwarning
            // 
            resources.ApplyResources(this.CHK_speechaltwarning, "CHK_speechaltwarning");
            this.CHK_speechaltwarning.Name = "CHK_speechaltwarning";
            this.CHK_speechaltwarning.UseVisualStyleBackColor = true;
            this.CHK_speechaltwarning.CheckedChanged += new System.EventHandler(this.CHK_speechaltwarning_CheckedChanged);
            // 
            // label98
            // 
            resources.ApplyResources(this.label98, "label98");
            this.label98.Name = "label98";
            // 
            // label97
            // 
            resources.ApplyResources(this.label97, "label97");
            this.label97.Name = "label97";
            // 
            // CMB_speedunits
            // 
            this.CMB_speedunits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_speedunits.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_speedunits, "CMB_speedunits");
            this.CMB_speedunits.Name = "CMB_speedunits";
            this.CMB_speedunits.SelectedIndexChanged += new System.EventHandler(this.CMB_speedunits_SelectedIndexChanged);
            // 
            // CMB_distunits
            // 
            this.CMB_distunits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_distunits.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_distunits, "CMB_distunits");
            this.CMB_distunits.Name = "CMB_distunits";
            this.CMB_distunits.SelectedIndexChanged += new System.EventHandler(this.CMB_distunits_SelectedIndexChanged);
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.Name = "label96";
            // 
            // label95
            // 
            resources.ApplyResources(this.label95, "label95");
            this.label95.Name = "label95";
            // 
            // CHK_speechbattery
            // 
            resources.ApplyResources(this.CHK_speechbattery, "CHK_speechbattery");
            this.CHK_speechbattery.Name = "CHK_speechbattery";
            this.CHK_speechbattery.UseVisualStyleBackColor = true;
            this.CHK_speechbattery.CheckedChanged += new System.EventHandler(this.CHK_speechbattery_CheckedChanged);
            // 
            // CHK_speechcustom
            // 
            resources.ApplyResources(this.CHK_speechcustom, "CHK_speechcustom");
            this.CHK_speechcustom.Name = "CHK_speechcustom";
            this.CHK_speechcustom.UseVisualStyleBackColor = true;
            this.CHK_speechcustom.CheckedChanged += new System.EventHandler(this.CHK_speechcustom_CheckedChanged);
            // 
            // CHK_speechmode
            // 
            resources.ApplyResources(this.CHK_speechmode, "CHK_speechmode");
            this.CHK_speechmode.Name = "CHK_speechmode";
            this.CHK_speechmode.UseVisualStyleBackColor = true;
            this.CHK_speechmode.CheckedChanged += new System.EventHandler(this.CHK_speechmode_CheckedChanged);
            // 
            // CHK_speechwaypoint
            // 
            resources.ApplyResources(this.CHK_speechwaypoint, "CHK_speechwaypoint");
            this.CHK_speechwaypoint.Name = "CHK_speechwaypoint";
            this.CHK_speechwaypoint.UseVisualStyleBackColor = true;
            this.CHK_speechwaypoint.CheckedChanged += new System.EventHandler(this.CHK_speechwaypoint_CheckedChanged);
            // 
            // CHK_enablespeech
            // 
            resources.ApplyResources(this.CHK_enablespeech, "CHK_enablespeech");
            this.CHK_enablespeech.Name = "CHK_enablespeech";
            this.CHK_enablespeech.UseVisualStyleBackColor = true;
            this.CHK_enablespeech.CheckedChanged += new System.EventHandler(this.CHK_enablespeech_CheckedChanged);
            // 
            // CHK_hudshow
            // 
            this.CHK_hudshow.Checked = true;
            this.CHK_hudshow.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_hudshow, "CHK_hudshow");
            this.CHK_hudshow.Name = "CHK_hudshow";
            this.CHK_hudshow.UseVisualStyleBackColor = true;
            this.CHK_hudshow.CheckedChanged += new System.EventHandler(this.CHK_hudshow_CheckedChanged);
            // 
            // label92
            // 
            resources.ApplyResources(this.label92, "label92");
            this.label92.Name = "label92";
            // 
            // CMB_videosources
            // 
            this.CMB_videosources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_videosources.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_videosources, "CMB_videosources");
            this.CMB_videosources.Name = "CMB_videosources";
            this.CMB_videosources.SelectedIndexChanged += new System.EventHandler(this.CMB_videosources_SelectedIndexChanged);
            this.CMB_videosources.Click += new System.EventHandler(this.CMB_videosources_Click);
            // 
            // BUT_Joystick
            // 
            this.BUT_Joystick.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_Joystick.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_Joystick.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.BUT_Joystick, "BUT_Joystick");
            this.BUT_Joystick.Name = "BUT_Joystick";
            this.BUT_Joystick.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_Joystick.TextColor = System.Drawing.Color.White;
            this.BUT_Joystick.UseVisualStyleBackColor = true;
            this.BUT_Joystick.Click += new System.EventHandler(this.BUT_Joystick_Click);
            // 
            // BUT_videostop
            // 
            this.BUT_videostop.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostop.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostop.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.BUT_videostop, "BUT_videostop");
            this.BUT_videostop.Name = "BUT_videostop";
            this.BUT_videostop.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostop.TextColor = System.Drawing.Color.White;
            this.BUT_videostop.UseVisualStyleBackColor = true;
            this.BUT_videostop.Click += new System.EventHandler(this.BUT_videostop_Click);
            // 
            // BUT_videostart
            // 
            this.BUT_videostart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostart.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostart.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostart.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.BUT_videostart, "BUT_videostart");
            this.BUT_videostart.ForeColor = System.Drawing.Color.White;
            this.BUT_videostart.Name = "BUT_videostart";
            this.BUT_videostart.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_videostart.TextColor = System.Drawing.Color.White;
            this.BUT_videostart.UseVisualStyleBackColor = false;
            this.BUT_videostart.Click += new System.EventHandler(this.BUT_videostart_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_log_dir
            // 
            resources.ApplyResources(this.txt_log_dir, "txt_log_dir");
            this.txt_log_dir.Name = "txt_log_dir";
            // 
            // BUT_logdirbrowse
            // 
            this.BUT_logdirbrowse.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_logdirbrowse.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_logdirbrowse.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.BUT_logdirbrowse, "BUT_logdirbrowse");
            this.BUT_logdirbrowse.Name = "BUT_logdirbrowse";
            this.BUT_logdirbrowse.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_logdirbrowse.TextColor = System.Drawing.Color.White;
            this.BUT_logdirbrowse.UseVisualStyleBackColor = true;
            this.BUT_logdirbrowse.Click += new System.EventHandler(this.BUT_logdirbrowse_Click);
            // 
            // CHK_speecharmdisarm
            // 
            resources.ApplyResources(this.CHK_speecharmdisarm, "CHK_speecharmdisarm");
            this.CHK_speecharmdisarm.Name = "CHK_speecharmdisarm";
            this.CHK_speecharmdisarm.UseVisualStyleBackColor = true;
            this.CHK_speecharmdisarm.CheckedChanged += new System.EventHandler(this.CHK_speecharmdisarm_CheckedChanged);
            // 
            // CHK_speechlowspeed
            // 
            resources.ApplyResources(this.CHK_speechlowspeed, "CHK_speechlowspeed");
            this.CHK_speechlowspeed.Name = "CHK_speechlowspeed";
            this.CHK_speechlowspeed.UseVisualStyleBackColor = true;
            this.CHK_speechlowspeed.CheckedChanged += new System.EventHandler(this.CHK_speechlowspeed_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CHK_disttohomeflightdata
            // 
            this.CHK_disttohomeflightdata.Checked = true;
            this.CHK_disttohomeflightdata.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_disttohomeflightdata, "CHK_disttohomeflightdata");
            this.CHK_disttohomeflightdata.Name = "CHK_disttohomeflightdata";
            this.CHK_disttohomeflightdata.UseVisualStyleBackColor = true;
            this.CHK_disttohomeflightdata.CheckedChanged += new System.EventHandler(this.CHK_disttohomeflightdata_CheckedChanged);
            // 
            // CHK_resetapmonconnect
            // 
            this.CHK_resetapmonconnect.Checked = true;
            this.CHK_resetapmonconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_resetapmonconnect, "CHK_resetapmonconnect");
            this.CHK_resetapmonconnect.Name = "CHK_resetapmonconnect";
            this.CHK_resetapmonconnect.UseVisualStyleBackColor = true;
            this.CHK_resetapmonconnect.CheckedChanged += new System.EventHandler(this.CHK_resetapmonconnect_CheckedChanged);
            // 
            // label108
            // 
            resources.ApplyResources(this.label108, "label108");
            this.label108.Name = "label108";
            // 
            // ConfigPlanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.CHK_speechlowspeed);
            this.Controls.Add(this.CHK_speecharmdisarm);
            this.Controls.Add(this.BUT_logdirbrowse);
            this.Controls.Add(this.txt_log_dir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CHK_disttohomeflightdata);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.CMB_videoresolutions);
            this.Controls.Add(this.CHK_speechaltwarning);
            this.Controls.Add(this.label108);
            this.Controls.Add(this.CHK_resetapmonconnect);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.CMB_speedunits);
            this.Controls.Add(this.CMB_distunits);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.CHK_speechbattery);
            this.Controls.Add(this.CHK_speechcustom);
            this.Controls.Add(this.CHK_speechmode);
            this.Controls.Add(this.CHK_speechwaypoint);
            this.Controls.Add(this.CHK_enablespeech);
            this.Controls.Add(this.CHK_hudshow);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.CMB_videosources);
            this.Controls.Add(this.BUT_Joystick);
            this.Controls.Add(this.BUT_videostop);
            this.Controls.Add(this.BUT_videostart);
            resources.ApplyResources(this, "$this");
            this.Name = "ConfigPlanner";
            this.Load += new System.EventHandler(this.ConfigPlanner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox CMB_videoresolutions;
        private System.Windows.Forms.CheckBox CHK_speechaltwarning;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.ComboBox CMB_speedunits;
        private System.Windows.Forms.ComboBox CMB_distunits;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.CheckBox CHK_speechbattery;
        private System.Windows.Forms.CheckBox CHK_speechcustom;
        private System.Windows.Forms.CheckBox CHK_speechmode;
        private System.Windows.Forms.CheckBox CHK_speechwaypoint;
        private System.Windows.Forms.CheckBox CHK_enablespeech;
        private System.Windows.Forms.CheckBox CHK_hudshow;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.ComboBox CMB_videosources;
        private Controls.MyButton BUT_Joystick;
        private Controls.MyButton BUT_videostop;
        private Controls.MyButton BUT_videostart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_log_dir;
        private Controls.MyButton BUT_logdirbrowse;
        private System.Windows.Forms.CheckBox CHK_speecharmdisarm;
        private System.Windows.Forms.CheckBox CHK_speechlowspeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CHK_disttohomeflightdata;
        private System.Windows.Forms.CheckBox CHK_resetapmonconnect;
        private System.Windows.Forms.Label label108;
    }
}
