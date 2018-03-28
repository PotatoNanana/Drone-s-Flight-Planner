using System.Windows.Forms;
using MissionPlanner;

namespace MissionPlanner.Wizard
{
    partial class _6CompassCalib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_6CompassCalib));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUT_MagCalibrationLive = new MissionPlanner.Controls.MyButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radialGradientBG1 = new MissionPlanner.Controls.GradientBG();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BUT_compassorient = new MissionPlanner.Controls.MyButton();
            this.pictureBoxMouseOver3 = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.pictureBoxMouseOver2 = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.pictureBoxMouseOver1 = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialGradientBG1.Image)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseOver3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseOver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseOver1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BUT_MagCalibrationLive);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BUT_MagCalibrationLive
            // 
            this.BUT_MagCalibrationLive.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_MagCalibrationLive.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.BUT_MagCalibrationLive, "BUT_MagCalibrationLive");
            this.BUT_MagCalibrationLive.Name = "BUT_MagCalibrationLive";
            this.BUT_MagCalibrationLive.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_MagCalibrationLive.TextColor = System.Drawing.Color.White;
            this.BUT_MagCalibrationLive.UseVisualStyleBackColor = true;
            this.BUT_MagCalibrationLive.Click += new System.EventHandler(this.BUT_MagCalibration_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // radialGradientBG1
            // 
            this.radialGradientBG1.BackColor = System.Drawing.Color.Black;
            this.radialGradientBG1.CenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            // 
            // 
            // 
            this.radialGradientBG1.Image.BackColor = System.Drawing.Color.Transparent;
            this.radialGradientBG1.Image.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radialGradientBG1.Image.ImeMode")));
            this.radialGradientBG1.Image.Location = ((System.Drawing.Point)(resources.GetObject("radialGradientBG1.Image.Location")));
            this.radialGradientBG1.Image.MaximumSize = ((System.Drawing.Size)(resources.GetObject("radialGradientBG1.Image.MaximumSize")));
            this.radialGradientBG1.Image.MinimumSize = ((System.Drawing.Size)(resources.GetObject("radialGradientBG1.Image.MinimumSize")));
            this.radialGradientBG1.Image.Name = "_Image";
            this.radialGradientBG1.Image.Size = ((System.Drawing.Size)(resources.GetObject("radialGradientBG1.Image.Size")));
            this.radialGradientBG1.Image.TabIndex = ((int)(resources.GetObject("radialGradientBG1.Image.TabIndex")));
            this.radialGradientBG1.Image.TabStop = false;
            this.radialGradientBG1.Image.Visible = ((bool)(resources.GetObject("radialGradientBG1.Image.Visible")));
            // 
            // 
            // 
            this.radialGradientBG1.Label.AutoSize = ((bool)(resources.GetObject("radialGradientBG1.Label.AutoSize")));
            this.radialGradientBG1.Label.BackColor = System.Drawing.Color.Transparent;
            this.radialGradientBG1.Label.Font = ((System.Drawing.Font)(resources.GetObject("radialGradientBG1.Label.Font")));
            this.radialGradientBG1.Label.ForeColor = System.Drawing.Color.Black;
            this.radialGradientBG1.Label.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("radialGradientBG1.Label.ImeMode")));
            this.radialGradientBG1.Label.Location = ((System.Drawing.Point)(resources.GetObject("radialGradientBG1.Label.Location")));
            this.radialGradientBG1.Label.Name = "_Label";
            this.radialGradientBG1.Label.Size = ((System.Drawing.Size)(resources.GetObject("radialGradientBG1.Label.Size")));
            this.radialGradientBG1.Label.TabIndex = ((int)(resources.GetObject("radialGradientBG1.Label.TabIndex")));
            this.radialGradientBG1.Label.Text = resources.GetString("radialGradientBG1.Label.Text");
            resources.ApplyResources(this.radialGradientBG1, "radialGradientBG1");
            this.radialGradientBG1.Name = "radialGradientBG1";
            this.radialGradientBG1.OutsideColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BUT_compassorient);
            this.panel2.Controls.Add(this.pictureBoxMouseOver3);
            this.panel2.Controls.Add(this.pictureBoxMouseOver2);
            this.panel2.Controls.Add(this.pictureBoxMouseOver1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // BUT_compassorient
            // 
            this.BUT_compassorient.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_compassorient.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.BUT_compassorient, "BUT_compassorient");
            this.BUT_compassorient.Name = "BUT_compassorient";
            this.BUT_compassorient.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.BUT_compassorient.TextColor = System.Drawing.Color.White;
            this.BUT_compassorient.UseVisualStyleBackColor = true;
            this.BUT_compassorient.Click += new System.EventHandler(this.BUT_compassorient_Click);
            // 
            // pictureBoxMouseOver3
            // 
            this.pictureBoxMouseOver3.Image = global::MissionPlanner.Properties.Resources.apmp2;
            this.pictureBoxMouseOver3.ImageNormal = global::MissionPlanner.Properties.Resources.apmp2;
            this.pictureBoxMouseOver3.ImageOver = global::MissionPlanner.Properties.Resources.apmp2;
            resources.ApplyResources(this.pictureBoxMouseOver3, "pictureBoxMouseOver3");
            this.pictureBoxMouseOver3.Name = "pictureBoxMouseOver3";
            this.pictureBoxMouseOver3.selected = false;
            this.pictureBoxMouseOver3.TabStop = false;
            this.pictureBoxMouseOver3.Tag = "apm2";
            this.pictureBoxMouseOver3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxMouseOver2
            // 
            this.pictureBoxMouseOver2.Image = global::MissionPlanner.Properties.Resources.px4;
            this.pictureBoxMouseOver2.ImageNormal = global::MissionPlanner.Properties.Resources.px4;
            this.pictureBoxMouseOver2.ImageOver = global::MissionPlanner.Properties.Resources.px4;
            resources.ApplyResources(this.pictureBoxMouseOver2, "pictureBoxMouseOver2");
            this.pictureBoxMouseOver2.Name = "pictureBoxMouseOver2";
            this.pictureBoxMouseOver2.selected = false;
            this.pictureBoxMouseOver2.TabStop = false;
            this.pictureBoxMouseOver2.Tag = "px4";
            this.pictureBoxMouseOver2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxMouseOver1
            // 
            this.pictureBoxMouseOver1.Image = global::MissionPlanner.Properties.Resources.maggps;
            this.pictureBoxMouseOver1.ImageNormal = global::MissionPlanner.Properties.Resources.maggps;
            this.pictureBoxMouseOver1.ImageOver = global::MissionPlanner.Properties.Resources.maggps;
            resources.ApplyResources(this.pictureBoxMouseOver1, "pictureBoxMouseOver1");
            this.pictureBoxMouseOver1.Name = "pictureBoxMouseOver1";
            this.pictureBoxMouseOver1.selected = false;
            this.pictureBoxMouseOver1.TabStop = false;
            this.pictureBoxMouseOver1.Tag = "external";
            this.pictureBoxMouseOver1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _6CompassCalib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radialGradientBG1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "_6CompassCalib";
            resources.ApplyResources(this, "$this");
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialGradientBG1.Image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseOver3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseOver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseOver1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Controls.GradientBG radialGradientBG1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Controls.PictureBoxMouseOver pictureBoxMouseOver1;
        private Controls.PictureBoxMouseOver pictureBoxMouseOver2;
        private LinkLabel linkLabel1;
        private Controls.MyButton BUT_MagCalibrationLive;
        private Controls.PictureBoxMouseOver pictureBoxMouseOver3;
        private Label label5;
        private Controls.MyButton BUT_compassorient;
        private Timer timer1;
        private Label label6;

    }
}